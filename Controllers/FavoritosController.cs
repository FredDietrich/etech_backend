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
    public class FavoritosController : ControllerBase
    {
        private readonly DataContext _context;

        public FavoritosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Favoritos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Favorito>>> GetFavoritos()
        {
          if (_context.Favoritos == null)
          {
              return NotFound();
          }
            return await _context.Favoritos.ToListAsync();
        }

        // GET: api/Favoritos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Favorito>> GetFavorito(int id)
        {
          if (_context.Favoritos == null)
          {
              return NotFound();
          }
            var favorito = await _context.Favoritos.FindAsync(id);

            if (favorito == null)
            {
                return NotFound();
            }

            return favorito;
        }

        // PUT: api/Favoritos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavorito(int id, Favorito favorito)
        {
            if (id != favorito.IdFavorito)
            {
                return BadRequest();
            }

            _context.Entry(favorito).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoritoExists(id))
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

        // POST: api/Favoritos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Favorito>> PostFavorito(Favorito favorito)
        {
          if (_context.Favoritos == null)
          {
              return Problem("Entity set 'DataContext.Favoritos'  is null.");
          }
            _context.Favoritos.Add(favorito);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFavorito", new { id = favorito.IdFavorito }, favorito);
        }

        // DELETE: api/Favoritos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavorito(int id)
        {
            if (_context.Favoritos == null)
            {
                return NotFound();
            }
            var favorito = await _context.Favoritos.FindAsync(id);
            if (favorito == null)
            {
                return NotFound();
            }

            _context.Favoritos.Remove(favorito);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FavoritoExists(int id)
        {
            return (_context.Favoritos?.Any(e => e.IdFavorito == id)).GetValueOrDefault();
        }
    }
}
