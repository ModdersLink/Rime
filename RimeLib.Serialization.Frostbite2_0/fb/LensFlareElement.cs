///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 160)]
	public class LensFlareElement :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec4 SizeCamDistCurve { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec4 SizeAngleCurve { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec2 Size { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec4 SizeOccluderCurve { get; set; } = new();
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public Vec4 SizeScreenPosCurve { get; set; } = new();
		
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public Vec4 AlphaCamDistCurve { get; set; } = new();
		
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec4 AlphaOccluderCurve { get; set; } = new();
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec4 AlphaAngleCurve { get; set; } = new();
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public Vec4 AlphaScreenPosCurve { get; set; } = new();
		
		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float SizeCamDistMax { get; set; }
		
		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float RayDistance { get; set; }
		
		[ContainerField(152), JsonProperty(Order = 152)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();
		
		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float AlphaCamDistMax { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			SizeCamDistCurve.Serialize(p_Writer, p_EbxWriter);
			SizeAngleCurve.Serialize(p_Writer, p_EbxWriter);
			Size.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			AlphaCamDistCurve.Serialize(p_Writer, p_EbxWriter);
			AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			AlphaAngleCurve.Serialize(p_Writer, p_EbxWriter);
			AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SizeCamDistMax);
			p_Writer.Write(RayDistance);
			p_Writer.Write(p_EbxWriter.WriteImport(Shader));
			p_Writer.Write(AlphaCamDistMax);
		}
	}
}
