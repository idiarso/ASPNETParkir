using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingManagementSystem.Models
{
    public class ParkingSpace
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Space Number")]
        public string SpaceNumber { get; set; }

        [Required]
        [Display(Name = "Floor Level")]
        public int FloorLevel { get; set; }

        [Required]
        [Display(Name = "Space Type")]
        public SpaceType Type { get; set; }

        [Required]
        [Display(Name = "Is Occupied")]
        public bool IsOccupied { get; set; } = false;

        public Vehicle? CurrentVehicle { get; set; }
        public int? CurrentVehicleId { get; set; }

        [Display(Name = "Last Updated")]
        public DateTime LastUpdated { get; set; } = DateTime.Now;
    }

    public enum SpaceType
    {
        Standard,
        Handicapped,
        Compact,
        Electric
    }
}