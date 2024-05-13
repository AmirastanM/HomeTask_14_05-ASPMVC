using HomeWork_Front_Back.Data;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_Front_Back.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;
        public WorkController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
