using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingManagementSystem.Services
{
    public class AnprService : IAnprService
    {
        private readonly Regex _licensePlatePattern = new Regex(@"^[A-Z]{1,2}\s?\d{1,4}\s?[A-Z]{1,3}$");

        public async Task<string> RecognizeLicensePlateAsync(byte[] imageData)
        {
            // TODO: Implement actual ANPR image processing logic
            // For now, return a placeholder implementation
            await Task.Delay(100); // Simulate processing time
            return "Sample Plate";
        }

        public bool VerifyLicensePlate(string detectedPlate, string storedPlate)
        {
            if (string.IsNullOrWhiteSpace(detectedPlate) || string.IsNullOrWhiteSpace(storedPlate))
                return false;

            // Normalize plates by removing spaces and converting to uppercase
            var normalizedDetected = detectedPlate.Replace(" ", "").ToUpper();
            var normalizedStored = storedPlate.Replace(" ", "").ToUpper();

            return normalizedDetected == normalizedStored;
        }

        public bool ValidateLicensePlateFormat(string licensePlate)
        {
            if (string.IsNullOrWhiteSpace(licensePlate))
                return false;

            return _licensePlatePattern.IsMatch(licensePlate.ToUpper());
        }
    }
}