using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebCoreDensidade.Model;

namespace WebCoreDensidade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetoesController : ControllerBase
    {
        private readonly ObjetoContext _context;

        public ObjetoesController(ObjetoContext context)
        {
            _context = context;
        }

        // GET: api/Objetoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Objeto>>> Getobjetos()
        {
            return await _context.objetos.ToListAsync();
        }

        // GET: api/Objetoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Objeto>> GetObjeto(int id)
        {
            var objeto = await _context.objetos.FindAsync(id);

            if (objeto == null)
            {
                return NotFound();
            }

            return objeto;
        }

        // PUT: api/Objetoes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObjeto(int id, Objeto objeto)
        {
            if (id != objeto.Id)
            {
                return BadRequest();
            }

            _context.Entry(objeto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObjetoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Objetoes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Objeto>> PostObjeto(Objeto objeto)
        {
            objeto.Massa = objeto.Volume * objeto.Densidade;
            objeto.Peso = objeto.Massa * objeto.Padrao;


            _context.objetos.Add(objeto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetObjeto), new { id = objeto.Id }, objeto);
        }

        // DELETE: api/Objetoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Objeto>> DeleteObjeto(int id)
        {
            var objeto = await _context.objetos.FindAsync(id);
            if (objeto == null)
            {
                return NotFound();
            }

            _context.objetos.Remove(objeto);
            await _context.SaveChangesAsync();

            return objeto;
        }

        private bool ObjetoExists(int id)
        {
            return _context.objetos.Any(e => e.Id == id);
        }
    }
}
