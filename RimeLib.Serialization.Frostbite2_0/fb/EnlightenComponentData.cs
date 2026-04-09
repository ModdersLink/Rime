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
	[ContainerType(16, 224)]
	public partial class EnlightenComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec3 _SkyBoxSkyColor = new();

		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec3 _SkyBoxBackLightColor = new();

		[ObservableProperty]
		[property: ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private Vec3 _SkyBoxGroundColor = new();

		[ObservableProperty]
		[property: ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private Vec3 _TerrainColor = new();

		[ObservableProperty]
		[property: ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private Vec3 _SkyBoxSunLightColor = new();

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _BounceScale;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _CullDistance;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _SunScale;

		[ObservableProperty]
		[property: ContainerField(188), JsonProperty(Order = 188)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _SkyBoxBackLightRotationY;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private float _SkyBoxSunLightColorSize;

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private float _SkyBoxBackLightColorSize;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private float _SkyBoxBackLightRotationX;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private bool _SkyBoxEnable;

		[ObservableProperty]
		[property: ContainerField(209), LayoutImmutable, Blittable, JsonProperty(Order = 209)]
		private bool _Enable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			SkyBoxSkyColor.Serialize(p_Writer, p_EbxWriter);
			SkyBoxBackLightColor.Serialize(p_Writer, p_EbxWriter);
			SkyBoxGroundColor.Serialize(p_Writer, p_EbxWriter);
			TerrainColor.Serialize(p_Writer, p_EbxWriter);
			SkyBoxSunLightColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(BounceScale);
			p_Writer.Write(CullDistance);
			p_Writer.Write(SunScale);
			p_Writer.Write((int) Realm);
			p_Writer.Write(SkyBoxBackLightRotationY);
			p_Writer.Write(SkyBoxSunLightColorSize);
			p_Writer.Write(SkyBoxBackLightColorSize);
			p_Writer.Write(SkyBoxBackLightRotationX);
			p_Writer.Write(SkyBoxEnable);
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(14);
		}
	}
}
