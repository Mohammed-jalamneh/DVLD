using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.OtherClasses
{
    public class clsCryptography
    {
        public static string ComputeHash(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Input cannot be null, empty, or whitespace.", nameof(input));

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder sb = new StringBuilder(64);
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public static bool IsSha256Hash(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || input.Length != 64)
                return false;

            foreach (char c in input)
            {
                bool isHex = (c >= '0' && c <= '9') ||
                             (c >= 'a' && c <= 'f') ||
                             (c >= 'A' && c <= 'F');

                if (!isHex)
                    return false;
            }

            return true;
        }
    }
}
