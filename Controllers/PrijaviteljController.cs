using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AplikacijaZaPrijavuOstecenjaSisMosZup.Data;
using AplikacijaZaPrijavuOstecenjaSisMosZup.Models;

namespace AplikacijaZaPrijavuOstecenjaSisMosZup.Controllers
{
    public class PrijaviteljController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrijaviteljController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Prijavitelj
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Prijavitelj.Include(p => p.RazinaOstecenja);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Prijavitelj/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavitelj = await _context.Prijavitelj
                .Include(p => p.RazinaOstecenja)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prijavitelj == null)
            {
                return NotFound();
            }

            return View(prijavitelj);
        }

        // GET: Prijavitelj/Create
        public IActionResult Create()
        {
            ViewData["RazinaOstecenjaId"] = new SelectList(_context.RazinaOstecenja, "Id", "Ime");
            return View();
        }

        // POST: Prijavitelj/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ime,Prezime,Broj_Godina,OIB,Selo_Grad,Adresa,Email,Kontakt_Broj,RazinaOstecenjaId")] Prijavitelj prijavitelj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prijavitelj);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RazinaOstecenjaId"] = new SelectList(_context.RazinaOstecenja, "Id", "Ime", prijavitelj.RazinaOstecenjaId);
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        // GET: Prijavitelj/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavitelj = await _context.Prijavitelj.FindAsync(id);
            if (prijavitelj == null)
            {
                return NotFound();
            }
            ViewData["RazinaOstecenjaId"] = new SelectList(_context.RazinaOstecenja, "Id", "Id", prijavitelj.RazinaOstecenjaId);
            return View(prijavitelj);
        }

        // POST: Prijavitelj/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ime,Prezime,Broj_Godina,OIB,Selo_Grad,Adresa,Email,Kontakt_Broj,RazinaOstecenjaId")] Prijavitelj prijavitelj)
        {
            if (id != prijavitelj.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prijavitelj);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrijaviteljExists(prijavitelj.Id))
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
            ViewData["RazinaOstecenjaId"] = new SelectList(_context.RazinaOstecenja, "Id", "Id", prijavitelj.RazinaOstecenjaId);
            return View(prijavitelj);
        }

        // GET: Prijavitelj/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavitelj = await _context.Prijavitelj
                .Include(p => p.RazinaOstecenja)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prijavitelj == null)
            {
                return NotFound();
            }

            return View(prijavitelj);
        }

        // POST: Prijavitelj/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prijavitelj = await _context.Prijavitelj.FindAsync(id);
            _context.Prijavitelj.Remove(prijavitelj);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrijaviteljExists(int id)
        {
            return _context.Prijavitelj.Any(e => e.Id == id);
        }
    }
}
