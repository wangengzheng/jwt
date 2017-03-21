﻿using System.Security.Cryptography;

namespace JWT.Algorithms
{
    public sealed class HMACSHA256Algorithm : IJwtAlgorithm
    {
        public byte[] Sign(byte[] key, byte[] bytesToSign)
        {
            using (var sha = new HMACSHA256(key))
            {
                return sha.ComputeHash(bytesToSign);
            }
        }

		public string Name { get { return JwtHashAlgorithm.HS256.ToString(); } }
    }
}