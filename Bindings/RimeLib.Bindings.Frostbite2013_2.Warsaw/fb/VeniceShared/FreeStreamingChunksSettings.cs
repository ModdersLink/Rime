///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;

using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 64)]
public class FreeStreamingChunksSettings
	: fb.Core.SystemSettings
{
	public FreeStreamingChunksSettings()
	{
		//SystemSettings
		Name = @"FreeStreamingChunks";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int DefaultLoadMask { get; set; } = 0;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<string> SuperBundles { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<FreeStreamingChunksLoadInfo> ChunkSuperBundles { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<int> LoadMasks { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DefaultLoadMask);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_SuperBundles = p_EbxWriter.GetArrayWriter(SuperBundles.GetType(), SuperBundles.Count);
		p_Writer.Write(s_SuperBundles.ArrayIndex);
		foreach (var s_Entry in SuperBundles)
		{
			s_SuperBundles.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ChunkSuperBundles = p_EbxWriter.GetArrayWriter(ChunkSuperBundles.GetType(), ChunkSuperBundles.Count);
		p_Writer.Write(s_ChunkSuperBundles.ArrayIndex);
		foreach (var s_Entry in ChunkSuperBundles)
		{
			s_Entry.Serialize(s_ChunkSuperBundles.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LoadMasks = p_EbxWriter.GetArrayWriter(LoadMasks.GetType(), LoadMasks.Count);
		p_Writer.Write(s_LoadMasks.ArrayIndex);
		foreach (var s_Entry in LoadMasks)
		{
			s_LoadMasks.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
	}
}

