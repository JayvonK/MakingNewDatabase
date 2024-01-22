using MakingNewDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace MakingNewDatabase.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Shapes> Shapes { get; set; }
    }
