using MediatR;
using TicTacToe.Domain;

namespace TicTacToe.App.TicTacToes.Commands.Update
{
    public class UpdateCommand : IRequest<TicTacToeModel>
    {
        public Guid SessionId {get; set;}
        public int? x1y1 {get; set;}
        public int? x2y1 {get; set;}
        public int? x3y1 {get; set;}
        public int? x1y2 {get; set;}
        public int? x2y2 {get; set;}
        public int? x3y2 {get; set;}
        public int? x1y3 {get; set;}        
        public int? x2y3 {get; set;}
        public int? x3y3 {get; set;}
    }
}