using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Blood.Data;
using Blood.Models;

namespace Blood.Controllers
{
    public class Test1Controller : Controller
    {
        private readonly TestDbContext1 _context;

        public Test1Controller(TestDbContext1 context)
        {
            _context = context;
        }

        // GET: Test1
        public async Task<IActionResult> Index()
        {
            return View(await _context.test_table1.ToListAsync());
        }

        // GET: Test1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var test1 = await _context.test_table1
                .FirstOrDefaultAsync(m => m.id == id);
            if (test1 == null)
            {
                return NotFound();
            }

            return View(test1);
        }

        // GET: Test1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Test1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,division,section,position,CreationTime")] Test1 test1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(test1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(test1);
        }

        // GET: Test1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var test1 = await _context.test_table1.FindAsync(id);
            if (test1 == null)
            {
                return NotFound();
            }
            return View(test1);
        }

        // POST: Test1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,division,section,position,CreationTime")] Test1 test1)
        {
            if (id != test1.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(test1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Test1Exists(test1.id))
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
            return View(test1);
        }

        // GET: Test1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var test1 = await _context.test_table1
                .FirstOrDefaultAsync(m => m.id == id);
            if (test1 == null)
            {
                return NotFound();
            }

            return View(test1);
        }

        // POST: Test1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var test1 = await _context.test_table1.FindAsync(id);
            _context.test_table1.Remove(test1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Test1Exists(int id)
        {
            return _context.test_table1.Any(e => e.id == id);
        }
    }
}
