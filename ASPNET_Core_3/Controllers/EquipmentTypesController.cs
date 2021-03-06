﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EquipmentManager.Models;

namespace EquipmentManager.Controllers
{
    public class EquipmentTypesController : Controller
    {
        private readonly UcInventoryContext _context;

        public EquipmentTypesController(UcInventoryContext context)
        {
            _context = context;
        }

        // GET: EquipmentTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.EquipmentType.ToListAsync());
        }

        // GET: EquipmentTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentType = await _context.EquipmentType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipmentType == null)
            {
                return NotFound();
            }

            return View(equipmentType);
        }

        // GET: EquipmentTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EquipmentTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] EquipmentType equipmentType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipmentType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equipmentType);
        }

        // GET: EquipmentTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentType = await _context.EquipmentType.FindAsync(id);
            if (equipmentType == null)
            {
                return NotFound();
            }
            return View(equipmentType);
        }

        // POST: EquipmentTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] EquipmentType equipmentType)
        {
            if (id != equipmentType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipmentType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipmentTypeExists(equipmentType.Id))
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
            return View(equipmentType);
        }

        // GET: EquipmentTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentType = await _context.EquipmentType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipmentType == null)
            {
                return NotFound();
            }

            return View(equipmentType);
        }

        // POST: EquipmentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipmentType = await _context.EquipmentType.FindAsync(id);
            _context.EquipmentType.Remove(equipmentType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipmentTypeExists(int id)
        {
            return _context.EquipmentType.Any(e => e.Id == id);
        }
    }
}
