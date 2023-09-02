using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DiiscoverTaza.Models;

namespace DiiscoverTaza.Controllers
{
    public class FormulaireDatumsController : Controller
    {
        private readonly TourismContext _context;

        public FormulaireDatumsController(TourismContext context)
        {
            _context = context;
        }

        //// GET: FormulaireDatums
        //public async Task<IActionResult> Index()
        //{
        //      return _context.FormulaireData != null ? 
        //                  View(await _context.FormulaireData.ToListAsync()) :
        //                  Problem("Entity set 'TourismContext.FormulaireData'  is null.");
        //}

        //// GET: FormulaireDatums/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.FormulaireData == null)
        //    {
        //        return NotFound();
        //    }

        //    var formulaireDatum = await _context.FormulaireData
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (formulaireDatum == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(formulaireDatum);
        //}

        //// GET: FormulaireDatums/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: FormulaireDatums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> SaveFormData([FromBody] FormulaireDatum formulaireDatum)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(formulaireDatum);
        //        await _context.SaveChangesAsync();
        //        return Json(new { success = true });
        //    }
        //    return Json(new { success = false, errors = ModelState.Values.SelectMany(v => v.Errors) });
        //}

        public JsonResult SaveFormData([FromBody] FormulaireDatum formData)
        {
            if (ModelState.IsValid)
        {
               _context.Add(formData);
                _context.SaveChanges();
            return Json(new { success = true });
           }
          return Json(new { success = false, errors = ModelState.Values.SelectMany(v => v.Errors) });    


        }
        //// GET: FormulaireDatums/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.FormulaireData == null)
        //    {
        //        return NotFound();
        //    }

        //    var formulaireDatum = await _context.FormulaireData.FindAsync(id);
        //    if (formulaireDatum == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(formulaireDatum);
        //}

        // POST: FormulaireDatums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Phone,Subject,Question")] FormulaireDatum formulaireDatum)
        //{
        //    if (id != formulaireDatum.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(formulaireDatum);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!FormulaireDatumExists(formulaireDatum.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(formulaireDatum);
        //}

        //// GET: FormulaireDatums/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.FormulaireData == null)
        //    {
        //        return NotFound();
        //    }

        //    var formulaireDatum = await _context.FormulaireData
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (formulaireDatum == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(formulaireDatum);
        //}

        //// POST: FormulaireDatums/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.FormulaireData == null)
        //    {
        //        return Problem("Entity set 'TourismContext.FormulaireData'  is null.");
        //    }
        //    var formulaireDatum = await _context.FormulaireData.FindAsync(id);
        //    if (formulaireDatum != null)
        //    {
        //        _context.FormulaireData.Remove(formulaireDatum);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool FormulaireDatumExists(int id)
        //{
        //  return (_context.FormulaireData?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
