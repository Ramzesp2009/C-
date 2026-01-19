using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoLot.Samples;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        var connectionString = "Server=localhost\\SQLEXPRESS;Database=AutoLot50;Trusted_Connection=True;TrustServerCertificate=True;";
        optionsBuilder.UseSqlServer(connectionString);
        Console.WriteLine(connectionString);
        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
