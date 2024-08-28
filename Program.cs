using System;
using Microsoft.Data.Sqlite;

class Program
{
    static void Main()
    {
        var connectionString = "Data Source=test.db";

        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            var createTableCommand = connection.CreateCommand();
            createTableCommand.CommandText = @"
                CREATE TABLE IF NOT EXISTS Usuarios (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT,
                    Email TEXT
                );
            ";
            createTableCommand.ExecuteNonQuery();

            var insertCommand = connection.CreateCommand();
            insertCommand.CommandText = @"
                INSERT INTO Usuarios (Nombre, Email)
                VALUES
                    ('Juan Pérez', 'juan.perez@example.com'),
                    ('Ana Gómez', 'ana.gomez@example.com'),
                    ('Luis Martínez', 'luis.martinez@example.com');
            ";
            insertCommand.ExecuteNonQuery();

            var selectCommand = connection.CreateCommand();
            selectCommand.CommandText = "SELECT * FROM Usuarios";

            using (var reader = selectCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["ID"]}: {reader["Nombre"]} - {reader["Email"]}");
                }
            }
        }
    }
}
