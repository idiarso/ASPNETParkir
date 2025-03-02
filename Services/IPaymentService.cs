using System.Threading.Tasks;
using ParkingManagementSystem.Models;

namespace ParkingManagementSystem.Services
{
    public interface IPaymentService
    {
        /// <summary>
        /// Process payment for a parking ticket
        /// </summary>
        /// <param name="ticketId">The ID of the parking ticket</param>
        /// <param name="paymentMethod">The payment method used</param>
        /// <param name="amount">The payment amount</param>
        /// <returns>True if payment is successful, false otherwise</returns>
        Task<bool> ProcessPaymentAsync(int ticketId, PaymentMethod paymentMethod, decimal amount);

        /// <summary>
        /// Calculate parking fee for a ticket
        /// </summary>
        /// <param name="ticketId">The ID of the parking ticket</param>
        /// <returns>The calculated parking fee</returns>
        Task<decimal> CalculateParkingFeeAsync(int ticketId);

        /// <summary>
        /// Generate daily revenue report
        /// </summary>
        /// <param name="date">The date for the report</param>
        /// <returns>The revenue report data</returns>
        Task<RevenueReport> GenerateDailyReportAsync(System.DateTime date);
    }

    public class RevenueReport
    {
        public System.DateTime Date { get; set; }
        public int TotalTransactions { get; set; }
        public decimal TotalRevenue { get; set; }
        public int TotalVehicles { get; set; }
        public decimal AverageStayDuration { get; set; }
    }
}