using System.Reflection;
using Domine.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data;
    public class RayoMcQueenDbContext : DbContext
    {
        public RayoMcQueenDbContext(DbContextOptions<RayoMcQueenDbContext> options): base(options){

        }
        public DbSet<Country> Countries{ get; set; }
        public DbSet<PayRollType> PayRollTypes{ get; set; }
        public DbSet<Team> Teams{ get; set; }
        public DbSet<Person> People{ get; set; }
        public DbSet<Player> Players{ get; set; }
        public DbSet<PlayerPosition> PlayerPositions{ get; set; }
        public DbSet<Position> Positions{ get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //assembly está en código binario. contiene uno o más módulos o componentes de código compilado
        }
    }


