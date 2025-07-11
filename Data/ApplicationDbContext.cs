using Microsoft.EntityFrameworkCore;
using Notes.Model;

namespace Notes.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {     
        public DbSet<Note> Notes { get; set; }
    }
}
