using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CineTurbo.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FilmesDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sinopse = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AvaliacaoImdb = table.Column<int>(type: "int", nullable: false),
                    AvaliacaoTomates = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Genero = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Avaliacao = table.Column<int>(type: "int", nullable: false),
                    Duracao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Lancamento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmesDB", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SeriesDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sinopse = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AvaliacaoImdb = table.Column<int>(type: "int", nullable: false),
                    AvaliacaoTomates = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Genero = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Avaliacao = table.Column<int>(type: "int", nullable: false),
                    Temporadas = table.Column<int>(type: "int", nullable: false),
                    Episodios = table.Column<int>(type: "int", nullable: false),
                    Lancamento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesDB", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "FilmesDB",
                columns: new[] { "Id", "Avaliacao", "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[,]
                {
                    { 1, 5, 87, 88, "2h 16min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/1aadn0aD7h1VKq4yap2uKl7cTSL.jpg", "Ficção Científica", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matrix", "Um hacker descobre a verdade sobre sua realidade." },
                    { 2, 5, 87, 88, "2h 16min", "https://www.themoviedb.org/t/p/w1280/9e3Dz7aCANy5aRUQF745IlNloJ1.jpg", "Ficção Científica", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matrix", "Um hacker descobre a verdade sobre sua realidade." },
                    { 3, 5, 87, 88, "2h 16min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/4lj1ikfsSmMZNyfdi8R8Tv5tsgb.jpg", "Ficção Científica", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matrix", "Um hacker descobre a verdade sobre sua realidade." },
                    { 4, 5, 88, 91, "2h 58min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/qVf6lTFzDsBZUbYbk8m9dk9SipX.jpg", "Fantasia", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Senhor dos Anéis: A Sociedade do Anel", "Um hobbit embarca em uma jornada épica para destruir um anel maligno." },
                    { 5, 5, 88, 91, "2h 58min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/x5hsAHiwLQrM7jlSZzR7AdWZquk.jpg", "Fantasia", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Senhor dos Anéis: A Sociedade do Anel", "Um hobbit embarca em uma jornada épica para destruir um anel maligno." },
                    { 6, 5, 88, 91, "2h 58min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/TpcNor0WkmD1SBO3n3tlkQqmOf.jpg", "Fantasia", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Senhor dos Anéis: A Sociedade do Anel", "Um hobbit embarca em uma jornada épica para destruir um anel maligno." },
                    { 7, 5, 88, 91, "2h 58min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/wd9fppMrD3KbH8jAMTqCF28QejD.jpg", "Fantasia", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Senhor dos Anéis: A Sociedade do Anel", "Um hobbit embarca em uma jornada épica para destruir um anel maligno." },
                    { 8, 5, 88, 91, "2h 58min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/9e0Yftt4svEI268iogQQdMXvng6.jpg", "Fantasia", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Senhor dos Anéis: A Sociedade do Anel", "Um hobbit embarca em uma jornada épica para destruir um anel maligno." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmesDB");

            migrationBuilder.DropTable(
                name: "SeriesDB");
        }
    }
}
