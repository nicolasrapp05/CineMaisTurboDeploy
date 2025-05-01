using CineTurbo.Models;
using Microsoft.EntityFrameworkCore;

namespace CineTurbo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Filme> CineTurboDB { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Filme>().HasData(
                new Filme
                {
                    Id = 1,
                    Nome = "Matrix",
                    Sinopse = "Um hacker descobre a verdade sobre sua realidade.",
                    AvaliacaoImdb = 87,
                    AvaliacaoTomates = 88,
                    Foto = "https://www.themoviedb.org/t/p/w1280/9e3Dz7aCANy5aRUQF745IlNloJ1.jpg",
                    Genero = "Ficção Científica",
                    Avaliacao = 5,
                    Duracao = "2h 16min",
                    Lancamento = new DateTime(1999, 3, 31)
                },
                new Filme
                {
                    Id = 2,
                    Nome = "Matrix",
                    Sinopse = "Um hacker descobre a verdade sobre sua realidade.",
                    AvaliacaoImdb = 87,
                    AvaliacaoTomates = 88,
                    Foto = "https://www.themoviedb.org/t/p/w1280/9e3Dz7aCANy5aRUQF745IlNloJ1.jpg",
                    Genero = "Ficção Científica",
                    Avaliacao = 5,
                    Duracao = "2h 16min",
                    Lancamento = new DateTime(1999, 3, 31)
                },
                new Filme
                {
                    Id = 3,
                    Nome = "Matrix",
                    Sinopse = "Um hacker descobre a verdade sobre sua realidade.",
                    AvaliacaoImdb = 87,
                    AvaliacaoTomates = 88,
                    Foto = "https://www.themoviedb.org/t/p/w1280/9e3Dz7aCANy5aRUQF745IlNloJ1.jpg",
                    Genero = "Ficção Científica",
                    Avaliacao = 5,
                    Duracao = "2h 16min",
                    Lancamento = new DateTime(1999, 3, 31)
                },
                new Filme
                {
                    Id = 4,
                    Nome = "O Senhor dos Anéis: A Sociedade do Anel",
                    Sinopse = "Um hobbit embarca em uma jornada épica para destruir um anel maligno.",
                    AvaliacaoImdb = 88,
                    AvaliacaoTomates = 91,
                    Foto = "https://www.themoviedb.org/t/p/w1280/9e3Dz7aCANy5aRUQF745IlNloJ1.jpg",
                    Genero = "Fantasia",
                    Avaliacao = 5,
                    Duracao = "2h 58min",
                    Lancamento = new DateTime(2001, 12, 19)
                }
            );
        }
    }
}
