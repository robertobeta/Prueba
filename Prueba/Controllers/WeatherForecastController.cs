using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Prueba.Models;
using System.Reflection.Metadata.Ecma335;

namespace Prueba.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiPrueba : ControllerBase
    {
        private readonly VueDbContext _context;
        public class Mensaje
        {
            public string? Texto { get; set; }
        }
        public ApiPrueba(VueDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mensaje>>> GetFormulario() =>
            Ok(new Mensaje { 
                Texto = "Hola esto es una prueba"
             });
    }
}
