using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using AutoLot.Samples.Models;

namespace AutoLot.Samples;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Make> Makes { get; set; }
    public DbSet<Radio> Radios { get; set; }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<BaseEntity>().ToTable("BaseEntityes");
        //modelBuilder.Entity<Car>().ToTable("Cars");
        //OnModelCreatingPartial(modelBuilder);
    }
}

