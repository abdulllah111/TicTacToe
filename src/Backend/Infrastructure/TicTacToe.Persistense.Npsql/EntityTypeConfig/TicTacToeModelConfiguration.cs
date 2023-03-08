using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicTacToe.Domain;

namespace TicTacToe.Persistense.Npsql.EntityTypeConfig
{
    public class TicTacToeModelConfiguration : IEntityTypeConfiguration<TicTacToeModel>
    {
        public void Configure(EntityTypeBuilder<TicTacToeModel> builder)
        {
            builder.HasKey(ticTacToeModel => ticTacToeModel.SessionId);
            builder.HasIndex(ticTacToeModel => ticTacToeModel.SessionId).IsUnique();
        }
    }
}