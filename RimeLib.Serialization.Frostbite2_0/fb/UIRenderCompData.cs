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
	[ContainerType(16, 96)]
	public partial class UIRenderCompData :
		UIComponentData
	{
		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec4 _BackgroundRect1 = new();

		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec4 _BackgroundRect0 = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private CtrRef<TextureAsset> _BgTexture2 = new();

		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private CtrRef<TextureAsset> _BgTexture1 = new();

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _AlphaMin;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _AlphaAnimationSpeed;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _AlphaOffset;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _AlphaMax;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			BackgroundRect1.Serialize(p_Writer, p_EbxWriter);
			BackgroundRect0.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(BgTexture2));
			p_Writer.Write(p_EbxWriter.WriteImport(BgTexture1));
			p_Writer.Write(AlphaMin);
			p_Writer.Write(AlphaAnimationSpeed);
			p_Writer.Write(AlphaOffset);
			p_Writer.Write(AlphaMax);
			p_Writer.WriteNullBytes(8);
		}
	}
}
