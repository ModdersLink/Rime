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
	[ContainerType(16, 128)]
	public partial class PlanarReflectionComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private BlurFilter _VerticalBlurFilter = new();

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _HorizontalDeviation;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _GroundHeight;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _VerticalDeviation;

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private BlurFilter _HorizontalBlurFilter = new();

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private bool _SkyRenderEnable;

		[ObservableProperty]
		[property: ContainerField(117), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
		private bool _Enable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) VerticalBlurFilter);
			p_Writer.Write(HorizontalDeviation);
			p_Writer.Write(GroundHeight);
			p_Writer.Write(VerticalDeviation);
			p_Writer.Write((int) HorizontalBlurFilter);
			p_Writer.Write(SkyRenderEnable);
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(10);
		}
	}
}
