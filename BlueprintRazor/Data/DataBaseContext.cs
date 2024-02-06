using System;
using Microsoft.EntityFrameworkCore;
using BlueprintRazor.Models;
namespace BlueprintRazor.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movie { get; set; }
    }
}