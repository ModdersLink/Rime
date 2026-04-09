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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 160)]
	public partial class LensFlareElement :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private Vec4 _SizeCamDistCurve = new();
		
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec4 _SizeAngleCurve = new();
		
		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec2 _Size = new();
		
		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec4 _SizeOccluderCurve = new();
		
		[ObservableProperty]
		[property: ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private Vec4 _SizeScreenPosCurve = new();
		
		[ObservableProperty]
		[property: ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private Vec4 _AlphaCamDistCurve = new();
		
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec4 _AlphaOccluderCurve = new();
		
		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec4 _AlphaAngleCurve = new();
		
		[ObservableProperty]
		[property: ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private Vec4 _AlphaScreenPosCurve = new();
		
		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _SizeCamDistMax;
		
		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _RayDistance;
		
		[ObservableProperty]
		[property: ContainerField(152), JsonProperty(Order = 152)]
		private CtrRef<SurfaceShaderBaseAsset> _Shader = new();
		
		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _AlphaCamDistMax;
		
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
