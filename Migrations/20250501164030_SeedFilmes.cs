using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CineTurbo.Migrations
{
    /// <inheritdoc />
    public partial class SeedFilmes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CineTurboDB",
                columns: new[] { "Id", "Avaliacao", "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[,]
                {
                    { 1, 5, 87, 88, "2h 16min", "matrix.jpg", "Ficção Científica", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matrix", "Um hacker descobre a verdade sobre sua realidade." },
                    { 2, 5, 88, 91, "2h 58min", "sociedade-do-anel.jpg", "Fantasia", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Senhor dos Anéis: A Sociedade do Anel", "Um hobbit embarca em uma jornada épica para destruir um anel maligno." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CineTurboDB",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CineTurboDB",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
