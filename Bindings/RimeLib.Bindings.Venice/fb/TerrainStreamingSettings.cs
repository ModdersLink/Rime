///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 64)]
	public class TerrainStreamingSettings : 
		DataContainer
	{
		protected uint m_DataLoadJobCount = new uint();
		[ContainerField(Name: "DataLoadJobCount", Offset: 8, NameHash: 2206629719, Flags: 49421), LayoutImmutable, Blittable]
		public uint DataLoadJobCount { get { return m_DataLoadJobCount; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(DataLoadJobCount), this, m_DataLoadJobCount, value)) m_DataLoadJobCount = value; } } // 0x8 (8)
		
		protected uint m_ActiveFreeStreamingDataLoadJobCount = new uint();
		[ContainerField(Name: "ActiveFreeStreamingDataLoadJobCount", Offset: 12, NameHash: 1513849907, Flags: 49421), LayoutImmutable, Blittable]
		public uint ActiveFreeStreamingDataLoadJobCount { get { return m_ActiveFreeStreamingDataLoadJobCount; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(ActiveFreeStreamingDataLoadJobCount), this, m_ActiveFreeStreamingDataLoadJobCount, value)) m_ActiveFreeStreamingDataLoadJobCount = value; } } // 0xC (12)
		
		protected uint m_HeightfieldAtlasSampleCountXFactor = new uint();
		[ContainerField(Name: "HeightfieldAtlasSampleCountXFactor", Offset: 16, NameHash: 2700717027, Flags: 49421), LayoutImmutable, Blittable]
		public uint HeightfieldAtlasSampleCountXFactor { get { return m_HeightfieldAtlasSampleCountXFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(HeightfieldAtlasSampleCountXFactor), this, m_HeightfieldAtlasSampleCountXFactor, value)) m_HeightfieldAtlasSampleCountXFactor = value; } } // 0x10 (16)
		
		protected uint m_AdditionalBlurriness = new uint();
		[ContainerField(Name: "AdditionalBlurriness", Offset: 20, NameHash: 3610471397, Flags: 49421), LayoutImmutable, Blittable]
		public uint AdditionalBlurriness { get { return m_AdditionalBlurriness; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(AdditionalBlurriness), this, m_AdditionalBlurriness, value)) m_AdditionalBlurriness = value; } } // 0x14 (20)
		
		protected float m_InvisibleDetailReductionFactor = new float();
		[ContainerField(Name: "InvisibleDetailReductionFactor", Offset: 24, NameHash: 770364681, Flags: 49469), LayoutImmutable, Blittable]
		public float InvisibleDetailReductionFactor { get { return m_InvisibleDetailReductionFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(InvisibleDetailReductionFactor), this, m_InvisibleDetailReductionFactor, value)) m_InvisibleDetailReductionFactor = value; } } // 0x18 (24)
		
		protected float m_OccludedDetailReductionFactor = new float();
		[ContainerField(Name: "OccludedDetailReductionFactor", Offset: 28, NameHash: 1482388499, Flags: 49469), LayoutImmutable, Blittable]
		public float OccludedDetailReductionFactor { get { return m_OccludedDetailReductionFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(OccludedDetailReductionFactor), this, m_OccludedDetailReductionFactor, value)) m_OccludedDetailReductionFactor = value; } } // 0x1C (28)
		
		protected uint m_HeightfieldAtlasSampleCountYFactor = new uint();
		[ContainerField(Name: "HeightfieldAtlasSampleCountYFactor", Offset: 32, NameHash: 3835784866, Flags: 49421), LayoutImmutable, Blittable]
		public uint HeightfieldAtlasSampleCountYFactor { get { return m_HeightfieldAtlasSampleCountYFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(HeightfieldAtlasSampleCountYFactor), this, m_HeightfieldAtlasSampleCountYFactor, value)) m_HeightfieldAtlasSampleCountYFactor = value; } } // 0x20 (32)
		
		protected uint m_MaskAtlasSampleCountYFactor = new uint();
		[ContainerField(Name: "MaskAtlasSampleCountYFactor", Offset: 36, NameHash: 2228725995, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaskAtlasSampleCountYFactor { get { return m_MaskAtlasSampleCountYFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(MaskAtlasSampleCountYFactor), this, m_MaskAtlasSampleCountYFactor, value)) m_MaskAtlasSampleCountYFactor = value; } } // 0x24 (36)
		
		protected uint m_ColorAdditionalBlurriness = new uint();
		[ContainerField(Name: "ColorAdditionalBlurriness", Offset: 40, NameHash: 3507421848, Flags: 49421), LayoutImmutable, Blittable]
		public uint ColorAdditionalBlurriness { get { return m_ColorAdditionalBlurriness; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(ColorAdditionalBlurriness), this, m_ColorAdditionalBlurriness, value)) m_ColorAdditionalBlurriness = value; } } // 0x28 (40)
		
		protected uint m_MaskAtlasSampleCountXFactor = new uint();
		[ContainerField(Name: "MaskAtlasSampleCountXFactor", Offset: 44, NameHash: 3363793834, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaskAtlasSampleCountXFactor { get { return m_MaskAtlasSampleCountXFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(MaskAtlasSampleCountXFactor), this, m_MaskAtlasSampleCountXFactor, value)) m_MaskAtlasSampleCountXFactor = value; } } // 0x2C (44)
		
		protected uint m_MaskAdditionalBlurriness = new uint();
		[ContainerField(Name: "MaskAdditionalBlurriness", Offset: 48, NameHash: 1316541521, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaskAdditionalBlurriness { get { return m_MaskAdditionalBlurriness; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(MaskAdditionalBlurriness), this, m_MaskAdditionalBlurriness, value)) m_MaskAdditionalBlurriness = value; } } // 0x30 (48)
		
		protected uint m_ColorAtlasSampleCountXFactor = new uint();
		[ContainerField(Name: "ColorAtlasSampleCountXFactor", Offset: 52, NameHash: 2883811075, Flags: 49421), LayoutImmutable, Blittable]
		public uint ColorAtlasSampleCountXFactor { get { return m_ColorAtlasSampleCountXFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(ColorAtlasSampleCountXFactor), this, m_ColorAtlasSampleCountXFactor, value)) m_ColorAtlasSampleCountXFactor = value; } } // 0x34 (52)
		
		protected uint m_ColorAtlasSampleCountYFactor = new uint();
		[ContainerField(Name: "ColorAtlasSampleCountYFactor", Offset: 56, NameHash: 3608111938, Flags: 49421), LayoutImmutable, Blittable]
		public uint ColorAtlasSampleCountYFactor { get { return m_ColorAtlasSampleCountYFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(ColorAtlasSampleCountYFactor), this, m_ColorAtlasSampleCountYFactor, value)) m_ColorAtlasSampleCountYFactor = value; } } // 0x38 (56)
		
		protected bool m_KeepPoolFullEnable = new bool();
		[ContainerField(Name: "KeepPoolFullEnable", Offset: 60, NameHash: 2806586800, Flags: 49325), LayoutImmutable, Blittable]
		public bool KeepPoolFullEnable { get { return m_KeepPoolFullEnable; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(KeepPoolFullEnable), this, m_KeepPoolFullEnable, value)) m_KeepPoolFullEnable = value; } } // 0x3C (60)
		
		protected bool m_LoadOccluderDataEnable = new bool();
		[ContainerField(Name: "LoadOccluderDataEnable", Offset: 61, NameHash: 1587906935, Flags: 49325), LayoutImmutable, Blittable]
		public bool LoadOccluderDataEnable { get { return m_LoadOccluderDataEnable; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(LoadOccluderDataEnable), this, m_LoadOccluderDataEnable, value)) m_LoadOccluderDataEnable = value; } } // 0x3D (61)
		
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
