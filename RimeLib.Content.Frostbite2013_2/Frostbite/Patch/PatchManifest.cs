using System.Diagnostics.CodeAnalysis;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;


namespace RimeLib.Content.Frostbite2013_2.Frostbite.Patch;

public class PatchManifest  : IFbSerializable
{
	public uint Version { get; set; }
	public uint Flags { get; set; }
	public uint ManifestPatchSize { get; set; }
	public uint EntryPatchSize { get; set; }
	

	public PatchManifest()
	{

	}

	public PatchManifest(RimeReader p_Reader)
	{
		Deserialize(p_Reader);
	}

	public void Deserialize(RimeReader p_Reader)
	{
		var s_LastEndianess = p_Reader.Endianness;
		p_Reader.Endianness = Endianness.BigEndian;
		
		Version = p_Reader.ReadUInt32();
		Flags = p_Reader.ReadUInt32();
		ManifestPatchSize = p_Reader.ReadUInt32();
		EntryPatchSize = p_Reader.ReadUInt32();

		p_Reader.Endianness = s_LastEndianess;
	}

	public bool Serialize(RimeWriter p_Writer)
	{
		var s_LastEndianess = p_Writer.Endianness;
		p_Writer.Endianness = Endianness.BigEndian;
		
		p_Writer.Write(Version);
		p_Writer.Write(Flags);
		p_Writer.Write(ManifestPatchSize);
		p_Writer.Write(EntryPatchSize);
		
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