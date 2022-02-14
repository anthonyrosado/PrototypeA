#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrototypeA.Data;
using PrototypeA.Models;

using Microsoft.AspNetCore.Mvc;

namespace PrototypeA.Controllers
{
    [Authorize(Roles = "Diver")]
    public class DiveLogsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DiveLogsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DiveLogs

      
        public async Task<IActionResult> Index()
        {
            return View(await _context.DiveLogs.ToListAsync());
        }

        // GET: DiveLogs/Details/5
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diveLog = await _context.DiveLogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diveLog == null)
            {
                return NotFound();
            }

            return View(diveLog);
        }

        // GET: DiveLogs/Create

        
        public IActionResult Create()
        {
            return View();
        }

        // POST: DiveLogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public async Task<IActionResult> Create([Bind("Id,DateTime,Location,Si,StartPg,AirIn,Depth,Time,visibility,AirOut,Weight,EndPg")] DiveLog diveLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diveLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diveLog);
        }

        // GET: DiveLogs/Edit/5
      
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diveLog = await _context.DiveLogs.FindAsync(id);
            if (diveLog == null)
            {
                return NotFound();
            }
            return View(diveLog);
        }

        // POST: DiveLogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateTime,Location,Si,StartPg,AirIn,Depth,Time,visibility,AirOut,Weight,EndPg")] DiveLog diveLog)
        {
            if (id != diveLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diveLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiveLogExists(diveLog.Id))
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
            return View(diveLog);
        }

        // GET: DiveLogs/Delete/5
       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diveLog = await _context.DiveLogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diveLog == null)
            {
                return NotFound();
            }

            return View(diveLog);
        }

        // POST: DiveLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diveLog = await _context.DiveLogs.FindAsync(id);
            _context.DiveLogs.Remove(diveLog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiveLogExists(int id)
        {
            return _context.DiveLogs.Any(e => e.Id == id);
        }
    }
}
