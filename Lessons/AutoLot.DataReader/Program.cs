using System;
using Microsoft.Data.SqlClient;

Console.WriteLine("***** Fun with Data Readers *****\n");


using (SqlConnection connection = new SqlConnection())
{
    var connectionStringBuilder = new SqlConnectionStringBuilder
    {
        DataSource = @"localhost\SQLEXPRESS",
        InitialCatalog = "AutoLot50",
        IntegratedSecurity = true,
        TrustServerCertificate = true
    };

    //connection.ConnectionString = "Server=localhost\\SQLEXPRESS;Database=AutoLot50;Trusted_Connection=True;TrustServerCertificate=True;";
    connection.ConnectionString = connectionStringBuilder.ConnectionString;
    connection.Open();

    string sql = @"Select i.id, m.Name as Make, i.Color, i.Petname From Inventory i Inner Join Makes m on m.Id = i.MakeId";

    sql += ";Select * from Customers;";

    SqlCommand myCommand = new SqlCommand(sql, connection);

    using (SqlDataReader myDataReader = myCommand.ExecuteReader())

    {
        //while (myDataReader.Read())
        //{
        //    //Console.WriteLine($"-> Make: {myDataReader["Make"]}," +
        //    //    $"PetName: {myDataReader["PetName"]}, Color: {myDataReader["Color"]}.");
        //    for (int i = 0; i < myDataReader.FieldCount; i++)
        //    {
        //        Console.Write(i != myDataReader.FieldCount - 1
        //            ? $"{myDataReader.GetName(i)}: {myDataReader.GetValue(i)}, " :  $"{myDataReader.GetName(i)}: {myDataReader.GetValue(i)} ");
        //    }
        //    Console.WriteLine();
        //}
        do
        {
            while (myDataReader.Read())
            {
                for (int i = 0; i < myDataReader.FieldCount; i++)
                {
                    Console.Write(i != myDataReader.FieldCount - 1 
                        ? $"{myDataReader.GetName(i)} = {myDataReader.GetValue(i)}, " : $"{myDataReader.GetName(i)} = {myDataReader.GetValue(i)} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        } while (myDataReader.NextResult());
    }
    ShowConnectionStatus(connection);
}


static void ShowConnectionStatus(SqlConnection connection)
{
    Console.WriteLine("\n***** Connection Info *****");
    Console.WriteLine($@"Database location: {connection.DataSource}");
    Console.WriteLine($"Connection String: {connection.ConnectionString}");
    Console.WriteLine($"Database: {connection.Database}");
    Console.WriteLine($"State: {connection.State}");
    Console.WriteLine($@"Connection Timeout: {connection.ConnectionTimeout}");

}
