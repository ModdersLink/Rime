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
	[ContainerType(4, 24)]
	public class GunSwayRecoilData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float RecoilAmplitudeMax { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float RecoilAmplitudeIncPerShot { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float HorizontalRecoilAmplitudeIncPerShotMin { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float HorizontalRecoilAmplitudeIncPerShotMax { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float HorizontalRecoilAmplitudeMax { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float RecoilAmplitudeDecreaseFactor { get; set; }
		
		public static void Deserialize(GunSwayRecoilData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RecoilAmplitudeMax = p_Reader.ReadSingle();
			p_Instance.RecoilAmplitudeIncPerShot = p_Reader.ReadSingle();
			p_Instance.HorizontalRecoilAmplitudeIncPerShotMin = p_Reader.ReadSingle();
			p_Instance.HorizontalRecoilAmplitudeIncPerShotMax = p_Reader.ReadSingle();
			p_Instance.HorizontalRecoilAmplitudeMax = p_Reader.ReadSingle();
			p_Instance.RecoilAmplitudeDecreaseFactor = p_Reader.ReadSingle();
		}
	}
}
