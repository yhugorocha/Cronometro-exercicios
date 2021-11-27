using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Exercicio.API.Data;
using CronometroExercicios.API.Model;


namespace Exercicio.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExercicioController : ControllerBase
    {
        public readonly DataContext _context;

        public ExercicioController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Atividade>Get()
        {
            return _context.Exercicios;
    }
}
}
