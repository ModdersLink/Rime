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
	[ContainerType(16, 192)]
	public partial class LensScopeComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec3 _ChromaticAberrationColor1 = new();

		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec2 _RadialBlendDistanceCoefficients = new();

		[ObservableProperty]
		[property: ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private Vec3 _ChromaticAberrationColor2 = new();

		[ObservableProperty]
		[property: ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private Vec2 _BlurCenter = new();

		[ObservableProperty]
		[property: ContainerField(152), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private Vec2 _ChromaticAberrationDisplacement2 = new();

		[ObservableProperty]
		[property: ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private Vec2 _ChromaticAberrationDisplacement1 = new();

		[ObservableProperty]
		[property: ContainerField(168), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private Vec2 _ChromaticAberrationStrengths = new();

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _BlurScale;

		[ObservableProperty]
		[property: ContainerField(180), JsonProperty(Order = 180)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private bool _Enable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationColor1.Serialize(p_Writer, p_EbxWriter);
			RadialBlendDistanceCoefficients.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			ChromaticAberrationColor2.Serialize(p_Writer, p_EbxWriter);
			BlurCenter.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationDisplacement2.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationDisplacement1.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationStrengths.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(BlurScale);
			p_Writer.Write((int) Realm);
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(7);
		}
	}
}
