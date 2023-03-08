using MediatR;
using Microsoft.EntityFrameworkCore;
using TicTacToe.App.Interfaces;
using TicTacToe.Domain;

namespace TicTacToe.App.TicTacToes.Commands.Update
{
    public class UpdateCommandHandler : IRequestHandler<UpdateCommand, TicTacToeModel>
    {
        private readonly IAppDbContext _dbContext;
        public UpdateCommandHandler(IAppDbContext dbContext) => _dbContext = dbContext;

        public async Task<TicTacToeModel> Handle(UpdateCommand request, CancellationToken cancellationToken)
        {
            var ticTacToe = await _dbContext.TicTacToeModels!.FirstOrDefaultAsync(ticTacToe => 
                ticTacToe.SessionId == request.SessionId, cancellationToken);
            if(ticTacToe == null){
                throw new Exception("Not found");
            }

            ticTacToe.x1y1 = request.x1y1;
            ticTacToe.x2y1 = request.x2y1;
            ticTacToe.x3y1 = request.x3y1;
            ticTacToe.x1y2 = request.x1y2;
            ticTacToe.x2y2 = request.x2y2;
            ticTacToe.x3y2 = request.x3y2;
            ticTacToe.x1y3 = request.x1y3;        
            ticTacToe.x2y3 = request.x2y3;
            ticTacToe.x3y3 = request.x3y3;

            await _dbContext.SaveChangesAsync(cancellationToken);
            return ticTacToe;
        }
    }
}