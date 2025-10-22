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

namespace fb.GameShared;

[ContainerType(16, 128)]
public class AnimationTurretRotationComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public List<TurretRotationInfo> Rotations { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public int SoldierBaseIndex { get; set; } = 0;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public bool UseVehicleWorldTransform { get; set; } = false;
	
	[ContainerField(0x7d), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
	public bool OutputWorldTransform { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Rotations = p_EbxWriter.GetArrayWriter(Rotations.GetType(), Rotations.Count);
		p_Writer.Write(s_Rotations.ArrayIndex);
		foreach (var s_Entry in Rotations)
		{
			s_Entry.Serialize(s_Rotations.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SoldierBaseIndex);
		p_Writer.Write(UseVehicleWorldTransform);
		p_Writer.Write(OutputWorldTransform);
		p_Writer.WriteNullBytes(2);
	}
}

