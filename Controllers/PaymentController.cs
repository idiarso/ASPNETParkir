using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkingManagementSystem.Models;
using ParkingManagementSystem.Services;

namespace ParkingManagementSystem.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public async Task<IActionResult> Process(int ticketId)
        {
            var fee = await _paymentService.CalculateParkingFeeAsync(ticketId);
            ViewBag.ParkingFee = fee;
            ViewBag.TicketId = ticketId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProcessPayment(int ticketId, PaymentMethod paymentMethod, decimal amount)
        {
            var success = await _paymentService.ProcessPaymentAsync(ticketId, paymentMethod, amount);
            
            if (success)
            {
                TempData["SuccessMessage"] = "Payment processed successfully";
                return RedirectToAction("Receipt", new { ticketId });
            }

            TempData["ErrorMessage"] = "Payment processing failed";
            return RedirectToAction("Process", new { ticketId });
        }

        public async Task<IActionResult> Receipt(int ticketId)
        {
            return View(ticketId);
        }

        [HttpGet]
        public async Task<IActionResult> DailyReport(DateTime? date)
        {
            date ??= DateTime.Today;
            var report = await _paymentService.GenerateDailyReportAsync(date.Value);
            return View(report);
        }
    }
}