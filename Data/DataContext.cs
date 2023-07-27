using cSharpAcademy_Shifts_Logger.Models;
using Microsoft.EntityFrameworkCore;

namespace cSharpAcademy_Shifts_Logger.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}
