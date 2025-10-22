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

namespace fb.Venice;

[ContainerType(16, 112)]
public class SharedDataEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float FloatInput { get; set; } = 0.000f;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public LinearTransform TransformInput { get; set; } = new()
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
	public int IntInput { get; set; } = 0;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public bool BoolInput { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FloatInput);
		p_Writer.WriteNullBytes(4);
		TransformInput.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(IntInput);
		p_Writer.Write(BoolInput);
		p_Writer.WriteNullBytes(11);
	}
}

