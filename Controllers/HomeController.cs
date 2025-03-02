using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ParkingManagementSystem.Models;
using ParkingManagementSystem.Data;

namespace ParkingManagementSystem.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [Authorize]
    public IActionResult Dashboard()
    {
        var parkingSpaces = _context.ParkingSpaces.Include(p => p.CurrentVehicle).ToList();
        
        // Get recent activities
        var recentActivities = _context.ParkingTickets
            .Include(t => t.Vehicle)
            .Include(t => t.ParkingSpace)
            .OrderByDescending(t => t.EntryTime)
            .Take(10)
            .ToList();

        ViewBag.RecentActivities = recentActivities;
        return View(parkingSpaces);
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
