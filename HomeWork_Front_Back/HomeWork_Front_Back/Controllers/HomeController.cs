using HomeWork_Front_Back.Data;
using HomeWork_Front_Back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeWork_Front_Back.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;     
        }
        public async Task<IActionResult> Index()
        {   
            List<Slider> sliders = await _context.Sliders.ToListAsync();    
            return View(sliders);  
        }
    }
}
