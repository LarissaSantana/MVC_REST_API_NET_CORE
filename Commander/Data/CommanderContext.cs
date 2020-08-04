using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt) { }
        
        public DbSet<Command> Commands { get; set; }

        //usando fluentAPI
        // protected override void OnModelCreating(ModelBuilder builder)
        // {

        // }
    }
}