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
      command.CommandText = @"SELECT ""surname"", ""name"", ""otchestvo"", ""birthday"", ""number"", ""litera"" FROM ""F.studentforklasses"" D
      LEFT JOIN ""F.students"" N ON(N.""ID"" = D.""studentsID"")
      LEFT JOIN ""F.klases"" E ON(E.""ID"" = D.""klasesID"")";

      var reader = command.ExecuteReader();
      while (reader.Read())
      {
        var surname = reader.GetFieldValue<string>(0);
        var name = reader.GetFieldValue<string>(1);
        var otchestvo = reader.GetFieldValue<string>(2);
        var birthday = reader.GetFieldValue<string>(3);
        var number = reader.GetFieldValue<int>(4);
        var litera = reader.GetFieldValue<string>(5);

        Console.WriteLine($"{surname}|{name}|{otchestvo}|{birthday}|{number}|{litera}");
      }
    }
  }
}
