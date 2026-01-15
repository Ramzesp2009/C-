using System;
using System.Data.Common;
using System.Data.Odbc;
#if PC
  using System.Data.OleDb;
#endif
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using DataProviderFactory;

Console.WriteLine("***** Fun with Data Provider Factory *****\n");
var (provider, connectionString) = GetProviderFromConfiguration();
DbProviderFactory factory = GetDbProviderFactory(provider);
using (DbConnection connection = factory.CreateConnection())
{
    if (connection == null)
    {
        Console.WriteLine($"Unable to create the connectionobject");
        return;
    }

    Console.WriteLine($"Your connection object is a: {connection.GetType().Name}");
    connection.ConnectionString = connectionString;
    connection.Open();

    DbCommand? command = factory.CreateCommand();
    if (command == null)
    {
        Console.WriteLine($"Unable to create the command object");
        return;
    }
    Console.WriteLine($"Your command object is a: {command.GetType().Name}");
    command.Connection = connection;
    command.CommandText = "Select i.Id, m.Name From Inventory i inner join Makes m on m.Id = i.MakeId";
    using (DbDataReader dataReader = command.ExecuteReader())
    {
        Console.WriteLine($"Your data reaer object is a: {dataReader.GetType().Name}");
        Console.WriteLine("\n***** Current Inventory *****");
        while (dataReader.Read())
        {
            Console.WriteLine($"-> Car #{dataReader["Id"]} is a {dataReader["Name"]}.");
        }
    }
}

static DbProviderFactory GetDbProviderFactory(DataProviderEnum provider) => provider switch
{
    DataProviderEnum.SqlServer => SqlClientFactory.Instance,
    DataProviderEnum.Odbc => OdbcFactory.Instance,
#if PC
    DataProviderEnum.OleDb => OleDbFactory.Instance,
#endif
    _ => throw new NotSupportedException($"Provider {provider} is not supported.")
};

static (DataProviderEnum Provider, string? ConnectionString) GetProviderFromConfiguration()
{
    IConfiguration config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true)
        .Build();
    var providerName = config["ProviderName"];

    if (Enum.TryParse(providerName, out DataProviderEnum providerEnum))
    {
        //var connStr = config[$"ConnectionStrings:{providerName}"];
        var connStr = config.GetConnectionString(providerName);
        if (connStr == null)
        {
            throw new Exception($"Connectionstring for '{providerName}' not found.");
        }
        return (providerEnum, connStr);
    }
    throw new Exception("Invalid data provider value supplied.");
}