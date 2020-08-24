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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class FriendZoneEntityData : 
		EntityData
	{
		protected int m_EnemyWeight = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3888167615)]
		public int EnemyWeight { get { return m_EnemyWeight; } set { if (OnPropertyChanging("FriendZoneEntityData." + nameof(EnemyWeight), this, m_EnemyWeight, value)) m_EnemyWeight = value; } } // 0xC (12)
		
		protected int m_FriendlyWeight = new int();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(365084578)]
		public int FriendlyWeight { get { return m_FriendlyWeight; } set { if (OnPropertyChanging("FriendZoneEntityData." + nameof(FriendlyWeight), this, m_FriendlyWeight, value)) m_FriendlyWeight = value; } } // 0x10 (16)
		
		protected int m_CorpsTimeout = new int();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2096723555)]
		public int CorpsTimeout { get { return m_CorpsTimeout; } set { if (OnPropertyChanging("FriendZoneEntityData." + nameof(CorpsTimeout), this, m_CorpsTimeout, value)) m_CorpsTimeout = value; } } // 0x14 (20)
		
		protected int m_CorpsWeight = new int();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(133234872)]
		public int CorpsWeight { get { return m_CorpsWeight; } set { if (OnPropertyChanging("FriendZoneEntityData." + nameof(CorpsWeight), this, m_CorpsWeight, value)) m_CorpsWeight = value; } } // 0x18 (24)
		
		protected bool m_CountCorpsesForAllTeams = new bool();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3473146361)]
		public bool CountCorpsesForAllTeams { get { return m_CountCorpsesForAllTeams; } set { if (OnPropertyChanging("FriendZoneEntityData." + nameof(CountCorpsesForAllTeams), this, m_CountCorpsesForAllTeams, value)) m_CountCorpsesForAllTeams = value; } } // 0x1C (28)
		
		protected bool m_InitialZoneRandomized = new bool();
		[ContainerField(29), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1766807212)]
		public bool InitialZoneRandomized { get { return m_InitialZoneRandomized; } set { if (OnPropertyChanging("FriendZoneEntityData." + nameof(InitialZoneRandomized), this, m_InitialZoneRandomized, value)) m_InitialZoneRandomized = value; } } // 0x1D (29)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3888167615:
					EnemyWeight = (int) p_Value;
					break;

				case 365084578:
					FriendlyWeight = (int) p_Value;
					break;

				case 2096723555:
					CorpsTimeout = (int) p_Value;
					break;

				case 133234872:
					CorpsWeight = (int) p_Value;
					break;

				case 3473146361:
					CountCorpsesForAllTeams = (bool) p_Value;
					break;

				case 1766807212:
					InitialZoneRandomized = (bool) p_Value;
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
				case 3888167615:
					return EnemyWeight;

				case 365084578:
					return FriendlyWeight;

				case 2096723555:
					return CorpsTimeout;

				case 133234872:
					return CorpsWeight;

				case 3473146361:
					return CountCorpsesForAllTeams;

				case 1766807212:
					return InitialZoneRandomized;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3888167615:
					return typeof(FriendZoneEntityData).GetProperty(nameof(EnemyWeight));

				case 365084578:
					return typeof(FriendZoneEntityData).GetProperty(nameof(FriendlyWeight));

				case 2096723555:
					return typeof(FriendZoneEntityData).GetProperty(nameof(CorpsTimeout));

				case 133234872:
					return typeof(FriendZoneEntityData).GetProperty(nameof(CorpsWeight));

				case 3473146361:
					return typeof(FriendZoneEntityData).GetProperty(nameof(CountCorpsesForAllTeams));

				case 1766807212:
					return typeof(FriendZoneEntityData).GetProperty(nameof(InitialZoneRandomized));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
