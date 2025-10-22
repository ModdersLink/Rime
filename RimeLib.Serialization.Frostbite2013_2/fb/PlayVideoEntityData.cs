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
using fb.Movie;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 56)]
public class PlayVideoEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<MovieTextureAsset> Movie { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string NetworkStreamingUrl { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string VideoIdentifier { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool KeepBlackScreen { get; set; } = false;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool AllowSkip { get; set; } = true;
	
	[ContainerField(0x32), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
	public bool DrawInWidget { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Movie));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(NetworkStreamingUrl));
		p_Writer.Write(p_EbxWriter.WriteString(VideoIdentifier));
		p_Writer.Write(KeepBlackScreen);
		p_Writer.Write(AllowSkip);
		p_Writer.Write(DrawInWidget);
		p_Writer.WriteNullBytes(5);
	}
}

