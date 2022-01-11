using System;
using Npgsql;

namespace heidy
{
  class Program
  {
    static void Main(string[] args)
    {
      var connection = new NpgsqlConnection();
      connection.ConnectionString = "Host=10.46.1.131; Port=5432; Database=ITB15; Username=postgres; Password=12345";
      connection.Open();
      var command = connection.CreateCommand();
      command.CommandText = "INSERT INTO \"qwzc.events\" (\"ID\", \"Events\") VALUES (17, 'HappyBirthday'), (27, 'LoveDay'), (37, 'NewYear')";
      command.ExecuteNonQuery();
    }
  }
}
