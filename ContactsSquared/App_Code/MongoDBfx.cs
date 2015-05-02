using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MongoDB.Driver;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace ContactsSquared.App_Code
{
    public class MongoDBfx
    {
        private const string masterDBName = "ContactsSquaredMaster";
        private const int saltLength = 128 / 8;

        private static readonly MongoClient client = new MongoClient();
        
        public static async void RegisterNewUserAsync(string userID, string pswd)
        {
            //var client = new MongoClient();
            var masterDB = client.GetDatabase(masterDBName);

            string userDBName = DBNameForUser(userID);
            var userDB = client.GetDatabase(userDBName);
            var user = new User { Name = userID, HashedPassword = HashPassword(pswd), DBName = userDBName };
            var userCollection = masterDB.GetCollection<User>("users");
            await userCollection.InsertOneAsync(user);
        }

        private static string DBNameForUser(string userID)
        {
            return userID.Replace('@', '_').Replace('.', '_');
        }

        private static byte[] HashPassword(string pswd)
        {
            byte[] salt = CreateSalt(saltLength);
            byte[] hashedPswd = Hash(pswd, salt);
            return salt.Concat(hashedPswd).ToArray();
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