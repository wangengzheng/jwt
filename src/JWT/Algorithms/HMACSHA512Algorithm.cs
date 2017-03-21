﻿using System.Security.Cryptography;

namespace JWT.Algorithms
{
    public sealed class HMACSHA512Algorithm : IJwtAlgorithm
    {
        public byte[] Sign(byte[] key, byte[] bytesToSign)
        {
            using (var sha = new HMACSHA256(key))
            {
                return sha.ComputeHash(bytesToSign);
            }
        }

        //public string Name = JwtHashAlgorithm.HS512.ToString();

		public string Name { get { return JwtHashAlgorithm.HS512.ToString(); } }
    }
}