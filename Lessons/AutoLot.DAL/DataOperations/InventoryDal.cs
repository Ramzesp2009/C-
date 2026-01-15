using AutoLot.DAL.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AutoLot.DAL.DataOperations;

public class InventoryDal : IDisposable
{
    private readonly string _connectionString;
    public InventoryDal() : this(
        "Server=localhost\\SQLEXPRESS;Database=AutoLot50;Trusted_Connection=True;TrustServerCertificate=True;")
    { }
    public InventoryDal(string connectionString)
    {
        _connectionString = connectionString;
    }

    private SqlConnection _sqlConnection = null;
    private void OpenConnection()
    {
        _sqlConnection = new SqlConnection
        {
            ConnectionString = _connectionString
        };
        _sqlConnection.Open();
    }
    private void CloseConnection()
    {
        if (_sqlConnection?.State != ConnectionState.Closed)
        {
            _sqlConnection?.Close();
        }
    }
    bool _disposed = false;
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }
        if (disposing)
        {
            _sqlConnection.Dispose();
        }
        _disposed = true;
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public List<CarViewModel> GetAllInventory()
    {
        OpenConnection();
        List<CarViewModel> inventory = new List<CarViewModel>();

        string sql = @"select i.Id, i.Color, i.PetName, m.Name as Make from Inventory i inner join Makes m on i.MakeId = m.Id";
        using SqlCommand command = new SqlCommand(sql, _sqlConnection)
        {
            CommandType = CommandType.Text
        };
        command.CommandType = CommandType.Text;
        SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (dataReader.Read())
        {
            inventory.Add(new CarViewModel
            {
                Id = (int)dataReader["Id"],
                Make = (string)dataReader["Make"],
                Color = (string)dataReader["Color"],
                PetName = (string)dataReader["PetName"]
            });
        }
        dataReader.Close();
        return inventory;
    }
    public void InsertAuto(string color, int makeId, string petName)
    {
        OpenConnection();
        string sql = $"insert into Inventory (Color, MakeId, PetName) values (@Color, @MakeId, @PetName)";
        using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
        {
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        };
        CloseConnection();
    }

    public void InserAuto(Car car)
    {
        OpenConnection();
        string sql = "Insert Into Inventory (MakeId, Color, PetName) Values (@MakeId, @Color, @PetName)";

        using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
        {
            command.CommandType = CommandType.Text;
            //command.Parameters.Add(new SqlParameter("@MakeId", car.MakeId));
            //command.Parameters.Add(new SqlParameter("@Color", car.Color));
            //command.Parameters.Add(new SqlParameter("@PetName", car.PetName));
            command.ExecuteNonQuery();
        };
        CloseConnection();
    }

    public void DeleteCar(int id)
    {
        OpenConnection();
        string sql = $"Delete from Inventory where Id = '{id}'";
        using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
        {
            try
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Exception error = new Exception("Sorry! That car is on order!", ex);
                throw error;
            }
        }
        CloseConnection();
    }

    public void UpdateCarPetName(int id, string newPetName)
    {
        OpenConnection();
        string sql = $"Update Inventory Set PetName = '{newPetName}' Where Id = '{id}'";
        using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
        {
            command.ExecuteNonQuery();
        }
        CloseConnection();
    }
}
