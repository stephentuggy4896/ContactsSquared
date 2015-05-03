using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace ContactsSquared.App_Code
{
    public class Utils
    {
        private const int saltLength = 128 / 8;

        public static void MyRedirect(string destUrl)
        {
            HttpContext.Current.Response.Redirect(destUrl, false);
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
        
        public static byte[] HashPassword(string pswd)
        {
            byte[] salt = CreateSalt(saltLength);
            byte[] hashedPswd = Hash(pswd, salt);
            return salt.Concat(hashedPswd).ToArray();
        }

        public static bool ConfirmPassword(string triedPassword, byte[] storedHashedPswd)
        {
            byte[] salt = storedHashedPswd.Take(saltLength).ToArray();
            byte[] hashOfTriedPassword = Hash(triedPassword, salt);

            return storedHashedPswd.SequenceEqual(hashOfTriedPassword);
        }

        private static byte[] CreateSalt(int size)
        {
            //Generate a cryptographic random number.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);

            // Return a Base64 string representation of the random number.
            return buff;
        }

        private static byte[] Hash(string value, byte[] salt)
        {
            return Hash(Encoding.UTF8.GetBytes(value), salt);
        }

        private static byte[] Hash(byte[] value, byte[] salt)
        {
            byte[] saltedValue = value.Concat(salt).ToArray();

            return new SHA256Managed().ComputeHash(saltedValue);
        }
    }
}