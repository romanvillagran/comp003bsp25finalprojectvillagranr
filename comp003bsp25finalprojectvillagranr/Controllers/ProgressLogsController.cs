using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using comp003bsp25finalprojectvillagranr.Models;
using comp003bsp25finalprojectvillagranr.Data;

namespace comp003bsp25finalprojectvillagranr.Controllers
{
    public class ProgressLogsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProgressLogsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProgressLogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProgressLogs.ToListAsync());
        }

        // GET: ProgressLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var progressLog = await _context.ProgressLogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (progressLog == null)
            {
                return NotFound();
            }

            return View(progressLog);
        }

        // GET: ProgressLogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProgressLogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LogDate,Weight")] ProgressLog progressLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(progressLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(progressLog);
        }

        // GET: ProgressLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var progressLog = await _context.ProgressLogs.FindAsync(id);
            if (progressLog == null)
            {
                return NotFound();
            }
            return View(progressLog);
        }

        // POST: ProgressLogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LogDate,Weight")] ProgressLog progressLog)
        {
            if (id != progressLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(progressLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgressLogExists(progressLog.Id))
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
            return View(progressLog);
        }

        // GET: ProgressLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var progressLog = await _context.ProgressLogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (progressLog == null)
            {
                return NotFound();
            }

            return View(progressLog);
        }

        // POST: ProgressLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var progressLog = await _context.ProgressLogs.FindAsync(id);
            if (progressLog != null)
            {
                _context.ProgressLogs.Remove(progressLog);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgressLogExists(int id)
        {
            return _context.ProgressLogs.Any(e => e.Id == id);
        }
    }
}
