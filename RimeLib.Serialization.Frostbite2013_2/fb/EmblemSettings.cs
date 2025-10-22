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

[ContainerType(8, 56)]
public class EmblemSettings
	: fb.Core.SystemSettings
{
	public EmblemSettings()
	{
		//SystemSettings
		Name = @"Emblems";
	}
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public PlatformScalableInt EmblemSize { get; set; } = new()
	{
		Gen4b = 256,
		Gen4a = 256,
		Ps3 = 128,
		Xenon = 128,
		Default = 256,
	};
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool Enable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		EmblemSize.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Enable);
		p_Writer.WriteNullBytes(3);
	}
}

