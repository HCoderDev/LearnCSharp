using System;
using System.Security.Cryptography;

namespace PasswordGenerator
{
    class Random1
    {
        public int Next(int n)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[4];
            provider.GetBytes(byteArray);

            //convert 4 bytes to an integer
            var randomInteger = BitConverter.ToUInt32(byteArray, 0);
            return (int)(randomInteger % n);
        }
    }
}
