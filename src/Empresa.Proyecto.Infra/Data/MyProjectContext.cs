using Microsoft.EntityFrameworkCore;
using Empresa.Proyecto.Core.Entities;


namespace Empresa.Proyecto.Infra.Data
{
    public class MyProjectContext : DbContext
    {
        /// <summary>
        /// Constructor para DI
        /// </summary>
        /// <param name="options"></param>
        public MyProjectContext(DbContextOptions<MyProjectContext> options) : base(options)
        {
            Seed();
        }

        public DbSet<SimpleEntity> SimpleEntity => Set<SimpleEntity>();
        public DbSet<ComplexEntity> ComplexEntity => Set<ComplexEntity>();

        protected override void OnModelCreating(ModelBuilder builder)
        {           
            builder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
        }

        public void Seed()
        {
            if (SimpleEntity.Any())
            {
                return; // Already seeded
            }

            SimpleEntity.AddRange(
                new SimpleEntity { Name = "Nuevo", Value = "Valor nuevo" },
                new SimpleEntity { Name = "Existente", Value = "Valor existente" },
                new SimpleEntity { Name = "Reconstruido", Value = "Valor reconstruido" }
            );

            SaveChanges();
        }
    }
}
