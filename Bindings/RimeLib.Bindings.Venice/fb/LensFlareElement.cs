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
	[ContainerType(16, 160)]
	public class LensFlareElement
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SizeCamDistCurve { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SizeAngleCurve { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Size { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SizeOccluderCurve { get; set; } = new();
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SizeScreenPosCurve { get; set; } = new();
		
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 AlphaCamDistCurve { get; set; } = new();
		
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 AlphaOccluderCurve { get; set; } = new();
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 AlphaAngleCurve { get; set; } = new();
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 AlphaScreenPosCurve { get; set; } = new();
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float SizeCamDistMax { get; set; }
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float RayDistance { get; set; }
		
		[ContainerField(152)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float AlphaCamDistMax { get; set; }
		
		public static void Deserialize(LensFlareElement p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.SizeCamDistCurve, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.SizeAngleCurve, p_Reader, p_Parser);
			fb.Vec2.Deserialize(p_Instance.Size, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.SizeOccluderCurve, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.SizeScreenPosCurve, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.AlphaCamDistCurve, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.AlphaOccluderCurve, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.AlphaAngleCurve, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.AlphaScreenPosCurve, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.SizeCamDistMax = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.RayDistance = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Shader.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.AlphaCamDistMax = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
		}
	}
}
