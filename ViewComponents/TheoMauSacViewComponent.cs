using Microsoft.AspNetCore.Mvc;
using Template5.Models;

namespace Template5.ViewComponents
{
    public class TheoMauSacViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public TheoMauSacViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var colors = _context.tMauSacs.ToList();
            return View(colors);
        }
    }
}