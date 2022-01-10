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
	[ContainerType(4, 68)]
	public class SoldierWeaponDispersion
	{
		[ContainerField(0)]
		public FiringDispersionData StandDispersion { get; set; } = new();
		
		[ContainerField(16)]
		public FiringDispersionData CrouchDispersion { get; set; } = new();
		
		[ContainerField(32)]
		public FiringDispersionData ProneDispersion { get; set; } = new();
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float JumpDispersionAngle { get; set; }
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float ProneTransitionDispersionAngle { get; set; }
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float MoveDispersionAngle { get; set; }
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float MoveZoomedDispersionAngle { get; set; }
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float DecreasePerSecond { get; set; }
		
		public static void Deserialize(SoldierWeaponDispersion p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.FiringDispersionData.Deserialize(p_Instance.StandDispersion, p_Reader, p_Parser);
			fb.FiringDispersionData.Deserialize(p_Instance.CrouchDispersion, p_Reader, p_Parser);
			fb.FiringDispersionData.Deserialize(p_Instance.ProneDispersion, p_Reader, p_Parser);
			p_Instance.JumpDispersionAngle = p_Reader.ReadSingle();
			p_Instance.ProneTransitionDispersionAngle = p_Reader.ReadSingle();
			p_Instance.MoveDispersionAngle = p_Reader.ReadSingle();
			p_Instance.MoveZoomedDispersionAngle = p_Reader.ReadSingle();
			p_Instance.DecreasePerSecond = p_Reader.ReadSingle();
		}
	}
}
