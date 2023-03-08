using MediatR;
using Microsoft.EntityFrameworkCore;
using TicTacToe.App.Interfaces;

namespace TicTacToe.App.TicTacToes.Commands.Delete
{
    public class DeleteCommandHandler : IRequestHandler<DeleteCommand, Unit>
    {
        private readonly IAppDbContext _dbContext;
        public DeleteCommandHandler(IAppDbContext dbContext) => _dbContext = dbContext;

        public async Task<Unit> Handle(DeleteCommand request, CancellationToken cancellationToken){
            var ticTacToe = await _dbContext.TicTacToeModels!.FirstOrDefaultAsync(ticTacToe => 
                ticTacToe.SessionId == request.SessionId, cancellationToken);
            if(ticTacToe == null){
                throw new Exception("Not found");
            }

            _dbContext.TicTacToeModels!.Remove(ticTacToe);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
        
    }
}