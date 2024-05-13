using HomeWork_Front_Back.Data;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_Front_Back.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
