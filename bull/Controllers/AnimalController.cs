using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using bull.Models;

namespace bull.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalContext _context;

        public AnimalController(AnimalContext context)
        {
            _context = context;
        }

        // GET: AnimalModels
        public async Task<IActionResult> Index()
        {
            var lista = new List<AnimalModel>() {
                {
                    new AnimalModel(){
                    NomeAnimal = "NOME",
                    Pelagem = "PRETO",
                    NumeroCobertura = "250"
                    }
                }
            };

            return View(lista);
           // return View(await _context.AnimalModel.ToListAsync());
        }

        // GET: AnimalModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalModel = await _context.AnimalModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (animalModel == null)
            {
                return NotFound();
            }

            return View(animalModel);
        }

        // GET: AnimalModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AnimalModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Origem,NumeroCobertura,NomeAnimal,DataNascimento,Sexo,Desmamado,Pelagem,Categoria,Peso")] AnimalModel animalModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(animalModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(animalModel);
        }

        // GET: AnimalModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalModel = await _context.AnimalModel.FindAsync(id);
            if (animalModel == null)
            {
                return NotFound();
            }
            return View(animalModel);
        }

        // POST: AnimalModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Origem,NumeroCobertura,NomeAnimal,DataNascimento,Sexo,Desmamado,Pelagem,Categoria,Peso")] AnimalModel animalModel)
        {
            if (id != animalModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(animalModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnimalModelExists(animalModel.ID))
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
            return View(animalModel);
        }

        // GET: AnimalModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalModel = await _context.AnimalModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (animalModel == null)
            {
                return NotFound();
            }

            return View(animalModel);
        }

        // POST: AnimalModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var animalModel = await _context.AnimalModel.FindAsync(id);
            _context.AnimalModel.Remove(animalModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnimalModelExists(int id)
        {
            return _context.AnimalModel.Any(e => e.ID == id);
        }
    }
}
