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
	[ContainerType(16, 80)]
	public class SampleTextureData : 
		EvaluatorData
	{
		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 TextureDimensions { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ColorIntensityMax { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ColorIntensityMin { get; set; } = new();

		[ContainerField(64)]
		public List<Vec4> GradientData { get; set; } = new();

		[ContainerField(68), LayoutImmutable, Blittable]
		public float TextureOriginU { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float TextureOriginV { get; set; }

		public static void Deserialize(SampleTextureData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec2.Deserialize(p_Instance.TextureDimensions, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.ColorIntensityMax, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.ColorIntensityMin, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.GradientData.Clear();
			(RimeReader Reader, uint Count) s_GradientData = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_GradientData.Count; ++i)
			{
				var s_Value = new Vec4();
				fb.Vec4.Deserialize(s_Value, s_GradientData.Reader, p_Parser);
				p_Instance.GradientData.Add(s_Value);
			}
			
			s_GradientData.Reader.Dispose();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.TextureOriginU = p_Reader.ReadSingle();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.TextureOriginV = p_Reader.ReadSingle();
			p_Reader.Seek(16, SeekOrigin.Current);
		}

	}
}
