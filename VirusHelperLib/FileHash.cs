using System;
using System.IO;
using System.Security.Cryptography;

namespace VirusHelperLib
{
    internal class FileHash
    {
        public string CalculateSHA256(string filePath)
        {
            try
            {
                using (var sha256 = SHA256.Create())
                {
                    using (var stream = File.OpenRead(filePath))
                    {
                        byte[] hashBytes = sha256.ComputeHash(stream);
                        return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException($"Unauthorized access to file: {filePath}", ex);
            }
            catch (IOException ex)
            {
                throw new IOException($"IO Exception occurred while reading file: {filePath}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error calculating SHA-256 hash for file: {filePath}", ex);
            }
        }
    }
}
