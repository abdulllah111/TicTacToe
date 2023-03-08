using MediatR;
using TicTacToe.Domain;

namespace TicTacToe.App.TicTacToes.Queries.GetDetails
{
    public class GetDetailsQuery : IRequest<TicTacToeModel>
    {
        public Guid SessionId {get; set;}
    }
}