using MediatR;
using Microsoft.EntityFrameworkCore;
using TicTacToe.App.Interfaces;
using TicTacToe.Domain;

namespace TicTacToe.App.TicTacToes.Queries.GetDetails
{
    public class GetDetailsQueryHandler : IRequestHandler<GetDetailsQuery, TicTacToeModel>
    {
        private readonly IAppDbContext _dbContext;
        public GetDetailsQueryHandler(IAppDbContext dbContext) => _dbContext = dbContext;

        public async Task<TicTacToeModel> Handle(GetDetailsQuery request, CancellationToken cancellationToken)
        {
            var ticTacToe = await _dbContext.TicTacToeModels!
                .FirstOrDefaultAsync(ticTacToe => ticTacToe.SessionId == request.SessionId, cancellationToken);
            
            if(ticTacToe == null){
                throw new Exception($"Not found {request.SessionId}");
            }

            return ticTacToe;
        }
    }
}