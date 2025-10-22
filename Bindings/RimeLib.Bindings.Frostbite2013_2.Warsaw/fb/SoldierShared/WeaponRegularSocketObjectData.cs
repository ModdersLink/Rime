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

namespace fb.SoldierShared;

[ContainerType(16, 128)]
public class WeaponRegularSocketObjectData
	: fb.SoldierShared.WeaponSocketObjectData
{
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<LinearTransform> Mesh3pTransforms { get; set; } = new();
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
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
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Mesh3pTransforms = p_EbxWriter.GetArrayWriter(Mesh3pTransforms.GetType(), Mesh3pTransforms.Count);
		p_Writer.Write(s_Mesh3pTransforms.ArrayIndex);
		foreach (var s_Entry in Mesh3pTransforms)
		{
			s_Entry.Serialize(s_Mesh3pTransforms.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(12);
		Transform.Serialize(p_Writer, p_EbxWriter);
	}
}

