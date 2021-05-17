using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoDiceRoller.Models;

namespace AutoDiceRoller.Controllers
{
    [Route("api/OcrResults")]
    [ApiController]
    public class OcrResultsApiController : ControllerBase
    {
        private readonly DiceRollerDBContext _context;

        public OcrResultsApiController(DiceRollerDBContext context)
        {
            _context = context;
        }

        // GET: api/OcrResultsApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OcrResult>>> GetOcrResults()
        {
            return await _context.OcrResults.ToListAsync();
        }

        // GET: api/OcrResultsApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OcrResult>> GetOcrResult(int id)
        {
            var ocrResult = await _context.OcrResults.FindAsync(id);

            if (ocrResult == null)
            {
                return NotFound();
            }

            return ocrResult;
        }

        // PUT: api/OcrResultsApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOcrResult(int id, OcrResult ocrResult)
        {
            if (id != ocrResult.RollId)
            {
                return BadRequest();
            }

            _context.Entry(ocrResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OcrResultExists(id))
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

        // POST: api/OcrResultsApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OcrResult>> PostOcrResult(OcrResult ocrResult)
        {
            _context.OcrResults.Add(ocrResult);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OcrResultExists(ocrResult.RollId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            //return CreatedAtAction("GetOcrResult", new { id = ocrResult.RollId }, ocrResult);
            return CreatedAtAction(nameof(GetOcrResult), new { id = ocrResult.RollId }, ocrResult);
        }

        // DELETE: api/OcrResultsApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOcrResult(int id)
        {
            var ocrResult = await _context.OcrResults.FindAsync(id);
            if (ocrResult == null)
            {
                return NotFound();
            }

            _context.OcrResults.Remove(ocrResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OcrResultExists(int id)
        {
            return _context.OcrResults.Any(e => e.RollId == id);
        }
    }
}
