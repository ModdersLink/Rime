using System.Diagnostics.CodeAnalysis;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;


namespace RimeLib.Content.Frostbite2013_2.Frostbite.Patch;

public class PatchManifestOperation : IFbSerializable
{
	public uint OperationLength { get; set; }
	public PatchManifestOpType OperationOpType { get; set; }
	

	public PatchManifestOperation()
	{

	}

	public PatchManifestOperation(RimeReader p_Reader)
	{
		Deserialize(p_Reader);
	}

	public override string ToString()
	{
		return $"ManifestOp {OperationOpType} - 0x{OperationLength:x4}";
	}

	public void Deserialize(RimeReader p_Reader)
	{
		var s_LastEndianess = p_Reader.Endianness;
		p_Reader.Endianness = Endianness.BigEndian;
		
		var s_OpTypeSize = p_Reader.ReadUInt32();

		p_Reader.Endianness = s_LastEndianess;

		OperationLength = s_OpTypeSize & 0x3FFFFFFF;
		OperationOpType = (PatchManifestOpType)(s_OpTypeSize >> 30);
	}

	public bool Serialize(RimeWriter p_Writer)
	{
		uint s_OpTypeSize = 0;

		s_OpTypeSize |= (OperationLength & 0x3FFFFFFF);
		s_OpTypeSize |= ((uint)OperationOpType << 30);
		
		
		var s_LastEndianess = p_Writer.Endianness;
		p_Writer.Endianness = Endianness.BigEndian;
		
		p_Writer.Write(s_OpTypeSize);
		
		p_Writer.Endianness = s_LastEndianess;

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