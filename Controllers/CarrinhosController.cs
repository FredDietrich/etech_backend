using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Etech.Entidades;
using Etech.Auth;

namespace etech_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CarrinhosController : ControllerBase
    {
        private readonly DataContext _context;

        public CarrinhosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Carrinhos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Carrinho>>> GetCarrinhos()
        {
          if (_context.Carrinhos == null)
          {
              return NotFound();
          }
            return await _context.Carrinhos.ToListAsync();
        }

        // GET: api/Carrinhos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Carrinho>> GetCarrinho(int id)
        {
          if (_context.Carrinhos == null)
          {
              return NotFound();
          }
            var carrinho = await _context.Carrinhos.FindAsync(id);

            if (carrinho == null)
            {
                return NotFound();
            }

            return carrinho;
        }

        // PUT: api/Carrinhos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarrinho(int id, Carrinho carrinho)
        {
            if (id != carrinho.IdCarrinho)
            {
                return BadRequest();
            }

            _context.Entry(carrinho).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarrinhoExists(id))
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

        // POST: api/Carrinhos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Carrinho>> PostCarrinho(Carrinho carrinho)
        {
          if (_context.Carrinhos == null)
          {
              return Problem("Entity set 'DataContext.Carrinhos'  is null.");
          }
            _context.Carrinhos.Add(carrinho);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarrinho", new { id = carrinho.IdCarrinho }, carrinho);
        }

        // DELETE: api/Carrinhos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarrinho(int id)
        {
            if (_context.Carrinhos == null)
            {
                return NotFound();
            }
            var carrinho = await _context.Carrinhos.FindAsync(id);
            if (carrinho == null)
            {
                return NotFound();
            }

            _context.Carrinhos.Remove(carrinho);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarrinhoExists(int id)
        {
            return (_context.Carrinhos?.Any(e => e.IdCarrinho == id)).GetValueOrDefault();
        }
    }
}
