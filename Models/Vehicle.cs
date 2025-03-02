using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingManagementSystem.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "License Plate")]
        public string LicensePlate { get; set; }

        [Required]
        [Display(Name = "Vehicle Type")]
        public VehicleType Type { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public enum VehicleType
    {
        Car,
        Motorcycle,
        Truck,
        Van
    }
}