using MediatR;

namespace TicTacToe.App.TicTacToes.Commands.Delete
{
    public class DeleteCommand : IRequest
    {
        public Guid SessionId {get; set;}
    }
}