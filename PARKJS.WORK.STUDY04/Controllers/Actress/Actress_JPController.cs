using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PARKJS.WORK.STUDY04.Data;
using PARKJS.WORK.STUDY04.Models.Actress;

namespace PARKJS.WORK.STUDY04.Controllers.Actress
{
    public class Actress_JPController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Actress_JPController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Actress_JP
        public async Task<IActionResult> Index()
        {
            return View(await _context.Actress_JP.ToListAsync());
        }

        // GET: Actress_JP/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actress_JP = await _context.Actress_JP
                .FirstOrDefaultAsync(m => m.Actr_JP_ID == id);
            if (actress_JP == null)
            {
                return NotFound();
            }

            return View(actress_JP);
        }

        // GET: Actress_JP/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Actress_JP/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Actr_JP_ID,CategoryId,FirstName,LastName,ProfessionalName,Age,BirthDay,Nationality,Rate,Ranking,ActivityTime_From,ActivityTime_To,RegistDate,UpdateDate")] Actress_JP actress_JP)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actress_JP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(actress_JP);
        }

        // GET: Actress_JP/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actress_JP = await _context.Actress_JP.FindAsync(id);
            if (actress_JP == null)
            {
                return NotFound();
            }
            return View(actress_JP);
        }

        // POST: Actress_JP/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Actr_JP_ID,CategoryId,FirstName,LastName,ProfessionalName,Age,BirthDay,Nationality,Rate,Ranking,ActivityTime_From,ActivityTime_To,RegistDate,UpdateDate")] Actress_JP actress_JP)
        {
            if (id != actress_JP.Actr_JP_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actress_JP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Actress_JPExists(actress_JP.Actr_JP_ID))
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
            return View(actress_JP);
        }

        // GET: Actress_JP/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actress_JP = await _context.Actress_JP
                .FirstOrDefaultAsync(m => m.Actr_JP_ID == id);
            if (actress_JP == null)
            {
                return NotFound();
            }

            return View(actress_JP);
        }

        // POST: Actress_JP/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actress_JP = await _context.Actress_JP.FindAsync(id);
            _context.Actress_JP.Remove(actress_JP);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Actress_JPExists(int id)
        {
            return _context.Actress_JP.Any(e => e.Actr_JP_ID == id);
        }
    }
}
