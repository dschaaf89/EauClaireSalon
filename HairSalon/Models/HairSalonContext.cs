using Microsoft.EntityFrameworkCore;
namespace HairSalon.Models
{
    public class HairSalonContext : DbContext
    {
    public virtual DbSet<Client> Clients { get; set; }
    public DbSet<Stylist> Stylists { get; set; }
   
    public HairSalonContext(DbContextOptions options) : base(options) { }
    }
}