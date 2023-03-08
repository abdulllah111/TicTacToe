using Microsoft.EntityFrameworkCore;
using TicTacToe.App.Interfaces;
using TicTacToe.Domain;
using TicTacToe.Persistense.Npsql.EntityTypeConfig;

namespace TicTacToe.Persistense.Npsql
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public DbSet<TicTacToeModel>? TicTacToeModels { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options!) {}
        protected override void OnModelCreating(ModelBuilder builder){
            builder.ApplyConfiguration(new TicTacToeModelConfiguration());
            base.OnModelCreating(builder);
        }
    }
}