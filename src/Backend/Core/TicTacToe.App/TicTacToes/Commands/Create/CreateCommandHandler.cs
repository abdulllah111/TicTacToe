using MediatR;
using TicTacToe.App.Interfaces;
using TicTacToe.Domain;

namespace TicTacToe.App.TicTacToes.Commands.Create
{
    public class CreateCommandHandler : IRequestHandler<CreateCommand, TicTacToeModel>
    {
        private readonly IAppDbContext _dbContext;
        public CreateCommandHandler(IAppDbContext dbContext) => _dbContext = dbContext;
        public async Task<TicTacToeModel> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            var ticTacToe = new TicTacToeModel{
                SessionId = Guid.NewGuid(),
                x1y1 = request.x1y1,
                x2y1 = request.x2y1,
                x3y1 = request.x3y1,
                x1y2 = request.x1y2,
                x2y2 = request.x2y2,
                x3y2 = request.x3y2,
                x1y3 = request.x1y3,        
                x2y3 = request.x2y3,
                x3y3 = request.x3y3,

                Player1 = request.Player1,
                Player2 = request.Player2
            };
            await _dbContext.TicTacToeModels!.AddAsync(ticTacToe, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return ticTacToe;
        }
    }
}