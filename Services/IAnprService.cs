using System.Threading.Tasks;

namespace ParkingManagementSystem.Services
{
    public interface IAnprService
    {
        /// <summary>
        /// Recognizes the license plate number from an image
        /// </summary>
        /// <param name="imageData">The image data as byte array</param>
        /// <returns>The recognized license plate number</returns>
        Task<string> RecognizeLicensePlateAsync(byte[] imageData);

        /// <summary>
        /// Verifies if the detected license plate matches with the stored one
        /// </summary>
        /// <param name="detectedPlate">The detected license plate number</param>
        /// <param name="storedPlate">The stored license plate number</param>
        /// <returns>True if the plates match, false otherwise</returns>
        bool VerifyLicensePlate(string detectedPlate, string storedPlate);

        /// <summary>
        /// Validates if the license plate format is correct
        /// </summary>
        /// <param name="licensePlate">The license plate number to validate</param>
        /// <returns>True if the format is valid, false otherwise</returns>
        bool ValidateLicensePlateFormat(string licensePlate);
    }
}