namespace TicTacToe.Persistense.Npsql
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext appDbContext){
            appDbContext.Database.EnsureCreated();
        }
    }
}