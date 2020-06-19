using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Blood.Data;
using Blood.Models;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PagedList;

namespace Blood.Controllers
{
    public class InventoriesController : Controller
    {
        private readonly InventoryDbContext _context;
        private readonly ComponentDbContext _component_context;
        private readonly ComponentUserDbContext _component_user_context;
        private readonly BloodTypeDbContext _blood_type_context;

        public InventoriesController(InventoryDbContext context, ComponentDbContext component_context, ComponentUserDbContext component_user_context, BloodTypeDbContext blood_type_context)
        {
            _context = context;
            _component_context = component_context;
            _component_user_context = component_user_context;
            _blood_type_context = blood_type_context;
        }

        // GET: Inventories
        public async Task<IActionResult> Index(int? page)
        {
            var inventory = await _context.inventory.ToListAsync();

            ViewBag.inventory = JsonConvert.SerializeObject(inventory);

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.inventory
                .FirstOrDefaultAsync(m => m.id == id);
            if (inventory == null)
            {
                return NotFound();
            }

            return View(inventory);
        }

        // GET: Inventories/Create
        public IActionResult Create()
        {
            ViewBag.component = _component_context.component.ToList();
            ViewBag.blood_type = _blood_type_context.blood_type.ToList();
            return View();
        }

        // POST: Inventories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,created_by,serial_no,qty,mbd,blood_type,date_coltd,date_released,stakeholder,date_transfuse,key_test,age,expiry_date,status,amount,CreationTime,ModifiedDate")] Inventory inventory, string[] component)
        {
            var userid = "0001";
            var serial_code = DateTime.Now.ToString("yyyyMMdd") + "-" + userid + "-" + DateTime.Now.ToString("HHmmss");
            var inventory_body = new Inventory
            {
                created_by = userid,
                serial_no = serial_code,
                qty = inventory.qty,
                mbd = inventory.mbd,
                blood_type = inventory.blood_type,
                date_coltd = inventory.date_coltd,
                date_released = inventory.date_released,
                stakeholder = inventory.stakeholder,
                date_transfuse = inventory.date_transfuse,
                key_test = inventory.key_test,
                age = inventory.age,
                expiry_date = inventory.expiry_date,
                status = inventory.status,
                amount = inventory.amount,
            };
            _context.Add(inventory_body);
            await _context.SaveChangesAsync();

            foreach (string component_id in component)
            {
                var component_user = new ComponentUser
                {
                    inventory_id = inventory_body.id,
                    component_id = int.Parse(component_id)
                };
                _component_user_context.Add(component_user);
                await _component_user_context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public object create([Bind("id,created_by,serial_no,qty,mbd,blood_type,date_coltd,date_released,stakeholder,date_transfuse,key_test,age,expiry_date,status,amount,creationtime,modifieddate")] Inventory inventory, string[] component)
        //{
        //    return inventory;
        //}

        // GET: Inventories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.inventory.FindAsync(id);
            if (inventory == null)
            {
                return NotFound();
            }
            return View(inventory);
        }

        // POST: Inventories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,created_by,serial_no,qty,mbd,blood_type,date_coltd,date_released,stakeholder,date_transfuse,key_test,age,expiry_date,status,amount,CreationTime,ModifiedDate")] Inventory inventory)
        {
            if (id != inventory.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventoryExists(inventory.id))
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
            return View(inventory);
        }

        // GET: Inventories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.inventory
                .FirstOrDefaultAsync(m => m.id == id);
            if (inventory == null)
            {
                return NotFound();
            }

            return View(inventory);
        }

        // POST: Inventories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventory = await _context.inventory.FindAsync(id);
            _context.inventory.Remove(inventory);
            await _context.SaveChangesAsync();

            var component_user = await _component_user_context.component_user.Where(m => m.inventory_id == id).ToListAsync();
            _component_user_context.RemoveRange(component_user);
            await _component_user_context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool InventoryExists(int id)
        {
            return _context.inventory.Any(e => e.id == id);
        }
    }
}
