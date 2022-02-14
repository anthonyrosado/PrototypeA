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

namespace PrototypeA.Controllers
{
    [Authorize(Roles="Diver")]
    public class DiversController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DiversController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Divers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Divers.ToListAsync());
        }

        // GET: Divers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diver = await _context.Divers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diver == null)
            {
                return NotFound();
            }

            return View(diver);
        }

        // GET: Divers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Divers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,email")] Diver diver)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diver);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diver);
        }

        // GET: Divers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diver = await _context.Divers.FindAsync(id);
            if (diver == null)
            {
                return NotFound();
            }
            return View(diver);
        }

        // POST: Divers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,email")] Diver diver)
        {
            if (id != diver.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diver);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiverExists(diver.Id))
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
            return View(diver);
        }

        // GET: Divers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diver = await _context.Divers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diver == null)
            {
                return NotFound();
            }

            return View(diver);
        }

        // POST: Divers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diver = await _context.Divers.FindAsync(id);
            _context.Divers.Remove(diver);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiverExists(int id)
        {
            return _context.Divers.Any(e => e.Id == id);
        }
    }
}
