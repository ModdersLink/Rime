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
	[ContainerType(16, 64)]
	public class SkyCloudLayer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Color { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float TileFactor { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Rotation { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Altitude { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float Speed { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float SunLightPower { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float AmbientLightIntensity { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float SunLightIntensity { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float AlphaMul { get; set; }
		
		[ContainerField(48)]
		public CtrRef<TextureAsset> Texture { get; set; } = new();
		
		public static void Deserialize(SkyCloudLayer p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.Color, p_Reader, p_Parser);
			p_Instance.TileFactor = p_Reader.ReadSingle();
			p_Instance.Rotation = p_Reader.ReadSingle();
			p_Instance.Altitude = p_Reader.ReadSingle();
			p_Instance.Speed = p_Reader.ReadSingle();
			p_Instance.SunLightPower = p_Reader.ReadSingle();
			p_Instance.AmbientLightIntensity = p_Reader.ReadSingle();
			p_Instance.SunLightIntensity = p_Reader.ReadSingle();
			p_Instance.AlphaMul = p_Reader.ReadSingle();
			p_Instance.Texture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(12, SeekOrigin.Current);
		}
	}
}
