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
	[ContainerType(16, 448)]
	public partial class SunFlareEffectState :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec4 _Element5AlphaScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec4 _Element5AlphaOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec4 _Element2SizeScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private Vec4 _Element5SizeScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private Vec4 _Element2AlphaOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec4 _Element2AlphaScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec2 _Element1Size = new();

		[ObservableProperty]
		[property: ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private Vec4 _Element1SizeOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private Vec4 _Element1SizeScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private Vec4 _Element1AlphaOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(176), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private Vec4 _Element1AlphaScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(192), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private Vec4 _Element5SizeOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(208), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private Vec4 _Element4SizeScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(224), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private Vec2 _Element3Size = new();

		[ObservableProperty]
		[property: ContainerField(232), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		private Vec2 _Element2Size = new();

		[ObservableProperty]
		[property: ContainerField(240), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private Vec4 _Element2SizeOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(256), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		private Vec4 _Element4AlphaScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(272), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		private Vec4 _Element3SizeOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(288), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 288)]
		private Vec2 _Element4Size = new();

		[ObservableProperty]
		[property: ContainerField(296), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 296)]
		private Vec2 _Element5Size = new();

		[ObservableProperty]
		[property: ContainerField(304), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		private Vec4 _Element3SizeScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(320), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		private Vec4 _Element3AlphaOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(336), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		private Vec4 _Element4SizeOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(352), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		private Vec4 _Element3AlphaScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(368), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 368)]
		private Vec4 _Element4AlphaOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(384), JsonProperty(Order = 384)]
		private CtrRef<SurfaceShaderBaseAsset> _Element3Shader = new();

		[ObservableProperty]
		[property: ContainerField(388), JsonProperty(Order = 388)]
		private CtrRef<SurfaceShaderBaseAsset> _Element2Shader = new();

		[ObservableProperty]
		[property: ContainerField(392), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
		private float _OccluderSize;

		[ObservableProperty]
		[property: ContainerField(396), JsonProperty(Order = 396)]
		private CtrRef<SurfaceShaderBaseAsset> _Element4Shader = new();

		[ObservableProperty]
		[property: ContainerField(400), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
		private float _Element4RayDistance;

		[ObservableProperty]
		[property: ContainerField(404), JsonProperty(Order = 404)]
		private CtrRef<SurfaceShaderBaseAsset> _Element1Shader = new();

		[ObservableProperty]
		[property: ContainerField(408), LayoutImmutable, Blittable, JsonProperty(Order = 408)]
		private float _Element2RayDistance;

		[ObservableProperty]
		[property: ContainerField(412), LayoutImmutable, Blittable, JsonProperty(Order = 412)]
		private float _Element1RayDistance;

		[ObservableProperty]
		[property: ContainerField(416), LayoutImmutable, Blittable, JsonProperty(Order = 416)]
		private float _Element5RayDistance;

		[ObservableProperty]
		[property: ContainerField(420), LayoutImmutable, Blittable, JsonProperty(Order = 420)]
		private float _Element3RayDistance;

		[ObservableProperty]
		[property: ContainerField(424), JsonProperty(Order = 424)]
		private CtrRef<SurfaceShaderBaseAsset> _Element5Shader = new();

		[ObservableProperty]
		[property: ContainerField(428), LayoutImmutable, Blittable, JsonProperty(Order = 428)]
		private bool _Element5Enable;

		[ObservableProperty]
		[property: ContainerField(429), LayoutImmutable, Blittable, JsonProperty(Order = 429)]
		private bool _Element4Enable;

		[ObservableProperty]
		[property: ContainerField(430), LayoutImmutable, Blittable, JsonProperty(Order = 430)]
		private bool _Element3Enable;

		[ObservableProperty]
		[property: ContainerField(431), LayoutImmutable, Blittable, JsonProperty(Order = 431)]
		private bool _Element2Enable;

		[ObservableProperty]
		[property: ContainerField(432), LayoutImmutable, Blittable, JsonProperty(Order = 432)]
		private bool _Element1Enable;

		[ObservableProperty]
		[property: ContainerField(433), LayoutImmutable, Blittable, JsonProperty(Order = 433)]
		private bool _DebugDrawOccluder;

		[ObservableProperty]
		[property: ContainerField(434), LayoutImmutable, Blittable, JsonProperty(Order = 434)]
		private bool _Enable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
			Element5AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element5AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element2SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element5SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element2AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element2AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element1Size.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			Element1SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element1SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element1AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element1AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element5SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element4SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element3Size.Serialize(p_Writer, p_EbxWriter);
			Element2Size.Serialize(p_Writer, p_EbxWriter);
			Element2SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element4AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element3SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element4Size.Serialize(p_Writer, p_EbxWriter);
			Element5Size.Serialize(p_Writer, p_EbxWriter);
			Element3SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element3AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element4SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element3AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element4AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Element3Shader));
			p_Writer.Write(p_EbxWriter.WriteImport(Element2Shader));
			p_Writer.Write(OccluderSize);
			p_Writer.Write(p_EbxWriter.WriteImport(Element4Shader));
			p_Writer.Write(Element4RayDistance);
			p_Writer.Write(p_EbxWriter.WriteImport(Element1Shader));
			p_Writer.Write(Element2RayDistance);
			p_Writer.Write(Element1RayDistance);
			p_Writer.Write(Element5RayDistance);
			p_Writer.Write(Element3RayDistance);
			p_Writer.Write(p_EbxWriter.WriteImport(Element5Shader));
			p_Writer.Write(Element5Enable);
			p_Writer.Write(Element4Enable);
			p_Writer.Write(Element3Enable);
			p_Writer.Write(Element2Enable);
			p_Writer.Write(Element1Enable);
			p_Writer.Write(DebugDrawOccluder);
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(13);
		}
	}
}
