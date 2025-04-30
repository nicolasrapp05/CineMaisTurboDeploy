using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CineTurbo.Data;

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
    }
}