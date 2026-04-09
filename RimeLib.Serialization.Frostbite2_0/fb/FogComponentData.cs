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
	[ContainerType(16, 208)]
	public partial class FogComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec4 _Curve = new();

		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec4 _FogColorCurve = new();

		[ObservableProperty]
		[property: ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private Vec3 _FogColor = new();

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _FogColorStart;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _FogDistanceMultiplier;

		[ObservableProperty]
		[property: ContainerField(152), JsonProperty(Order = 152)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _End;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _TransparencyFadeStart;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _Start;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _TransparencyFadeEnd;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private float _FogColorEnd;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _TransparencyFadeClamp;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _HeightFogVisibilityRange;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _HeightFogAltitude;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private float _HeightFogDepth;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _HeightFogFollowCamera;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private bool _FogGradientEnable;

		[ObservableProperty]
		[property: ContainerField(197), LayoutImmutable, Blittable, JsonProperty(Order = 197)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(198), LayoutImmutable, Blittable, JsonProperty(Order = 198)]
		private bool _HeightFogEnable;

		[ObservableProperty]
		[property: ContainerField(199), LayoutImmutable, Blittable, JsonProperty(Order = 199)]
		private bool _FogColorEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Curve.Serialize(p_Writer, p_EbxWriter);
			FogColorCurve.Serialize(p_Writer, p_EbxWriter);
			FogColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FogColorStart);
			p_Writer.Write(FogDistanceMultiplier);
			p_Writer.Write((int) Realm);
			p_Writer.Write(End);
			p_Writer.Write(TransparencyFadeStart);
			p_Writer.Write(Start);
			p_Writer.Write(TransparencyFadeEnd);
			p_Writer.Write(FogColorEnd);
			p_Writer.Write(TransparencyFadeClamp);
			p_Writer.Write(HeightFogVisibilityRange);
			p_Writer.Write(HeightFogAltitude);
			p_Writer.Write(HeightFogDepth);
			p_Writer.Write(HeightFogFollowCamera);
			p_Writer.Write(FogGradientEnable);
			p_Writer.Write(Enable);
			p_Writer.Write(HeightFogEnable);
			p_Writer.Write(FogColorEnable);
			p_Writer.WriteNullBytes(8);
		}
	}
}
