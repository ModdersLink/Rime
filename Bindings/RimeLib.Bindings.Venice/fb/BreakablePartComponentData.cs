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
	[ContainerType(16)]
	public class BreakablePartComponentData : 
		DestructionPartComponentData
	{
		protected uint m_HealthPercentage = new uint();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(3168756705)]
		public uint HealthPercentage { get { return m_HealthPercentage; } set { if (OnPropertyChanging("BreakablePartComponentData." + nameof(HealthPercentage), this, m_HealthPercentage, value)) m_HealthPercentage = value; } } // 0x70 (112)
		
		protected bool m_Collapsable = new bool();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(3767665825)]
		public bool Collapsable { get { return m_Collapsable; } set { if (OnPropertyChanging("BreakablePartComponentData." + nameof(Collapsable), this, m_Collapsable, value)) m_Collapsable = value; } } // 0x74 (116)
		
		protected bool m_DestroyNearbyStaticEntities = new bool();
		[ContainerField(117), LayoutImmutable, Blittable, ContainerFieldNameHash(986094273)]
		public bool DestroyNearbyStaticEntities { get { return m_DestroyNearbyStaticEntities; } set { if (OnPropertyChanging("BreakablePartComponentData." + nameof(DestroyNearbyStaticEntities), this, m_DestroyNearbyStaticEntities, value)) m_DestroyNearbyStaticEntities = value; } } // 0x75 (117)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3168756705:
					HealthPercentage = (uint) p_Value;
					break;

				case 3767665825:
					Collapsable = (bool) p_Value;
					break;

				case 986094273:
					DestroyNearbyStaticEntities = (bool) p_Value;
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
				case 3168756705:
					return HealthPercentage;

				case 3767665825:
					return Collapsable;

				case 986094273:
					return DestroyNearbyStaticEntities;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3168756705:
					return typeof(BreakablePartComponentData).GetProperty(nameof(HealthPercentage));

				case 3767665825:
					return typeof(BreakablePartComponentData).GetProperty(nameof(Collapsable));

				case 986094273:
					return typeof(BreakablePartComponentData).GetProperty(nameof(DestroyNearbyStaticEntities));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
