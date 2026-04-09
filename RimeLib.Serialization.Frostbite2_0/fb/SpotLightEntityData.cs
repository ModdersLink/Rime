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
	public partial class SpotLightEntityData :
		LocalLightEntityData
	{
		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private SpotLightShape _Shape = new();

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _ConeInnerAngle;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _ConeOuterAngle;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private float _FrustumFov;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _FrustumAspect;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _OrthoWidth;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _OrthoHeight;

		[ObservableProperty]
		[property: ContainerField(188), JsonProperty(Order = 188)]
		private CtrRef<TextureAsset> _Texture = new();

		[ObservableProperty]
		[property: ContainerField(192), JsonProperty(Order = 192)]
		private QualityLevel _CastShadowsMinLevel = new();

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private bool _CastShadowsEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Shape);
			p_Writer.Write(ConeInnerAngle);
			p_Writer.Write(ConeOuterAngle);
			p_Writer.Write(FrustumFov);
			p_Writer.Write(FrustumAspect);
			p_Writer.Write(OrthoWidth);
			p_Writer.Write(OrthoHeight);
			p_Writer.Write(p_EbxWriter.WriteImport(Texture));
			p_Writer.Write((int) CastShadowsMinLevel);
			p_Writer.Write(CastShadowsEnable);
			p_Writer.WriteNullBytes(11);
		}
	}
}
