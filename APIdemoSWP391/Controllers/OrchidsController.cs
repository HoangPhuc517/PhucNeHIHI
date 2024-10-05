using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrchidBusinessObjects;
using OrchidDAOs;
using OrchidVervices;

namespace APIdemoSWP391.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrchidsController : ControllerBase
    {
        private readonly IOrchidService iOrchidService;

        public OrchidsController()
        {
            iOrchidService = new OrchidService();
        }

        // GET: api/Orchids
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Orchid>>> GetOrchids()
        {
            if (iOrchidService.GetOrchids() == null)
            {
                return NotFound();
            }
            return iOrchidService.GetOrchids().ToList();
        }

        // GET: api/Orchids/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Orchid>> GetOrchid(int id)
        {
            if (iOrchidService.GetOrchids() == null)
            {
                return NotFound();
            }

            var orchid = iOrchidService.GetOrchid(id);

            if (orchid == null)
            {
                return NotFound();
            }

            return orchid;
        }

        // PUT: api/Orchids/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrchid(int id, Orchid orchid)
        {
            if (id != orchid.OrchidId)
            {
                return BadRequest();
            }

            iOrchidService.UpdateOrchid(id, orchid);

            return NoContent();
        }

        // POST: api/Orchids
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Orchid>> PostOrchid(Orchid orchid)
        {
            if (iOrchidService.GetOrchids() == null)
            {
                return NotFound();
            }
            iOrchidService.AddOrchid(orchid);
            return CreatedAtAction("GetOrchid", new { id = orchid.OrchidId }, orchid);
        }

        // DELETE: api/Orchids/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrchid(int id)
        {
            if (iOrchidService.GetOrchids() == null)
            {
                return NotFound();
            }
            iOrchidService.DeleteOrchid(id);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Hello(string model)
        {
            if (model == null)
            {
                return BadRequest("Ngu Vãi Lồn!!!");
            }
            return Ok(model);
        }
    }
}
