using MediatR;
using TicTacToe.Domain;

namespace TicTacToe.App.TicTacToes.Commands.Create
{
    public class CreateCommand : IRequest<TicTacToeModel>
    {
        public int? x1y1 {get; set;}
        public int? x2y1 {get; set;}
        public int? x3y1 {get; set;}
        public int? x1y2 {get; set;}
        public int? x2y2 {get; set;}
        public int? x3y2 {get; set;}
        public int? x1y3 {get; set;}        
        public int? x2y3 {get; set;}
        public int? x3y3 {get; set;}

        public Guid? Player1 {get; set;}
        public Guid? Player2 {get; set;}
    }
}