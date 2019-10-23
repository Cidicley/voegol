using Microsoft.EntityFrameworkCore;
using TestePratico.API.domain.Models;

namespace TestePratico.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Passanger> Passangers { get; set; }
        public DbSet<PassangerToAirplane> PassangersToAirplane { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Categoria
            builder.Entity<Categoria>().ToTable("Categorias");
            builder.Entity<Categoria>().HasKey(p => p.Id);
            builder.Entity<Categoria>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Categoria>().Property(p => p.Nome).IsRequired().HasMaxLength(30);
            builder.Entity<Categoria>().HasMany(p => p.Produtos).WithOne(p => p.Categoria).HasForeignKey(p => p.CategoriaId);

            builder.Entity<Categoria>().HasData(
                new Categoria { Id = 100, Nome = "Frutas" },
                new Categoria { Id = 200, Nome = "Laticínios" }
                ); 
            #endregion

            #region Produto
            builder.Entity<Produto>().ToTable("Produtos");
            builder.Entity<Produto>().HasKey(p => p.Id);
            builder.Entity<Produto>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Produto>().Property(p => p.Nome).IsRequired().HasMaxLength(50);
            builder.Entity<Produto>().Property(p => p.QuantidadePacote).IsRequired(); 
            #endregion

            #region Passanger
            builder.Entity<Passanger>().ToTable("Passangers");
            builder.Entity<Passanger>().HasKey(p => p.Id);
            builder.Entity<Passanger>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Passanger>().Property(p => p.Nome).IsRequired().HasMaxLength(50); 
            #endregion

            #region Airplane
            builder.Entity<Airplane>().ToTable("Airplanes");
            builder.Entity<Airplane>().HasKey(p => p.Id);
            builder.Entity<Airplane>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Airplane>().Property(p => p.Nome).IsRequired().HasMaxLength(50);

            builder.Entity<Airplane>().HasData(
                new Airplane { Id = 100, Nome = "Boeing 737-700" },
                new Airplane { Id = 200, Nome = "Boeing 737-800" },
                new Airplane { Id = 300, Nome = "Boeing 737 MAX 8" },
                new Airplane { Id = 400, Nome = "Boeing 737 MAX 10" }
                ); 
            #endregion

            #region PassangersToAirplane
            builder.Entity<PassangerToAirplane>().ToTable("PassangersToAirplane");
            builder.Entity<PassangerToAirplane>().HasKey(p => p.Id);
            builder.Entity<PassangerToAirplane>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<PassangerToAirplane>().Property(p => p.IdAirplane).IsRequired();
            builder.Entity<PassangerToAirplane>().Property(p => p.IdAirplane).IsRequired();
            builder.Entity<PassangerToAirplane>().HasMany(p => p.Airplanes).WithOne(p => p.PassangerToAirplane).HasForeignKey(p => p.IdPassangerToAirplane);
            builder.Entity<PassangerToAirplane>().HasMany(p => p.Passangers).WithOne(p => p.PassangerToAirplane).HasForeignKey(p => p.IdPassangerToAirplane);

            #endregion
        }
    }
}
