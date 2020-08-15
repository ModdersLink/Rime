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
	[ContainerType(4)]
	public class TerrainStreamingSettings : 
		DataContainer
	{
		protected uint m_DataLoadJobCount = new uint();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(2206629719)]
		public uint DataLoadJobCount { get { return m_DataLoadJobCount; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(DataLoadJobCount), this, m_DataLoadJobCount, value)) m_DataLoadJobCount = value; } } // 0x8 (8)
		
		protected uint m_ActiveFreeStreamingDataLoadJobCount = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(1513849907)]
		public uint ActiveFreeStreamingDataLoadJobCount { get { return m_ActiveFreeStreamingDataLoadJobCount; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(ActiveFreeStreamingDataLoadJobCount), this, m_ActiveFreeStreamingDataLoadJobCount, value)) m_ActiveFreeStreamingDataLoadJobCount = value; } } // 0xC (12)
		
		protected uint m_HeightfieldAtlasSampleCountXFactor = new uint();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(2700717027)]
		public uint HeightfieldAtlasSampleCountXFactor { get { return m_HeightfieldAtlasSampleCountXFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(HeightfieldAtlasSampleCountXFactor), this, m_HeightfieldAtlasSampleCountXFactor, value)) m_HeightfieldAtlasSampleCountXFactor = value; } } // 0x10 (16)
		
		protected uint m_AdditionalBlurriness = new uint();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(3610471397)]
		public uint AdditionalBlurriness { get { return m_AdditionalBlurriness; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(AdditionalBlurriness), this, m_AdditionalBlurriness, value)) m_AdditionalBlurriness = value; } } // 0x14 (20)
		
		protected float m_InvisibleDetailReductionFactor = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(770364681)]
		public float InvisibleDetailReductionFactor { get { return m_InvisibleDetailReductionFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(InvisibleDetailReductionFactor), this, m_InvisibleDetailReductionFactor, value)) m_InvisibleDetailReductionFactor = value; } } // 0x18 (24)
		
		protected float m_OccludedDetailReductionFactor = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(1482388499)]
		public float OccludedDetailReductionFactor { get { return m_OccludedDetailReductionFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(OccludedDetailReductionFactor), this, m_OccludedDetailReductionFactor, value)) m_OccludedDetailReductionFactor = value; } } // 0x1C (28)
		
		protected uint m_HeightfieldAtlasSampleCountYFactor = new uint();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(3835784866)]
		public uint HeightfieldAtlasSampleCountYFactor { get { return m_HeightfieldAtlasSampleCountYFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(HeightfieldAtlasSampleCountYFactor), this, m_HeightfieldAtlasSampleCountYFactor, value)) m_HeightfieldAtlasSampleCountYFactor = value; } } // 0x20 (32)
		
		protected uint m_MaskAtlasSampleCountYFactor = new uint();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(2228725995)]
		public uint MaskAtlasSampleCountYFactor { get { return m_MaskAtlasSampleCountYFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(MaskAtlasSampleCountYFactor), this, m_MaskAtlasSampleCountYFactor, value)) m_MaskAtlasSampleCountYFactor = value; } } // 0x24 (36)
		
		protected uint m_ColorAdditionalBlurriness = new uint();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(3507421848)]
		public uint ColorAdditionalBlurriness { get { return m_ColorAdditionalBlurriness; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(ColorAdditionalBlurriness), this, m_ColorAdditionalBlurriness, value)) m_ColorAdditionalBlurriness = value; } } // 0x28 (40)
		
		protected uint m_MaskAtlasSampleCountXFactor = new uint();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(3363793834)]
		public uint MaskAtlasSampleCountXFactor { get { return m_MaskAtlasSampleCountXFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(MaskAtlasSampleCountXFactor), this, m_MaskAtlasSampleCountXFactor, value)) m_MaskAtlasSampleCountXFactor = value; } } // 0x2C (44)
		
		protected uint m_MaskAdditionalBlurriness = new uint();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(1316541521)]
		public uint MaskAdditionalBlurriness { get { return m_MaskAdditionalBlurriness; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(MaskAdditionalBlurriness), this, m_MaskAdditionalBlurriness, value)) m_MaskAdditionalBlurriness = value; } } // 0x30 (48)
		
		protected uint m_ColorAtlasSampleCountXFactor = new uint();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(2883811075)]
		public uint ColorAtlasSampleCountXFactor { get { return m_ColorAtlasSampleCountXFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(ColorAtlasSampleCountXFactor), this, m_ColorAtlasSampleCountXFactor, value)) m_ColorAtlasSampleCountXFactor = value; } } // 0x34 (52)
		
		protected uint m_ColorAtlasSampleCountYFactor = new uint();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(3608111938)]
		public uint ColorAtlasSampleCountYFactor { get { return m_ColorAtlasSampleCountYFactor; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(ColorAtlasSampleCountYFactor), this, m_ColorAtlasSampleCountYFactor, value)) m_ColorAtlasSampleCountYFactor = value; } } // 0x38 (56)
		
		protected bool m_KeepPoolFullEnable = new bool();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(2806586800)]
		public bool KeepPoolFullEnable { get { return m_KeepPoolFullEnable; } set { if (OnPropertyChanging("TerrainStreamingSettings." + nameof(KeepPoolFullEnable), this, m_KeepPoolFullEnable, value)) m_KeepPoolFullEnable = value; } } // 0x3C (60)
		
		protected bool m_LoadOccluderDataEnable = new bool();
		[ContainerField(61), LayoutImmutable, Blittable, ContainerFieldNameHash(1587906935)]
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
