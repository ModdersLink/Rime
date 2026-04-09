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
	[ContainerType(16, 544)]
	public partial class SunFlareComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec4 _Element5AlphaScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec4 _Element5AlphaOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private Vec4 _Element5SizeScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private Vec4 _Element2SizeOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private Vec4 _Element5SizeOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(176), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private Vec4 _Element2AlphaOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(192), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private Vec4 _Element2AlphaScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(208), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private Vec2 _Element1Size = new();

		[ObservableProperty]
		[property: ContainerField(224), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private Vec4 _Element1SizeOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(240), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private Vec4 _Element1SizeScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(256), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		private Vec4 _Element1AlphaOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(272), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		private Vec4 _Element1AlphaScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(288), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 288)]
		private Vec2 _Element5Size = new();

		[ObservableProperty]
		[property: ContainerField(304), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		private Vec4 _Element4SizeOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(320), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		private Vec2 _Element3Size = new();

		[ObservableProperty]
		[property: ContainerField(328), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		private Vec2 _Element2Size = new();

		[ObservableProperty]
		[property: ContainerField(336), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		private Vec4 _Element4AlphaScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(352), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		private Vec4 _Element2SizeScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(368), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 368)]
		private Vec4 _Element4SizeScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(384), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 384)]
		private Vec2 _Element4Size = new();

		[ObservableProperty]
		[property: ContainerField(400), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 400)]
		private Vec4 _Element3AlphaScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(416), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 416)]
		private Vec4 _Element4AlphaOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(432), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 432)]
		private Vec4 _Element3SizeOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(448), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 448)]
		private Vec4 _Element3SizeScreenPosCurve = new();

		[ObservableProperty]
		[property: ContainerField(464), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 464)]
		private Vec4 _Element3AlphaOccluderCurve = new();

		[ObservableProperty]
		[property: ContainerField(480), JsonProperty(Order = 480)]
		private CtrRef<SurfaceShaderBaseAsset> _Element1Shader = new();

		[ObservableProperty]
		[property: ContainerField(484), LayoutImmutable, Blittable, JsonProperty(Order = 484)]
		private float _OccluderSize;

		[ObservableProperty]
		[property: ContainerField(488), JsonProperty(Order = 488)]
		private CtrRef<SurfaceShaderBaseAsset> _Element2Shader = new();

		[ObservableProperty]
		[property: ContainerField(492), LayoutImmutable, Blittable, JsonProperty(Order = 492)]
		private float _Element3RayDistance;

		[ObservableProperty]
		[property: ContainerField(496), JsonProperty(Order = 496)]
		private CtrRef<SurfaceShaderBaseAsset> _Element4Shader = new();

		[ObservableProperty]
		[property: ContainerField(500), LayoutImmutable, Blittable, JsonProperty(Order = 500)]
		private float _Element4RayDistance;

		[ObservableProperty]
		[property: ContainerField(504), LayoutImmutable, Blittable, JsonProperty(Order = 504)]
		private float _Element2RayDistance;

		[ObservableProperty]
		[property: ContainerField(508), LayoutImmutable, Blittable, JsonProperty(Order = 508)]
		private float _Element1RayDistance;

		[ObservableProperty]
		[property: ContainerField(512), LayoutImmutable, Blittable, JsonProperty(Order = 512)]
		private float _Element5RayDistance;

		[ObservableProperty]
		[property: ContainerField(516), JsonProperty(Order = 516)]
		private CtrRef<SurfaceShaderBaseAsset> _Element3Shader = new();

		[ObservableProperty]
		[property: ContainerField(520), JsonProperty(Order = 520)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(524), JsonProperty(Order = 524)]
		private CtrRef<SurfaceShaderBaseAsset> _Element5Shader = new();

		[ObservableProperty]
		[property: ContainerField(528), LayoutImmutable, Blittable, JsonProperty(Order = 528)]
		private bool _Element5Enable;

		[ObservableProperty]
		[property: ContainerField(529), LayoutImmutable, Blittable, JsonProperty(Order = 529)]
		private bool _Element3Enable;

		[ObservableProperty]
		[property: ContainerField(530), LayoutImmutable, Blittable, JsonProperty(Order = 530)]
		private bool _Element2Enable;

		[ObservableProperty]
		[property: ContainerField(531), LayoutImmutable, Blittable, JsonProperty(Order = 531)]
		private bool _Element1Enable;

		[ObservableProperty]
		[property: ContainerField(532), LayoutImmutable, Blittable, JsonProperty(Order = 532)]
		private bool _DebugDrawOccluder;

		[ObservableProperty]
		[property: ContainerField(533), LayoutImmutable, Blittable, JsonProperty(Order = 533)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(534), LayoutImmutable, Blittable, JsonProperty(Order = 534)]
		private bool _Element4Enable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Element5AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element5AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element5SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element2SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element5SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element2AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element2AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element1Size.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			Element1SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element1SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element1AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element1AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element5Size.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			Element4SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element3Size.Serialize(p_Writer, p_EbxWriter);
			Element2Size.Serialize(p_Writer, p_EbxWriter);
			Element4AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element2SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element4SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element4Size.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			Element3AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element4AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element3SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element3SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element3AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Element1Shader));
			p_Writer.Write(OccluderSize);
			p_Writer.Write(p_EbxWriter.WriteImport(Element2Shader));
			p_Writer.Write(Element3RayDistance);
			p_Writer.Write(p_EbxWriter.WriteImport(Element4Shader));
			p_Writer.Write(Element4RayDistance);
			p_Writer.Write(Element2RayDistance);
			p_Writer.Write(Element1RayDistance);
			p_Writer.Write(Element5RayDistance);
			p_Writer.Write(p_EbxWriter.WriteImport(Element3Shader));
			p_Writer.Write((int) Realm);
			p_Writer.Write(p_EbxWriter.WriteImport(Element5Shader));
			p_Writer.Write(Element5Enable);
			p_Writer.Write(Element3Enable);
			p_Writer.Write(Element2Enable);
			p_Writer.Write(Element1Enable);
			p_Writer.Write(DebugDrawOccluder);
			p_Writer.Write(Enable);
			p_Writer.Write(Element4Enable);
			p_Writer.WriteNullBytes(9);
		}
	}
}
