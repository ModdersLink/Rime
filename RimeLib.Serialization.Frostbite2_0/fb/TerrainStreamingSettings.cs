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
	[ContainerType(4, 64)]
	public partial class TerrainStreamingSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private uint _DataLoadJobCount;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _ActiveFreeStreamingDataLoadJobCount;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _HeightfieldAtlasSampleCountXFactor;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _AdditionalBlurriness;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _InvisibleDetailReductionFactor;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _OccludedDetailReductionFactor;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private uint _HeightfieldAtlasSampleCountYFactor;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private uint _MaskAtlasSampleCountYFactor;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private uint _ColorAdditionalBlurriness;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private uint _MaskAtlasSampleCountXFactor;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private uint _MaskAdditionalBlurriness;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private uint _ColorAtlasSampleCountXFactor;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private uint _ColorAtlasSampleCountYFactor;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private bool _KeepPoolFullEnable;

		[ObservableProperty]
		[property: ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		private bool _LoadOccluderDataEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(DataLoadJobCount);
			p_Writer.Write(ActiveFreeStreamingDataLoadJobCount);
			p_Writer.Write(HeightfieldAtlasSampleCountXFactor);
			p_Writer.Write(AdditionalBlurriness);
			p_Writer.Write(InvisibleDetailReductionFactor);
			p_Writer.Write(OccludedDetailReductionFactor);
			p_Writer.Write(HeightfieldAtlasSampleCountYFactor);
			p_Writer.Write(MaskAtlasSampleCountYFactor);
			p_Writer.Write(ColorAdditionalBlurriness);
			p_Writer.Write(MaskAtlasSampleCountXFactor);
			p_Writer.Write(MaskAdditionalBlurriness);
			p_Writer.Write(ColorAtlasSampleCountXFactor);
			p_Writer.Write(ColorAtlasSampleCountYFactor);
			p_Writer.Write(KeepPoolFullEnable);
			p_Writer.Write(LoadOccluderDataEnable);
			p_Writer.WriteNullBytes(2);
		}
	}
}
