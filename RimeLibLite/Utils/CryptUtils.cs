using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Utils;

public class CryptUtils
{
	
	// https://github.com/dotnet/runtime/blob/b883e2d25736432bfe1a6af4896aed2af3d69ef9/src/libraries/System.Security.Cryptography/src/System/Security/Cryptography/CngHelpers.cs#LL409C23-L411C107
	// Bcrypt doesnt need the extra values at the end, and can calculate the rest. Not even sure if it supports it or not
	public class BCryptRsakeyBlob
		: IFbSerializable
	{
		public static readonly uint c_PublicMagic = 0x31415352;
		public static readonly uint c_PrivateMagic = 0x32415352;
		
		
		public BCryptRsakeyBlob()
		{
		}
		public BCryptRsakeyBlob(RimeReader p_Reader)
		{
			Deserialize(p_Reader);
		}
		
		
		public byte[] PublicExponent { get; set; } = new byte[0];
		public byte[] Modulus { get; set; } = new byte[0];
		public byte[] Prime1 { get; set; } = new byte[0];
		public byte[] Prime2 { get; set; } = new byte[0];

		public bool HasPrivateKey => Prime1.Length > 0 || Prime2.Length > 0;


		public void ExcludePrivateKey()
		{
			Prime1 = new byte[0];
			Prime2 = new byte[0];
		}

		public void Deserialize(RimeReader p_Reader)
		{
			var s_Magic = p_Reader.ReadUInt32();

			if (s_Magic != c_PublicMagic &&
			    s_Magic != c_PrivateMagic)
				throw new InvalidDataException("Invalid BCrypt blob!");
			
			var s_BitLength = p_Reader.ReadUInt32();

			var s_PubExpLen = p_Reader.ReadUInt32();
			var s_ModulusLen = p_Reader.ReadUInt32();
			var s_Prime1Len = p_Reader.ReadUInt32();
			var s_Prime2Len = p_Reader.ReadUInt32();


			PublicExponent = p_Reader.ReadBytes((int)s_PubExpLen);
			Modulus = p_Reader.ReadBytes((int)s_ModulusLen);

			Prime1 = p_Reader.ReadBytes((int)s_Prime1Len);
			Prime2 = p_Reader.ReadBytes((int)s_Prime2Len);
		}

		public bool Serialize(RimeWriter p_Writer)
		{

			if (HasPrivateKey)
				p_Writer.Write(c_PrivateMagic);
			else
				p_Writer.Write(c_PublicMagic);
			
			// i think this should be right??
			p_Writer.Write(Modulus.Length * 8);
			
			p_Writer.Write((uint) PublicExponent.Length);
			p_Writer.Write((uint) Modulus.Length);
			p_Writer.Write((uint) Prime1.Length);
			p_Writer.Write((uint) Prime2.Length);
			
			p_Writer.Write(PublicExponent);
			p_Writer.Write(Modulus);
			p_Writer.Write(Prime1);
			p_Writer.Write(Prime2);


			return true;
		}
		
		

		public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
		{
			var s_Stream = new MemoryStream();
			using var s_Writer = new RimeWriter(s_Stream);

			if (Serialize(s_Writer))
			{
				p_Data = s_Stream.ToArray();
				return true;
			}

			p_Data = null;
			return false;
		}


		public void Deserialize(byte[] p_Data)
		{
			using var s_Reader = new RimeReader(new MemoryStream(p_Data));
			Deserialize(s_Reader);
		}
	}

	public static RSAParameters ToRsaParams(RimeReader p_KeyBlob)
	{
		return ToRsaParams(new BCryptRsakeyBlob(p_KeyBlob));
    }

    public static RSAParameters ToRsaParams(BCryptRsakeyBlob p_Blob)
	{
		var s_RsaParams = new RSAParameters();
		
		
		s_RsaParams.Exponent = p_Blob.PublicExponent;
		s_RsaParams.Modulus = p_Blob.Modulus;
		
		//var s_Modulus = new BigInteger(s_Blob.Modulus, true, true);
		//s_RsaParams.Exponent = s_E.ToByteArray(true, true);
		//s_RsaParams.Modulus = s_Modulus.ToByteArray(true, true);

		if (p_Blob.HasPrivateKey)
		{
			s_RsaParams.P = p_Blob.Prime1;
			s_RsaParams.Q = p_Blob.Prime2;
			
			// RSA docs not good here. Do we need to calculate rest of the params?
			// if not check 
			// https://stackoverflow.com/questions/35242910/how-to-calculate-rsas-additional-private-key-parameters-from-p-and-q

			var s_E = new BigInteger(p_Blob.PublicExponent, true, true);
			var s_P = new BigInteger(p_Blob.Prime1, true, true);
			var s_Q = new BigInteger(p_Blob.Prime2, true, true);

			var s_PhiOfN = (s_P - BigInteger.One) * (s_Q - BigInteger.One);

			var s_D = ModInverse1(s_E, s_PhiOfN);

			var s_Dp = s_D % (s_P - BigInteger.One);
			var s_Dq = s_D % (s_Q - BigInteger.One);

			var s_QInv = ModInverse1(s_Q, s_P);
			
			//Console.WriteLine($"n: {new BigInteger(s_Blob.Modulus, true).ToString()}\n");
			//Console.WriteLine($"e: {s_E.ToString()}\n");
			//Console.WriteLine($"d: {s_D.ToString()}\n");
			//Console.WriteLine($"p: {s_P.ToString()}\n");
			//Console.WriteLine($"q: {s_Q.ToString()}\n");
			//Console.WriteLine($"dp: {s_Dp.ToString()}\n");
			//Console.WriteLine($"dq: {s_Dq.ToString()}\n");
			//Console.WriteLine($"qinv: {s_QInv.ToString()}\n");

			
			s_RsaParams.P = s_P.ToByteArray(true, true);
			s_RsaParams.Q = s_Q.ToByteArray(true, true);
			
			s_RsaParams.D = s_D.ToByteArray(true, true);
			s_RsaParams.DP = s_Dp.ToByteArray(true, true);
			s_RsaParams.DQ = s_Dq.ToByteArray(true, true);
			s_RsaParams.InverseQ = s_QInv.ToByteArray(true, true);
		}


		return s_RsaParams;
	}


	public static BCryptRsakeyBlob ToBCryptBlob(RSAParameters p_Parameters)
	{
		//TODO: a way to specify private and public key
		return new BCryptRsakeyBlob()
		{
			PublicExponent = p_Parameters.Exponent,
			Modulus = p_Parameters.Modulus,
			Prime1 = p_Parameters.P,
			Prime2 = p_Parameters.Q
		};
	}
	
	
	
	/// <summary>
	/// Calculates the modular multiplicative inverse of <paramref name="a"/> modulo <paramref name="m"/>
	/// using the extended Euclidean algorithm.
	/// </summary>
	/// <remarks>
	/// This implementation comes from the pseudocode defining the inverse(a, n) function at
	/// https://en.wikipedia.org/wiki/Extended_Euclidean_algorithm
	/// https://stackoverflow.com/questions/35242910/how-to-calculate-rsas-additional-private-key-parameters-from-p-and-q
	/// </remarks>
	private static BigInteger ModInverse1(BigInteger p_A, BigInteger p_N)
	{
		BigInteger s_T = BigInteger.Zero;
		BigInteger s_Nt = BigInteger.One;
		BigInteger s_R = p_N;
		BigInteger s_Nr = p_A;

		if (p_N < 0)
			p_N = -p_N;

		if (p_A < 0)
			p_A = p_N - (-p_A % p_N);

		while (s_Nr != 0)
		{
			var s_Quot = s_R / s_Nr;

			var s_Tmp = s_Nt; 
			s_Nt = s_T - s_Quot * s_Nt; 
			s_T = s_Tmp;
			s_Tmp = s_Nr; 
			s_Nr = s_R - s_Quot * s_Nr;
			s_R = s_Tmp;
		}

		if (s_R > 1) 
			throw new ArgumentException(nameof(p_A) + " is not convertible.");
		
		if (s_T < 0)
			s_T += p_N;
		return s_T;
	}

}