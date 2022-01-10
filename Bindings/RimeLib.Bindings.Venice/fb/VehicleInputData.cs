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
	[ContainerType(4, 80)]
	public class VehicleInputData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float ThrottleDeadzone { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float BrakeDeadzone { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float YawDeadzone { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float PitchDeadzone { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float RollDeadzone { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float ThrottleInertiaOutDuration { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float ThrottleInertiaInDuration { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ThrottleInertiaMinRatio { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float BrakeInertiaOutDuration { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float BrakeInertiaInDuration { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float BrakeInertiaMinRatio { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float YawInertiaOutDuration { get; set; }
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float YawInertiaInDuration { get; set; }
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float YawInertiaMinRatio { get; set; }
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float PitchInertiaOutDuration { get; set; }
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float PitchInertiaInDuration { get; set; }
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float PitchInertiaMinRatio { get; set; }
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float RollInertiaOutDuration { get; set; }
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float RollInertiaInDuration { get; set; }
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float RollInertiaMinRatio { get; set; }
		
		public static void Deserialize(VehicleInputData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ThrottleDeadzone = p_Reader.ReadSingle();
			p_Instance.BrakeDeadzone = p_Reader.ReadSingle();
			p_Instance.YawDeadzone = p_Reader.ReadSingle();
			p_Instance.PitchDeadzone = p_Reader.ReadSingle();
			p_Instance.RollDeadzone = p_Reader.ReadSingle();
			p_Instance.ThrottleInertiaOutDuration = p_Reader.ReadSingle();
			p_Instance.ThrottleInertiaInDuration = p_Reader.ReadSingle();
			p_Instance.ThrottleInertiaMinRatio = p_Reader.ReadSingle();
			p_Instance.BrakeInertiaOutDuration = p_Reader.ReadSingle();
			p_Instance.BrakeInertiaInDuration = p_Reader.ReadSingle();
			p_Instance.BrakeInertiaMinRatio = p_Reader.ReadSingle();
			p_Instance.YawInertiaOutDuration = p_Reader.ReadSingle();
			p_Instance.YawInertiaInDuration = p_Reader.ReadSingle();
			p_Instance.YawInertiaMinRatio = p_Reader.ReadSingle();
			p_Instance.PitchInertiaOutDuration = p_Reader.ReadSingle();
			p_Instance.PitchInertiaInDuration = p_Reader.ReadSingle();
			p_Instance.PitchInertiaMinRatio = p_Reader.ReadSingle();
			p_Instance.RollInertiaOutDuration = p_Reader.ReadSingle();
			p_Instance.RollInertiaInDuration = p_Reader.ReadSingle();
			p_Instance.RollInertiaMinRatio = p_Reader.ReadSingle();
		}
	}
}
