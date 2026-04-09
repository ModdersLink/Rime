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
	public partial class DofComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _NearDistanceScale;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _FocusDistance;

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private BlurFilter _BlurFilter = new();

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _BlurFilterDeviation;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _FarDistanceScale;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _BlurAdd;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _Scale;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _DiffusionDofFocalLength;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _DiffusionDofAperture;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private bool _DiffusionDofEnable;

		[ObservableProperty]
		[property: ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		private bool _Enable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			p_Writer.Write(NearDistanceScale);
			p_Writer.Write(FocusDistance);
			p_Writer.Write((int) BlurFilter);
			p_Writer.Write(BlurFilterDeviation);
			p_Writer.Write(FarDistanceScale);
			p_Writer.Write(BlurAdd);
			p_Writer.Write(Scale);
			p_Writer.Write(DiffusionDofFocalLength);
			p_Writer.Write(DiffusionDofAperture);
			p_Writer.Write(DiffusionDofEnable);
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(6);
		}
	}
}
