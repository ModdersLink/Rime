using System.Diagnostics.CodeAnalysis;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2014_4.Frostbite.ServerPatch;


public class PatchData  : IFbSerializable
{
	public PatchedBundle[] Bundles = Array.Empty<PatchedBundle>(); 

	public PatchData()
	{

	}

	public PatchData(RimeReader p_Reader)
	{
		Deserialize(p_Reader);
	}
	
	public void Deserialize(RimeReader p_Reader)
	{
		var s_NumBundles = p_Reader.Read7Bit();
		var s_NumEntries = p_Reader.Read7Bit();
		var s_PayloadSize = p_Reader.Read7Bit();

		Bundles = new PatchedBundle[s_NumBundles];
		
		var s_EntryIndex = 0;
		for (var i = 0; i < s_NumBundles; i++)
		{
			var s_Bundle = new PatchedBundle(p_Reader, s_EntryIndex);

			s_EntryIndex += (int) s_Bundle.NumEntries;
		}


		var s_Entries = new PatchEntry[s_NumEntries];
		for (var i = 0; i < s_NumEntries; i++)
			s_Entries[i] = new PatchEntry(p_Reader);

		var s_PayloadData = p_Reader.ReadBytes((int)s_PayloadSize);

		using var s_PayloadReader = new RimeReader(new MemoryStream(s_PayloadData));
		
		foreach (var s_Bundle in Bundles)
		{
			for (var i = 0; i < s_Bundle.NumEntries; i++)
			{
				var s_Entry = s_Entries[s_Bundle.FirstEntryIndex + i];

				s_PayloadReader.Seek(s_Entry.PayloadOffset, SeekOrigin.Begin);

				var s_Payload = new PatchPayload(s_PayloadReader);
				
				
			}
		}
	}

	public bool Serialize(RimeWriter p_Writer)
	{
		throw new NotImplementedException();
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