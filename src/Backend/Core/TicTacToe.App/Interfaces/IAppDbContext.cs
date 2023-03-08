using TicTacToe.Domain;
using Microsoft.EntityFrameworkCore;

namespace TicTacToe.App.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<TicTacToeModel>? TicTacToeModels {get; set;}
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}