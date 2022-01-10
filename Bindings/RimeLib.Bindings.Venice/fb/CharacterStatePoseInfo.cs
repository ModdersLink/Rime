///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 48)]
	public class CharacterStatePoseInfo : 
		DataContainer
	{
		[ContainerField(8)]
		public CharacterPoseType PoseType { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public float Velocity { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float AccelerationGain { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float DecelerationGain { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float SprintGain { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float SprintMultiplier { get; set; }

		[ContainerField(32)]
		public SpeedModifierData SpeedModifier { get; set; } = new();

		public static void Deserialize(CharacterStatePoseInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PoseType = (CharacterPoseType) p_Reader.ReadInt32();
			p_Instance.Velocity = p_Reader.ReadSingle();
			p_Instance.AccelerationGain = p_Reader.ReadSingle();
			p_Instance.DecelerationGain = p_Reader.ReadSingle();
			p_Instance.SprintGain = p_Reader.ReadSingle();
			p_Instance.SprintMultiplier = p_Reader.ReadSingle();
			fb.SpeedModifierData.Deserialize(p_Instance.SpeedModifier, p_Reader, p_Parser);
		}

	}
}
