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
using fb.Entity;

namespace fb.Audio;

[ContainerType(16, 112)]
public class SoundEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<SoundAsset> Sound { get; set; } = new();
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public LinearTransform Transform { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public bool PlayOnCreation { get; set; } = false;
	
	[ContainerField(0x61), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
	public bool EnableOnCreation { get; set; } = true;
	
	[ContainerField(0x62), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
	public bool UseParentTransform { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Sound));
		p_Writer.WriteNullBytes(4);
		Transform.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(PlayOnCreation);
		p_Writer.Write(EnableOnCreation);
		p_Writer.Write(UseParentTransform);
		p_Writer.WriteNullBytes(13);
	}
}

