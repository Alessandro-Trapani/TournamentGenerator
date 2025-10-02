namespace TI_Net2025_DemoCleanAsp.DAL.Repositories;

public class TournamentRepository
{
    private readonly string _connectionString;

    public TournamentRepository(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public void Create()
}