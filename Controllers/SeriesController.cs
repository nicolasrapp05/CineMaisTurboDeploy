using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CineTurbo.Data;
using CineTurbo.Models;
using CineMaisTurbo.Models; // Necessário para acessar o modelo Serie

namespace CineTurbo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeriesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public SeriesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddSerie([FromBody] Serie serie)
        {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            _appDbContext.SeriesDB.Add(serie);
            await _appDbContext.SaveChangesAsync();

            return Created("Serie criado com sucesso!", serie);
        }

        // GET: api/series
        // [HttpGet]
        // public ActionResult<IEnumerable<Serie>> GetTodosSeries()
        // {
        //     var series = _appDbContext.SeriesDB.ToList();
        //     return Ok(series);
        // }

        [HttpGet]
        public ActionResult<IEnumerable<Filme>> GetSeries([FromQuery] string? genero)
        {
            var query = _appDbContext.SeriesDB.AsQueryable();

            if (!string.IsNullOrWhiteSpace(genero))
            {
                query = query.Where(s => s.Genero.Trim().ToLower() == genero.Trim().ToLower());


            }

            return Ok(query.ToList());
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Serie>> GetSerie(int id)
        {
            var serie = await _appDbContext.SeriesDB.FindAsync(id);

            if (serie == null) {
                return NotFound("Serie não encontrado!");
            }

            return Ok(serie);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSerie(int id, [FromBody] Serie serieAtualizada)
        {
            var serieExistente = await _appDbContext.SeriesDB.FindAsync(id);

            if (serieExistente == null) {
                return NotFound("Serie não encontrado!");
            }

            serieExistente.Nome = serieAtualizada.Nome;
            serieExistente.Sinopse = serieAtualizada.Sinopse;
            serieExistente.Foto = serieAtualizada.Foto;
            serieExistente.Genero = serieAtualizada.Genero;
            serieExistente.Avaliacao = serieAtualizada.Avaliacao;
            serieExistente.AvaliacaoImdb = serieAtualizada.AvaliacaoImdb;
            serieExistente.AvaliacaoTomates = serieAtualizada.AvaliacaoTomates;
            serieExistente.Episodios = serieAtualizada.Episodios;
            serieExistente.Temporadas = serieAtualizada.Temporadas;
            serieExistente.Lancamento = serieAtualizada.Lancamento;

            await _appDbContext.SaveChangesAsync();

            return StatusCode(201, serieAtualizada);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSerie(int id)
        {
            var serie = await _appDbContext.SeriesDB.FindAsync(id);

            if (serie == null) {
                return NotFound("Serie não encontrado!");
            }

            _appDbContext.Remove(serie);

            await _appDbContext.SaveChangesAsync();

            return Ok("Serie deletado");
        }
    }
}
