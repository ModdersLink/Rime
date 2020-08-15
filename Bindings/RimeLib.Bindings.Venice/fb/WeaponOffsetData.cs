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
	public class WeaponOffsetData : 
		DataContainer
	{
		protected float m_WeaponOffsetX = new float();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(2991904818)]
		public float WeaponOffsetX { get { return m_WeaponOffsetX; } set { if (OnPropertyChanging("WeaponOffsetData." + nameof(WeaponOffsetX), this, m_WeaponOffsetX, value)) m_WeaponOffsetX = value; } } // 0x8 (8)
		
		protected float m_WeaponOffsetY = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(2991904819)]
		public float WeaponOffsetY { get { return m_WeaponOffsetY; } set { if (OnPropertyChanging("WeaponOffsetData." + nameof(WeaponOffsetY), this, m_WeaponOffsetY, value)) m_WeaponOffsetY = value; } } // 0xC (12)
		
		protected float m_WeaponOffsetZ = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(2991904816)]
		public float WeaponOffsetZ { get { return m_WeaponOffsetZ; } set { if (OnPropertyChanging("WeaponOffsetData." + nameof(WeaponOffsetZ), this, m_WeaponOffsetZ, value)) m_WeaponOffsetZ = value; } } // 0x10 (16)
		
		protected float m_WeaponZoomedOffsetX = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(2753985860)]
		public float WeaponZoomedOffsetX { get { return m_WeaponZoomedOffsetX; } set { if (OnPropertyChanging("WeaponOffsetData." + nameof(WeaponZoomedOffsetX), this, m_WeaponZoomedOffsetX, value)) m_WeaponZoomedOffsetX = value; } } // 0x14 (20)
		
		protected float m_WeaponZoomedOffsetY = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(2753985861)]
		public float WeaponZoomedOffsetY { get { return m_WeaponZoomedOffsetY; } set { if (OnPropertyChanging("WeaponOffsetData." + nameof(WeaponZoomedOffsetY), this, m_WeaponZoomedOffsetY, value)) m_WeaponZoomedOffsetY = value; } } // 0x18 (24)
		
		protected float m_WeaponZoomedOffsetZ = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(2753985862)]
		public float WeaponZoomedOffsetZ { get { return m_WeaponZoomedOffsetZ; } set { if (OnPropertyChanging("WeaponOffsetData." + nameof(WeaponZoomedOffsetZ), this, m_WeaponZoomedOffsetZ, value)) m_WeaponZoomedOffsetZ = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2991904818:
					WeaponOffsetX = (float) p_Value;
					break;

				case 2991904819:
					WeaponOffsetY = (float) p_Value;
					break;

				case 2991904816:
					WeaponOffsetZ = (float) p_Value;
					break;

				case 2753985860:
					WeaponZoomedOffsetX = (float) p_Value;
					break;

				case 2753985861:
					WeaponZoomedOffsetY = (float) p_Value;
					break;

				case 2753985862:
					WeaponZoomedOffsetZ = (float) p_Value;
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
				case 2991904818:
					return WeaponOffsetX;

				case 2991904819:
					return WeaponOffsetY;

				case 2991904816:
					return WeaponOffsetZ;

				case 2753985860:
					return WeaponZoomedOffsetX;

				case 2753985861:
					return WeaponZoomedOffsetY;

				case 2753985862:
					return WeaponZoomedOffsetZ;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2991904818:
					return typeof(WeaponOffsetData).GetProperty(nameof(WeaponOffsetX));

				case 2991904819:
					return typeof(WeaponOffsetData).GetProperty(nameof(WeaponOffsetY));

				case 2991904816:
					return typeof(WeaponOffsetData).GetProperty(nameof(WeaponOffsetZ));

				case 2753985860:
					return typeof(WeaponOffsetData).GetProperty(nameof(WeaponZoomedOffsetX));

				case 2753985861:
					return typeof(WeaponOffsetData).GetProperty(nameof(WeaponZoomedOffsetY));

				case 2753985862:
					return typeof(WeaponOffsetData).GetProperty(nameof(WeaponZoomedOffsetZ));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
