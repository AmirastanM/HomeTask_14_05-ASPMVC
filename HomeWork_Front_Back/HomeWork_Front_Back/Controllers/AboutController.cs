using HomeWork_Front_Back.Data;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_Front_Back.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
