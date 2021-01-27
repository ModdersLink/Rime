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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class TerrainSettings : 
		DataContainer
	{
		protected uint m_HeightQueryCacheSize = new uint();
		[ContainerField(Name: "HeightQueryCacheSize", Offset: 8, NameHash: 360991385, Flags: 49421), LayoutImmutable, Blittable]
		public uint HeightQueryCacheSize { get { return m_HeightQueryCacheSize; } set { if (OnPropertyChanging("TerrainSettings." + nameof(HeightQueryCacheSize), this, m_HeightQueryCacheSize, value)) m_HeightQueryCacheSize = value; } } // 0x8 (8)
		
		protected uint m_ModifiersCapacity = new uint();
		[ContainerField(Name: "ModifiersCapacity", Offset: 12, NameHash: 3948255029, Flags: 49421), LayoutImmutable, Blittable]
		public uint ModifiersCapacity { get { return m_ModifiersCapacity; } set { if (OnPropertyChanging("TerrainSettings." + nameof(ModifiersCapacity), this, m_ModifiersCapacity, value)) m_ModifiersCapacity = value; } } // 0xC (12)
		
		protected uint m_IntersectingModifiersMax = new uint();
		[ContainerField(Name: "IntersectingModifiersMax", Offset: 16, NameHash: 3775873328, Flags: 49421), LayoutImmutable, Blittable]
		public uint IntersectingModifiersMax { get { return m_IntersectingModifiersMax; } set { if (OnPropertyChanging("TerrainSettings." + nameof(IntersectingModifiersMax), this, m_IntersectingModifiersMax, value)) m_IntersectingModifiersMax = value; } } // 0x10 (16)
		
		protected float m_ModifierDepthFactor = new float();
		[ContainerField(Name: "ModifierDepthFactor", Offset: 20, NameHash: 2305338610, Flags: 49469), LayoutImmutable, Blittable]
		public float ModifierDepthFactor { get { return m_ModifierDepthFactor; } set { if (OnPropertyChanging("TerrainSettings." + nameof(ModifierDepthFactor), this, m_ModifierDepthFactor, value)) m_ModifierDepthFactor = value; } } // 0x14 (20)
		
		protected float m_ModifierSlopeMax = new float();
		[ContainerField(Name: "ModifierSlopeMax", Offset: 24, NameHash: 2295593955, Flags: 49469), LayoutImmutable, Blittable]
		public float ModifierSlopeMax { get { return m_ModifierSlopeMax; } set { if (OnPropertyChanging("TerrainSettings." + nameof(ModifierSlopeMax), this, m_ModifierSlopeMax, value)) m_ModifierSlopeMax = value; } } // 0x18 (24)
		
		protected bool m_ModifiersEnable = new bool();
		[ContainerField(Name: "ModifiersEnable", Offset: 28, NameHash: 3614191008, Flags: 49325), LayoutImmutable, Blittable]
		public bool ModifiersEnable { get { return m_ModifiersEnable; } set { if (OnPropertyChanging("TerrainSettings." + nameof(ModifiersEnable), this, m_ModifiersEnable, value)) m_ModifiersEnable = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 360991385:
					HeightQueryCacheSize = (uint) p_Value;
					break;

				case 3948255029:
					ModifiersCapacity = (uint) p_Value;
					break;

				case 3775873328:
					IntersectingModifiersMax = (uint) p_Value;
					break;

				case 2305338610:
					ModifierDepthFactor = (float) p_Value;
					break;

				case 2295593955:
					ModifierSlopeMax = (float) p_Value;
					break;

				case 3614191008:
					ModifiersEnable = (bool) p_Value;
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
				case 360991385:
					return HeightQueryCacheSize;

				case 3948255029:
					return ModifiersCapacity;

				case 3775873328:
					return IntersectingModifiersMax;

				case 2305338610:
					return ModifierDepthFactor;

				case 2295593955:
					return ModifierSlopeMax;

				case 3614191008:
					return ModifiersEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 360991385:
					return typeof(TerrainSettings).GetProperty(nameof(HeightQueryCacheSize));

				case 3948255029:
					return typeof(TerrainSettings).GetProperty(nameof(ModifiersCapacity));

				case 3775873328:
					return typeof(TerrainSettings).GetProperty(nameof(IntersectingModifiersMax));

				case 2305338610:
					return typeof(TerrainSettings).GetProperty(nameof(ModifierDepthFactor));

				case 2295593955:
					return typeof(TerrainSettings).GetProperty(nameof(ModifierSlopeMax));

				case 3614191008:
					return typeof(TerrainSettings).GetProperty(nameof(ModifiersEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
