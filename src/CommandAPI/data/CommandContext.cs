using CommandAPI.models;
using Microsoft.EntityFrameworkCore;

namespace CommandAPI.data
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options) : base(options)
        {
        }
        public DbSet<Command> CommandItems { get; set; }
    }
}
