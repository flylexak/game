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
      command.CommandText = @"SELECT * FROM ""qwzc.dates""";
      var reader = command.ExecuteReader();
      while (reader.Read())
      {
        var nameId = reader.GetFieldValue<int>(0);
        var eventId = reader.GetFieldValue<int>(1);
        var date = reader.GetFieldValue<string>(2);

        Console.WriteLine($"{nameId}|{eventId}|{date}");
      }
    }
  }
}
