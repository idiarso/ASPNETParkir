using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkingManagementSystem.Services;
using ParkingManagementSystem.Models;

namespace ParkingManagementSystem.Controllers
{
    public class AnprController : Controller
    {
        private readonly IAnprService _anprService;

        public AnprController(IAnprService anprService)
        {
            _anprService = anprService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProcessEntry(byte[] imageData)
        {
            try
            {
                var licensePlate = await _anprService.RecognizeLicensePlateAsync(imageData);
                
                if (!_anprService.ValidateLicensePlateFormat(licensePlate))
                {
                    return BadRequest("Invalid license plate format");
                }

                // TODO: Create parking ticket and assign parking space
                
                return Json(new { success = true, licensePlate });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error processing entry: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> ProcessExit(byte[] imageData, string ticketId)
        {
            try
            {
                var licensePlate = await _anprService.RecognizeLicensePlateAsync(imageData);
                
                // TODO: Verify parking ticket and process payment
                
                return Json(new { success = true, licensePlate });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error processing exit: {ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult CaptureImage()
        {
            return View();
        }
    }
}