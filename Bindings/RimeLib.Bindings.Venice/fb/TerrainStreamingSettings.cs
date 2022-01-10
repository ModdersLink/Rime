///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 64)]
	public class TerrainStreamingSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint DataLoadJobCount { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint ActiveFreeStreamingDataLoadJobCount { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint HeightfieldAtlasSampleCountXFactor { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint AdditionalBlurriness { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float InvisibleDetailReductionFactor { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float OccludedDetailReductionFactor { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint HeightfieldAtlasSampleCountYFactor { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint MaskAtlasSampleCountYFactor { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public uint ColorAdditionalBlurriness { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public uint MaskAtlasSampleCountXFactor { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public uint MaskAdditionalBlurriness { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public uint ColorAtlasSampleCountXFactor { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public uint ColorAtlasSampleCountYFactor { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool KeepPoolFullEnable { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable]
		public bool LoadOccluderDataEnable { get; set; }

		public static void Deserialize(TerrainStreamingSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DataLoadJobCount = p_Reader.ReadUInt32();
			p_Instance.ActiveFreeStreamingDataLoadJobCount = p_Reader.ReadUInt32();
			p_Instance.HeightfieldAtlasSampleCountXFactor = p_Reader.ReadUInt32();
			p_Instance.AdditionalBlurriness = p_Reader.ReadUInt32();
			p_Instance.InvisibleDetailReductionFactor = p_Reader.ReadSingle();
			p_Instance.OccludedDetailReductionFactor = p_Reader.ReadSingle();
			p_Instance.HeightfieldAtlasSampleCountYFactor = p_Reader.ReadUInt32();
			p_Instance.MaskAtlasSampleCountYFactor = p_Reader.ReadUInt32();
			p_Instance.ColorAdditionalBlurriness = p_Reader.ReadUInt32();
			p_Instance.MaskAtlasSampleCountXFactor = p_Reader.ReadUInt32();
			p_Instance.MaskAdditionalBlurriness = p_Reader.ReadUInt32();
			p_Instance.ColorAtlasSampleCountXFactor = p_Reader.ReadUInt32();
			p_Instance.ColorAtlasSampleCountYFactor = p_Reader.ReadUInt32();
			p_Instance.KeepPoolFullEnable = p_Reader.ReadBool();
			p_Instance.LoadOccluderDataEnable = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
