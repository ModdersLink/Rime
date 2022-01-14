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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 64)]
	public class TerrainStreamingSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint DataLoadJobCount { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint ActiveFreeStreamingDataLoadJobCount { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint HeightfieldAtlasSampleCountXFactor { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint AdditionalBlurriness { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float InvisibleDetailReductionFactor { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float OccludedDetailReductionFactor { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public uint HeightfieldAtlasSampleCountYFactor { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public uint MaskAtlasSampleCountYFactor { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public uint ColorAdditionalBlurriness { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public uint MaskAtlasSampleCountXFactor { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public uint MaskAdditionalBlurriness { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public uint ColorAtlasSampleCountXFactor { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public uint ColorAtlasSampleCountYFactor { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public bool KeepPoolFullEnable { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		public bool LoadOccluderDataEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
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
