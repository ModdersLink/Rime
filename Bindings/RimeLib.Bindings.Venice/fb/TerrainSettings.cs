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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class TerrainSettings : 
		DataContainer
	{
		protected uint m_HeightQueryCacheSize = new uint();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(360991385)]
		public uint HeightQueryCacheSize { get { return m_HeightQueryCacheSize; } set { if (OnPropertyChanging("TerrainSettings." + nameof(HeightQueryCacheSize), this, m_HeightQueryCacheSize, value)) m_HeightQueryCacheSize = value; } } // 0x8 (8)
		
		protected uint m_ModifiersCapacity = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3948255029)]
		public uint ModifiersCapacity { get { return m_ModifiersCapacity; } set { if (OnPropertyChanging("TerrainSettings." + nameof(ModifiersCapacity), this, m_ModifiersCapacity, value)) m_ModifiersCapacity = value; } } // 0xC (12)
		
		protected uint m_IntersectingModifiersMax = new uint();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3775873328)]
		public uint IntersectingModifiersMax { get { return m_IntersectingModifiersMax; } set { if (OnPropertyChanging("TerrainSettings." + nameof(IntersectingModifiersMax), this, m_IntersectingModifiersMax, value)) m_IntersectingModifiersMax = value; } } // 0x10 (16)
		
		protected float m_ModifierDepthFactor = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2305338610)]
		public float ModifierDepthFactor { get { return m_ModifierDepthFactor; } set { if (OnPropertyChanging("TerrainSettings." + nameof(ModifierDepthFactor), this, m_ModifierDepthFactor, value)) m_ModifierDepthFactor = value; } } // 0x14 (20)
		
		protected float m_ModifierSlopeMax = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2295593955)]
		public float ModifierSlopeMax { get { return m_ModifierSlopeMax; } set { if (OnPropertyChanging("TerrainSettings." + nameof(ModifierSlopeMax), this, m_ModifierSlopeMax, value)) m_ModifierSlopeMax = value; } } // 0x18 (24)
		
		protected bool m_ModifiersEnable = new bool();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3614191008)]
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
