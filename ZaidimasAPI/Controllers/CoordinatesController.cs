using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZaidimasAPI.Models;

namespace ZaidimasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinatesController : ControllerBase
    {

        private readonly PlayerContext _context;

        public CoordinatesController(PlayerContext context)
        {
            _context = context;

            if (_context.Coordinates.Count() == 0)
            {
                // Create a new Player if collection is empty,
                // which means you can't delete all Players.
                for (int i = 0; i < 10; i++)
                {

                    Coordinate p = new Coordinate { PlayerId = 0, CoordinateX = 0, CoordinateY = 0 };
                    _context.Coordinates.Add(p);
                }

                _context.SaveChanges();
            }
        }

       // GET: api/Coordinates
       //[HttpGet]
       // public IEnumerable<string> Get()
       // {
       //     return new string[] { "value1", "value2" };
       // }

        // GET: api/Coordinates/5
        [HttpGet("{PlayerId}")]
        public async Task<ActionResult<Coordinate>> GetByPlayer(long PlayerId)
        {
            var coordinates = _context.Coordinates.FirstOrDefault(c => c.PlayerId == PlayerId);
            if (coordinates == null)
            {
                return NotFound();
            }

            return coordinates;
        }

        // POST: api/Coordinates
        [HttpPost]
        public async Task<ActionResult<Coordinate>> PostCoordinate( Coordinate value)
        {
            _context.Coordinates.Add(value);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetByPlayer", new { PlayerId = value.PlayerId }, value);
        }

        // PUT: api/Coordinates/5
        [HttpPut("{PlayerId}")]
        public async Task<IActionResult> Put(long PlayerId, [FromBody] Coordinate value)
        {
            Coordinate coo;
            try
            {
                 coo = _context.Coordinates.FirstOrDefault(c => c.PlayerId == PlayerId);
                if (coo == null)
                {
                    return BadRequest();
                }

                if (value.CoordinateX !=0 )
                {
                    coo.CoordinateX = value.CoordinateX;

                }
                else
                {
                    coo.CoordinateY = value.CoordinateY;

                }

            }
            catch (Exception ex)
            {

                throw;
            }

            //Coordinate coo = _context.Coordinates.SingleOrDefault(c =>c.PlayerId == PlayerId);
         

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!CoordinateExists(PlayerId))
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

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Coordinate>> Delete(int id)
        {
            var coordinate = await _context.Coordinates.FindAsync(id);
            if (coordinate == null)
            {
                return NotFound();
            }

            _context.Coordinates.Remove(coordinate);
            await _context.SaveChangesAsync();

            return coordinate;
        }

        private bool CoordinateExists(long id)
        {
            return _context.Coordinates.Any(e => e.PlayerId == id);
        }
    }
}
