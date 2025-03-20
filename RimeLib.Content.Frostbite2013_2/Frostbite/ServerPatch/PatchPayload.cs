using System.Diagnostics.CodeAnalysis;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2013_2.Frostbite.ServerPatch;

public class PatchPayload : IFbSerializable
{

	public PatchPayload()
	{
	}

	public PatchPayload(RimeReader p_Reader)
	{
		Deserialize(p_Reader);
	}
	
	public void Deserialize(RimeReader p_Reader)
	{
		var s_OutSize = p_Reader.Read7Bit();

		var s_RepeatCount = p_Reader.Read7Bit();

		for (var i = 0; i < s_RepeatCount; i++)
		{
			var s_SourceOffset = p_Reader.Read7Bit();
			var s_TargetOffset = p_Reader.Read7Bit(); // this is signed somehow

			var s_RepeatSize = p_Reader.Read7Bit();
			
			// memcpy(pData + s_SourceOffset + s_TargetOffset, pData + s_SourceOffset, s_RepeatSize);
		}


		var s_PatchCount = p_Reader.Read7Bit();
		for (var i = 0; i < s_PatchCount; i++)
		{
			var s_TargetOffset = p_Reader.Read7Bit(); // this is signed somehow
			var s_PatchSize = p_Reader.Read7Bit();

			var s_PatchData = p_Reader.ReadBytes((int)s_PatchSize);
			
			// memcpy(pData + s_TargetOffset, s_PatchData, s_PatchSize);
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