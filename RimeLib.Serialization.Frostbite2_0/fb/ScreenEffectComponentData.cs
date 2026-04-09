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
	[ContainerType(16, 144)]
	public partial class ScreenEffectComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec4 _ScreenEffectParams = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private ScreenEffectFrameType _FrameType = new();

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private CtrRef<SurfaceShaderBaseAsset> _Shader = new();

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _FrameWidth;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _OuterFrameOpacity;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _InnerFrameOpacity;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _Angle;

		[ObservableProperty]
		[property: ContainerField(136), JsonProperty(Order = 136)]
		private Realm _Realm = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ScreenEffectParams.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) FrameType);
			p_Writer.Write(p_EbxWriter.WriteImport(Shader));
			p_Writer.Write(FrameWidth);
			p_Writer.Write(OuterFrameOpacity);
			p_Writer.Write(InnerFrameOpacity);
			p_Writer.Write(Angle);
			p_Writer.Write((int) Realm);
			p_Writer.WriteNullBytes(4);
		}
	}
}
