using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingManagementSystem.Models
{
    public class ParkingTicket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        [Required]
        public int ParkingSpaceId { get; set; }
        public ParkingSpace ParkingSpace { get; set; }

        [Required]
        [Display(Name = "Check-in Time")]
        public DateTime CheckInTime { get; set; } = DateTime.Now;

        [Display(Name = "Check-out Time")]
        public DateTime? CheckOutTime { get; set; }

        [Display(Name = "Total Amount")]
        [DataType(DataType.Currency)]
        public decimal? TotalAmount { get; set; }

        [Display(Name = "Payment Status")]
        public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending;

        [Display(Name = "Payment Method")]
        public PaymentMethod? PaymentMethod { get; set; }

        [Display(Name = "Payment Time")]
        public DateTime? PaymentTime { get; set; }
    }

    public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed,
        Refunded
    }

    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        DebitCard,
        MobilePayment
    }
}