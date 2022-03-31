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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 112)]
	public class AnimationTurretRotationComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public List<TurretRotationInfo> Rotations { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public int SoldierBaseIndex { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public bool UseVehicleWorldTransform { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		public bool OutputWorldTransform { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Rotations = p_EbxWriter.GetArrayWriter(Rotations.GetType(), Rotations.Count);
			p_Writer.Write(s_Rotations.ArrayIndex);
			foreach (var s_Entry in Rotations)
			{
				s_Entry.Serialize(s_Rotations.Writer, p_EbxWriter);
			}
			p_Writer.Write(SoldierBaseIndex);
			p_Writer.Write(UseVehicleWorldTransform);
			p_Writer.Write(OutputWorldTransform);
			p_Writer.WriteNullBytes(6);
		}
	}
}
