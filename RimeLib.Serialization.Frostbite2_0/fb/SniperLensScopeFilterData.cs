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
	public partial class SniperLensScopeFilterData :
		ScopeFilterData
	{
		[ObservableProperty]
		[property: ContainerField(12), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private Vec2 _ChromaticAberrationStrengths = new();

		[ObservableProperty]
		[property: ContainerField(20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private Vec2 _BlurCenter = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _ChromaticAberrationColor1 = new();

		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec3 _ChromaticAberrationColor2 = new();

		[ObservableProperty]
		[property: ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private Vec2 _RadialBlendDistanceCoefficients = new();

		[ObservableProperty]
		[property: ContainerField(72), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private Vec2 _ChromaticAberrationDisplacement1 = new();

		[ObservableProperty]
		[property: ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private Vec2 _ChromaticAberrationDisplacement2 = new();

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _BlurScale;

		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private ColorTintData _ColorTintData = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationStrengths.Serialize(p_Writer, p_EbxWriter);
			BlurCenter.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			ChromaticAberrationColor1.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationColor2.Serialize(p_Writer, p_EbxWriter);
			RadialBlendDistanceCoefficients.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationDisplacement1.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationDisplacement2.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(BlurScale);
			p_Writer.WriteNullBytes(4);
			ColorTintData.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
