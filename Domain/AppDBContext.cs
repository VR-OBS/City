using City.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace City.Domain
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<TypeCard> TypesCard { get; set; }
    }
}
