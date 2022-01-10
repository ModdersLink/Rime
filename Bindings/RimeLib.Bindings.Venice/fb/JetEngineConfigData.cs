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
	[ContainerType(16, 128)]
	public class JetEngineConfigData : 
		EngineConfigData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 PowerFadeOutRange { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public float ForceMagnitudeMultiplier { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float AngleInputYMultiplier { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float AngleInputPitchMultiplier { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float MaxVelocity { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public uint DirectionVectorIndex { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool IsWaterJetEngine { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool IsTurnable { get; set; }

		public static void Deserialize(JetEngineConfigData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec2.Deserialize(p_Instance.PowerFadeOutRange, p_Reader, p_Parser);
			p_Instance.ForceMagnitudeMultiplier = p_Reader.ReadSingle();
			p_Instance.AngleInputYMultiplier = p_Reader.ReadSingle();
			p_Instance.AngleInputPitchMultiplier = p_Reader.ReadSingle();
			p_Instance.MaxVelocity = p_Reader.ReadSingle();
			p_Instance.DirectionVectorIndex = p_Reader.ReadUInt32();
			p_Instance.IsWaterJetEngine = p_Reader.ReadBool();
			p_Instance.IsTurnable = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
