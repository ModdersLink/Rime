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

namespace fb.Render;

[ContainerType(16, 128)]
public class SkinnedMeshAsset
	: fb.Render.MeshAsset
{
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec3 BoundingBoxPositionOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 BoundingBoxSizeOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		BoundingBoxPositionOffset.Serialize(p_Writer, p_EbxWriter);
		BoundingBoxSizeOffset.Serialize(p_Writer, p_EbxWriter);
	}
}

