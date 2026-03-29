using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Template5.Models;
using Template5.ViewModels;

namespace Template5.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var products = _context.tChiTietSanPhams
            .Include(p => p.MaMauSacNavigation)
            .Include(p => p.MaSPNavigation)
            .Where(p => p.MaMauSacNavigation.TenMauSac == "Đỏ")
            .Select(item => new ProductView
            {
                MaSP = item.MaSPNavigation.MaSP,
                MaChiTietSP = item.MaChiTietSP,
                AnhDaiDien = item.AnhDaiDien, 
                DonGiaBan = item.DonGiaBan,
                TenSP = item.MaSPNavigation.TenSP
            }).ToList();

        return View(products);
    }

    [HttpGet]
    public IActionResult XoaSanPham(string maSanPham)
    {
        TempData["Message"] = "";
        var chiTietSanPhams = _context.tChiTietSanPhams.Where(p => p.MaSP == maSanPham).ToList();
        if (chiTietSanPhams.Count() > 0)
        {
            TempData["Message"] = "Không xóa được sản phẩm này";
            return RedirectToAction("Index", "Home");
        }
        var anhSanPhams = _context.tAnhSPs.Where(p => p.MaSP == maSanPham).ToList();
        if (anhSanPhams.Any()) _context.RemoveRange(anhSanPhams);
        _context.Remove(_context.tDanhMucSPs.Find(maSanPham));
        _context.SaveChanges();
        TempData["Message"] = "Sản phẩm đã được xóa";
        return RedirectToAction("Index", "Home");

    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
