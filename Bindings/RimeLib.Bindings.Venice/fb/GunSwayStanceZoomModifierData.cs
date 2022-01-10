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
	public class GunSwayStanceZoomModifierData
	{
		[ContainerField(0)]
		public GunSwayDispersionModData DispersionMod { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float RecoilMagnitudeMod { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float RecoilAngleMod { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float LagYawMod { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float LagPitchMod { get; set; }
		
		public static void Deserialize(GunSwayStanceZoomModifierData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.GunSwayDispersionModData.Deserialize(p_Instance.DispersionMod, p_Reader, p_Parser);
			p_Instance.RecoilMagnitudeMod = p_Reader.ReadSingle();
			p_Instance.RecoilAngleMod = p_Reader.ReadSingle();
			p_Instance.LagYawMod = p_Reader.ReadSingle();
			p_Instance.LagPitchMod = p_Reader.ReadSingle();
		}
	}
}
