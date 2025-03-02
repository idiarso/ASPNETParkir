using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParkingManagementSystem.Data;
using ParkingManagementSystem.Models;

namespace ParkingManagementSystem.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly ApplicationDbContext _context;

        public PaymentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> ProcessPaymentAsync(int ticketId, PaymentMethod paymentMethod, decimal amount)
        {
            var ticket = await _context.ParkingTickets.FindAsync(ticketId);
            if (ticket == null) return false;

            try
            {
                ticket.PaymentMethod = paymentMethod;
                ticket.TotalAmount = amount;
                ticket.PaymentStatus = PaymentStatus.Completed;
                ticket.PaymentTime = DateTime.Now;

                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                ticket.PaymentStatus = PaymentStatus.Failed;
                await _context.SaveChangesAsync();
                return false;
            }
        }

        public async Task<decimal> CalculateParkingFeeAsync(int ticketId)
        {
            var ticket = await _context.ParkingTickets.FindAsync(ticketId);
            if (ticket == null) return 0;

            var duration = (ticket.CheckOutTime ?? DateTime.Now) - ticket.CheckInTime;
            var hours = Math.Ceiling(duration.TotalHours);

            // Basic rate: $2 per hour
            const decimal hourlyRate = 2.0m;
            return hours * hourlyRate;
        }

        public async Task<RevenueReport> GenerateDailyReportAsync(DateTime date)
        {
            var startDate = date.Date;
            var endDate = startDate.AddDays(1);

            var completedPayments = await _context.ParkingTickets
                .Where(t => t.PaymentTime >= startDate && t.PaymentTime < endDate
                    && t.PaymentStatus == PaymentStatus.Completed)
                .ToListAsync();

            var report = new RevenueReport
            {
                Date = date,
                TotalTransactions = completedPayments.Count,
                TotalRevenue = completedPayments.Sum(t => t.TotalAmount ?? 0),
                TotalVehicles = completedPayments.Select(t => t.VehicleId).Distinct().Count(),
                AverageStayDuration = completedPayments
                    .Average(t => ((t.CheckOutTime ?? DateTime.Now) - t.CheckInTime).TotalHours)
            };

            return report;
        }
    }
}