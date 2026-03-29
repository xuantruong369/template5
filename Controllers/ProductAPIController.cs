using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Template5.Models;
using Template5.ViewModels;

namespace Template5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductAPIController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{maMauSac}")]
        public IEnumerable<ProductView> GetProductsByColor(string maMauSac)
        {
            var products = _context.tChiTietSanPhams
                .Include(p => p.MaSPNavigation)
                .Where(p => p.MaMauSac == maMauSac)
                .Select(item => new ProductView
                {
                    MaSP = item.MaSPNavigation.MaSP,
                    MaChiTietSP = item.MaChiTietSP,
                    TenSP = item.MaSPNavigation.TenSP,
                    AnhDaiDien = item.AnhDaiDien,
                    DonGiaBan = item.DonGiaBan
                }).ToList();
            return products;
        }
    }
}