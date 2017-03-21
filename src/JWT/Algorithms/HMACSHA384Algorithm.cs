﻿using System.Security.Cryptography;

namespace JWT.Algorithms
{
    public sealed class HMACSHA384Algorithm : IJwtAlgorithm
    {
        public byte[] Sign(byte[] key, byte[] bytesToSign)
        {
            using (var sha = new HMACSHA256(key))
            {
                return sha.ComputeHash(bytesToSign);
            }
        }

		public string Name { get { return JwtHashAlgorithm.HS384.ToString(); } }
    }
}