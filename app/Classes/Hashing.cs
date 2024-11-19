using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace app.Classes
{
    internal class Hashing
    {
        public string Hash(string input)
        {
            using (var sha512 = SHA512.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha512.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
