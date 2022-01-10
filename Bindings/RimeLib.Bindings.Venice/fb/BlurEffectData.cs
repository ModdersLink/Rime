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
	public class BlurEffectData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float DispersionStrength { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float DispersionThreshhold { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float ExplosionStrength { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float BulletStrength { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ExplosionFalloffSpeed { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float BulletFalloffSpeed { get; set; }
		
		public static void Deserialize(BlurEffectData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DispersionStrength = p_Reader.ReadSingle();
			p_Instance.DispersionThreshhold = p_Reader.ReadSingle();
			p_Instance.ExplosionStrength = p_Reader.ReadSingle();
			p_Instance.BulletStrength = p_Reader.ReadSingle();
			p_Instance.ExplosionFalloffSpeed = p_Reader.ReadSingle();
			p_Instance.BulletFalloffSpeed = p_Reader.ReadSingle();
		}
	}
}
