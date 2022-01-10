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
	[ContainerType(4, 32)]
	public class TurnEffectData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MaxRollAngle { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MaxPitchAngle { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float YawVelocityThreshhold { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float VelocityThreshhold { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float SafeTime { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float BeginTime { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float HoldTime { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float EndTime { get; set; }
		
		public static void Deserialize(TurnEffectData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaxRollAngle = p_Reader.ReadSingle();
			p_Instance.MaxPitchAngle = p_Reader.ReadSingle();
			p_Instance.YawVelocityThreshhold = p_Reader.ReadSingle();
			p_Instance.VelocityThreshhold = p_Reader.ReadSingle();
			p_Instance.SafeTime = p_Reader.ReadSingle();
			p_Instance.BeginTime = p_Reader.ReadSingle();
			p_Instance.HoldTime = p_Reader.ReadSingle();
			p_Instance.EndTime = p_Reader.ReadSingle();
		}
	}
}
