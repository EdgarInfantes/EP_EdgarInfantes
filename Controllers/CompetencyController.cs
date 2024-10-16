using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial.Data;

namespace Parcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetencyController : ControllerBase
    {
        private readonly Parcial20240221100749Context _context;

        public CompetencyController(Parcial20240221100749Context context)
        {
            _context = context;
        }

        //Listar todas las competencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Competency>>> GetCompetency()
        {
            return await _context.Competency.ToListAsync();
        }

        // Registrar una competencia
        [HttpPost]
        public async Task<ActionResult<Competency>> PostCompetency(Competency competency)
        {
            _context.Competency.Add(competency);
            await _context.SaveChangesAsync();
            if (competency == null) return NotFound();
            return Ok();
        }
        // Actualizar una competencia
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompetency(int id, Competency competency)
        {
            //if (id != competency.Id) return BadRequest();
            if (id != competency.Id) return BadRequest();
            _context.Competency.Update(competency);
            await _context.SaveChangesAsync();
            return Ok();
        }

        // Eliminar una competencia
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompetency(int id)
        {
            var competency = await _context.Competency.FindAsync(id);
            if (competency == null) return NotFound();
            _context.Competency.Remove(competency);
            await _context.SaveChangesAsync();
            return Ok();

        }

    }
}
