using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AutoDiceRoller.Models;

namespace AutoDiceRoller.Controllers
{
    public class OcrResultsController : Controller
    {
        private readonly DiceRollerDBContext _context;

        public OcrResultsController(DiceRollerDBContext context)
        {
            _context = context;
        }

        // GET: OcrResults
        public async Task<IActionResult> Index()
        {
            return View(await _context.OcrResults.ToListAsync());
        }

        // GET: OcrResults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocrResult = await _context.OcrResults
                .FirstOrDefaultAsync(m => m.RollId == id);
            if (ocrResult == null)
            {
                return NotFound();
            }

            return View(ocrResult);
        }

        // GET: OcrResults/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OcrResults/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RollId,ConfidenceLvl,FaceValue")] OcrResult ocrResult)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ocrResult);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ocrResult);
        }

        // GET: OcrResults/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocrResult = await _context.OcrResults.FindAsync(id);
            if (ocrResult == null)
            {
                return NotFound();
            }
            return View(ocrResult);
        }

        // POST: OcrResults/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RollId,ConfidenceLvl,FaceValue")] OcrResult ocrResult)
        {
            if (id != ocrResult.RollId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ocrResult);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OcrResultExists(ocrResult.RollId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ocrResult);
        }

        // GET: OcrResults/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocrResult = await _context.OcrResults
                .FirstOrDefaultAsync(m => m.RollId == id);
            if (ocrResult == null)
            {
                return NotFound();
            }

            return View(ocrResult);
        }

        // POST: OcrResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ocrResult = await _context.OcrResults.FindAsync(id);
            _context.OcrResults.Remove(ocrResult);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OcrResultExists(int id)
        {
            return _context.OcrResults.Any(e => e.RollId == id);
        }
    }
}
