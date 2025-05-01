using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CineTurbo.Data;
using CineTurbo.Models; // Necessário para acessar o modelo Filme

namespace CineTurbo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public FilmesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // GET: api/filmes
        [HttpGet]
        public ActionResult<IEnumerable<Filme>> GetTodosFilmes()
        {
            var filmes = _appDbContext.CineTurboDB.ToList();
            return Ok(filmes);
        }
    }
}
