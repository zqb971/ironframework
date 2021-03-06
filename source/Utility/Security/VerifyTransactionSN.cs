﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IronFramework.Utility
{
    /// <summary>
    /// VerifyTransactionSN
    /// </summary>
    public class VerifyTransactionSN
    {

        /// <summary>
        /// Gets the hash string.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>string</returns>
        public static string GetHashString(string username, string password)
        {
            string salt = username;
            byte[] passwordAndSaltBytes = System.Text.Encoding.UTF8.GetBytes(password + salt);
            byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);
            string hashString = Convert.ToBase64String(hashBytes);
            return hashString;
        }

        #region "生成交易标记号"
        /// <summary>
        /// 生成交易标记号
        /// </summary>
        /// <param name="FirstPhoneNumber">第一个号码</param>
        /// <returns>返回一个20位长的字符串</returns>
        public static string BuildTransactionSN(string FirstPhoneNumber)
        {
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            return Hex(md5.ComputeHash(Encoding.ASCII.GetBytes(
                FirstPhoneNumber + DateTime.Now.ToString("MMddHHmmss") + FirstPhoneNumber + GetNewGuid()
                ))).Substring(0, 20).ToUpper();

        }

        #endregion


        #region GenerateTranscationSN 
        /// <summary>
        /// Generates the sn 随机数字20位
        /// </summary>
        /// <param name="phonenumber">The phonenumber.</param>
        /// <returns>string</returns>
        public static string GenerateSN(string phonenumber)
        {
            string target = GetRandomIntFromByte(phonenumber) + GenerateRandomInt((int)DateTime.Now.Ticks).ToString();
            return target.Substring(0, 20);
        }

        /// <summary>
        /// Generates the random int.
        /// </summary>
        /// <returns>int</returns>
        public static int GenerateRandomInt()
        {
            int seed1 = (int)DateTime.Now.Ticks;
            return GenerateRandomInt(seed1);
        }

        /// <summary>
        /// Generates the random int.
        /// </summary>
        /// <param name="seed1">The seed1.</param>
        /// <returns>int</returns>
        public static int GenerateRandomInt(int seed1)
        {
            var rnd = new Random(seed1);
            return rnd.Next(0, int.MaxValue);
        }

        /// <summary>
        /// Gets the random int from byte.
        /// </summary>
        /// <param name="phonenumber">The phonenumber.</param>
        /// <returns>UInt64</returns>
        public static UInt64 GetRandomIntFromByte(string phonenumber)
        {
            var seed = Encoding.Default.GetBytes(phonenumber);
            new RNGCryptoServiceProvider().GetBytes(seed);
            return BitConverter.ToUInt64(seed, 0);
        }

        #endregion

        #region "转换为16进制"
        /// <summary>
        /// 转换为16进制.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string Hex(byte[] s)   //
        {
            string ret = "";
            for (int i = 0; i < 16; i++)
            {
                ret += s[i].ToString("x2");
            }
            return ret;
        }

        #endregion

        #region 动态生成GUID
        //动态生成GUID 
        public static string GetNewGuid()
        {
            return System.Guid.NewGuid().ToString().Replace("-", "").ToUpper();
        }
        #endregion

        /// <summary>
        /// BuildSISMSID 生成一段随机字符串
        /// </summary>
        /// <returns></returns>
        public static string BuildSISMSID()
        {
            DateTime dt = DateTime.Now;
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

            return Hex(md5.ComputeHash(Encoding.ASCII.GetBytes(dt.ToString("MMddHHmmss") + GetNewGuid()))).Substring(0, 30).ToUpper();

        }

        /// <summary>
        /// Generates the Variant hash string.
        /// </summary>
        /// <param name="workFactor">The work factor.</param>
        /// <param name="contextString">The context string.</param>
        /// <returns>
        /// Hash string
        /// </returns>
        /// <see cref="http://codahale.com/how-to-safely-store-a-password/" />
        /// <seealso cref="http://bcrypt.codeplex.com/" />
        /// <example>
        ///   <code>
        /// public void BCryptTest()
        /// {
        /// const string password = "PASSWORD";
        /// const int workFactor = 13;
        /// var start = DateTime.UtcNow;
        /// var hashed = BCrypt.Net.BCrypt.HashPassword(password, workFactor);
        /// var end = DateTime.UtcNow;
        /// Console.WriteLine("hash length is {0} chars", hashed.Length);
        /// Console.WriteLine("Processing time is {0} with workFactor {1}", end - start, workFactor);
        /// Console.WriteLine("Hashed password: {0} ", hashed);
        /// Console.WriteLine("correct password {0}", BCrypt.Net.BCrypt.Verify("PASSWORD", hashed));
        /// Console.WriteLine("incorrect password {0}", BCrypt.Net.BCrypt.Verify("PASSWORd", hashed));
        /// }
        /// </code>
        /// </example>
        public static string GenerateVariantHashString(string contextString,int workFactor=13)
        {
            return BCrypt.Net.BCrypt.HashPassword(contextString, workFactor);
        }

        /// <summary>
        /// Generates the variant hash string.
        /// </summary>
        /// <param name="contextString">The context string.</param>
        /// <returns></returns>
        public static string GenerateVariantHashString(string contextString)
        {
            return GenerateVariantHashString(contextString, 13);
        }

        /// <summary>
        /// Verifies the variant hash.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="hash">The hash.</param>
        /// <returns></returns>
        public static bool VerifyVariantHash(string text, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(text, hash);
        }


        /// <summary>
        /// Compute the hash with HMAC
        /// </summary>
        /// <param name="hashedPassword">The hashed password.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public static string ComputeHash(string hashedPassword, string message)
        {
            var key = Encoding.UTF8.GetBytes(hashedPassword.ToUpper());
            string hashString;

            using (var hmac = new HMACSHA256(key))
            {
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(message));
                hashString = Convert.ToBase64String(hash);
            }

            return hashString;
        }

    }
}
