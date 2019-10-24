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

            //builder.Entity<Passanger>().HasData(
            //    new Passanger { Id = 100, Nome = "João da Silva", IdPassangerToAirplane = 100 },
            //    new Passanger { Id = 110, Nome = "Maria da Glória", IdPassangerToAirplane = 100},
            //    new Passanger { Id = 120, Nome = "Paulo José da Silva", IdPassangerToAirplane = 100 },
            //    new Passanger { Id = 130, Nome = "Ana Maria Fernandes", IdPassangerToAirplane = 100 },
            //    new Passanger { Id = 140, Nome = "Carlos João das couves", IdPassangerToAirplane = 100 },
            //    new Passanger { Id = 150, Nome = "Marina da Glória", IdPassangerToAirplane = 100 },

            //    new Passanger { Id = 200, Nome = "Joaqui da Silva", IdPassangerToAirplane = 200 },
            //    new Passanger { Id = 210, Nome = "Betania Maria Luiza da Glória", IdPassangerToAirplane = 200 },
            //    new Passanger { Id = 220, Nome = "Manoel da Silva", IdPassangerToAirplane = 200 },
            //    new Passanger { Id = 230, Nome = "Fernanda da Glória", IdPassangerToAirplane = 200 }
            //    );

            builder.Entity<Passanger>().HasData(
                new Passanger { Id = 100, Nome = "João da Silva"},
                new Passanger { Id = 110, Nome = "Maria da Glória"},
                new Passanger { Id = 120, Nome = "Paulo José da Silva"},
                new Passanger { Id = 130, Nome = "Ana Maria Fernandes"},
                new Passanger { Id = 140, Nome = "Carlos João das couves"},
                new Passanger { Id = 150, Nome = "Marina da Glória"},

                new Passanger { Id = 200, Nome = "Joaqui da Silva"},
                new Passanger { Id = 210, Nome = "Betania Maria Luiza da Glória"},
                new Passanger { Id = 220, Nome = "Manoel da Silva"},
                new Passanger { Id = 230, Nome = "Fernanda da Glória"}
                );
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

            builder.Entity<PassangerToAirplane>().HasData(
                    new PassangerToAirplane { Id = 100, IdAirplane = 100, IdPassanger = 100},
                    new PassangerToAirplane { Id = 200, IdAirplane = 100, IdPassanger = 110 },
                    new PassangerToAirplane { Id = 300, IdAirplane = 100, IdPassanger = 120 },
                    new PassangerToAirplane { Id = 400, IdAirplane = 100, IdPassanger = 130 },
                    new PassangerToAirplane { Id = 500, IdAirplane = 100, IdPassanger = 140 },
                    new PassangerToAirplane { Id = 600, IdAirplane = 100, IdPassanger = 150 },

                    new PassangerToAirplane { Id = 700, IdAirplane = 200, IdPassanger = 100 },
                    new PassangerToAirplane { Id = 800, IdAirplane = 200, IdPassanger = 110 },
                    new PassangerToAirplane { Id = 900, IdAirplane = 300, IdPassanger = 120 },
                    new PassangerToAirplane { Id = 1000, IdAirplane = 400, IdPassanger = 130 }
                    );

            #endregion
        }
    }
}
