///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class TerrainStreamingSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint DataLoadJobCount { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint ActiveFreeStreamingDataLoadJobCount { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint HeightfieldAtlasSampleCountXFactor { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint AdditionalBlurriness { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float InvisibleDetailReductionFactor { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float OccludedDetailReductionFactor { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint HeightfieldAtlasSampleCountYFactor { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint MaskAtlasSampleCountYFactor { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint ColorAdditionalBlurriness { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public uint MaskAtlasSampleCountXFactor { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public uint MaskAdditionalBlurriness { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public uint ColorAtlasSampleCountXFactor { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public uint ColorAtlasSampleCountYFactor { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool KeepPoolFullEnable { get; set; } // 0x3C (60)
		
		[ContainerField(61), LayoutImmutable, Blittable]
		public bool LoadOccluderDataEnable { get; set; } // 0x3D (61)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2206629719:
					DataLoadJobCount = (uint) p_Value;
					break;

				case 1513849907:
					ActiveFreeStreamingDataLoadJobCount = (uint) p_Value;
					break;

				case 2700717027:
					HeightfieldAtlasSampleCountXFactor = (uint) p_Value;
					break;

				case 3610471397:
					AdditionalBlurriness = (uint) p_Value;
					break;

				case 770364681:
					InvisibleDetailReductionFactor = (float) p_Value;
					break;

				case 1482388499:
					OccludedDetailReductionFactor = (float) p_Value;
					break;

				case 3835784866:
					HeightfieldAtlasSampleCountYFactor = (uint) p_Value;
					break;

				case 2228725995:
					MaskAtlasSampleCountYFactor = (uint) p_Value;
					break;

				case 3507421848:
					ColorAdditionalBlurriness = (uint) p_Value;
					break;

				case 3363793834:
					MaskAtlasSampleCountXFactor = (uint) p_Value;
					break;

				case 1316541521:
					MaskAdditionalBlurriness = (uint) p_Value;
					break;

				case 2883811075:
					ColorAtlasSampleCountXFactor = (uint) p_Value;
					break;

				case 3608111938:
					ColorAtlasSampleCountYFactor = (uint) p_Value;
					break;

				case 2806586800:
					KeepPoolFullEnable = (bool) p_Value;
					break;

				case 1587906935:
					LoadOccluderDataEnable = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2206629719:
					return DataLoadJobCount;

				case 1513849907:
					return ActiveFreeStreamingDataLoadJobCount;

				case 2700717027:
					return HeightfieldAtlasSampleCountXFactor;

				case 3610471397:
					return AdditionalBlurriness;

				case 770364681:
					return InvisibleDetailReductionFactor;

				case 1482388499:
					return OccludedDetailReductionFactor;

				case 3835784866:
					return HeightfieldAtlasSampleCountYFactor;

				case 2228725995:
					return MaskAtlasSampleCountYFactor;

				case 3507421848:
					return ColorAdditionalBlurriness;

				case 3363793834:
					return MaskAtlasSampleCountXFactor;

				case 1316541521:
					return MaskAdditionalBlurriness;

				case 2883811075:
					return ColorAtlasSampleCountXFactor;

				case 3608111938:
					return ColorAtlasSampleCountYFactor;

				case 2806586800:
					return KeepPoolFullEnable;

				case 1587906935:
					return LoadOccluderDataEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2206629719:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(DataLoadJobCount));

				case 1513849907:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(ActiveFreeStreamingDataLoadJobCount));

				case 2700717027:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(HeightfieldAtlasSampleCountXFactor));

				case 3610471397:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(AdditionalBlurriness));

				case 770364681:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(InvisibleDetailReductionFactor));

				case 1482388499:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(OccludedDetailReductionFactor));

				case 3835784866:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(HeightfieldAtlasSampleCountYFactor));

				case 2228725995:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(MaskAtlasSampleCountYFactor));

				case 3507421848:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(ColorAdditionalBlurriness));

				case 3363793834:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(MaskAtlasSampleCountXFactor));

				case 1316541521:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(MaskAdditionalBlurriness));

				case 2883811075:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(ColorAtlasSampleCountXFactor));

				case 3608111938:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(ColorAtlasSampleCountYFactor));

				case 2806586800:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(KeepPoolFullEnable));

				case 1587906935:
					return typeof(TerrainStreamingSettings).GetProperty(nameof(LoadOccluderDataEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
