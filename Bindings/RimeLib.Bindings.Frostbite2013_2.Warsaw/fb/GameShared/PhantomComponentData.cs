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

using fb.Ant;
using fb.Core;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 192)]
public class PhantomComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 BoxSize { get; set; } = new()
	{
		z = 2.000f,
		y = 2.000f,
		x = 2.000f,
	};
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public AntRef AsyncQueryPointerAsset { get; set; } = new();
	
	[ContainerField(0x94), JsonProperty(Order = 148)]
	public AntRef EnableTrajectoryOverride { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public AntRef TrajectoryOverride { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		BoxSize.Serialize(p_Writer, p_EbxWriter);
		AsyncQueryPointerAsset.Serialize(p_Writer, p_EbxWriter);
		EnableTrajectoryOverride.Serialize(p_Writer, p_EbxWriter);
		TrajectoryOverride.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
	}
}

