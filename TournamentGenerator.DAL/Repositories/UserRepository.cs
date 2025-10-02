namespace TI_Net2025_DemoCleanAsp.DAL.Repositories;

public class UserRepository
{
    private readonly string _connectionString;

    public UserRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void Add(User user)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        using (var command = new NpgsqlCommand())
        {
            command.Connection = connection;
            command.CommandText = @"
                INSERT INTO ""User"" (email, username, password, role)
                VALUES (@email, @username, @password, @role)
                RETURNING id";

            command.Parameters.AddWithValue("email", user.Email ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("username", user.Username ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("password", user.Password ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("role", user.Role?.ToString() ?? (object)DBNull.Value);

            connection.Open();
            int newId = (int)command.ExecuteScalar();
        }
    }

    public User? GetUserByEmail(string email)
    {
        
    }

    public bool ExistUserByEmail(string email)
    {
        
    }
}