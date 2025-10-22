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
using fb.GameShared;
using fb.Entity;

namespace fb.SpartaShared;

[ContainerType(16, 240)]
public class SpartaVideoElementEntityData
	: fb.GameShared.UIElementEntityData
{
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public string VideoIdentifier { get; set; } = string.Empty;
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public CtrRef<MovieTextureAsset> Movie { get; set; } = new();
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public string NetworkStreamingUrl { get; set; } = string.Empty;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public bool Loop { get; set; } = false;
	
	[ContainerField(0xe9), LayoutImmutable, Blittable, JsonProperty(Order = 233)]
	public bool KeepBlackScreen { get; set; } = false;
	
	[ContainerField(0xea), LayoutImmutable, Blittable, JsonProperty(Order = 234)]
	public bool KeepAspectRatio { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(VideoIdentifier));
		p_Writer.Write(p_EbxWriter.WriteImport(Movie));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(NetworkStreamingUrl));
		p_Writer.Write(Loop);
		p_Writer.Write(KeepBlackScreen);
		p_Writer.Write(KeepAspectRatio);
		p_Writer.WriteNullBytes(5);
	}
}

