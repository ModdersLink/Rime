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
	public class GearBagSpec : 
		Asset
	{
		protected uint m_MaxPrimaryWeapons = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(696409228)]
		public uint MaxPrimaryWeapons { get { return m_MaxPrimaryWeapons; } set { if (OnPropertyChanging("GearBagSpec." + nameof(MaxPrimaryWeapons), this, m_MaxPrimaryWeapons, value)) m_MaxPrimaryWeapons = value; } } // 0xC (12)
		
		protected uint m_MaxSecondaryWeapons = new uint();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(1632631226)]
		public uint MaxSecondaryWeapons { get { return m_MaxSecondaryWeapons; } set { if (OnPropertyChanging("GearBagSpec." + nameof(MaxSecondaryWeapons), this, m_MaxSecondaryWeapons, value)) m_MaxSecondaryWeapons = value; } } // 0x10 (16)
		
		protected uint m_MaxSidearms = new uint();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(2534033543)]
		public uint MaxSidearms { get { return m_MaxSidearms; } set { if (OnPropertyChanging("GearBagSpec." + nameof(MaxSidearms), this, m_MaxSidearms, value)) m_MaxSidearms = value; } } // 0x14 (20)
		
		protected uint m_MaxGadgetsPerSlot = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(3632758453)]
		public uint MaxGadgetsPerSlot { get { return m_MaxGadgetsPerSlot; } set { if (OnPropertyChanging("GearBagSpec." + nameof(MaxGadgetsPerSlot), this, m_MaxGadgetsPerSlot, value)) m_MaxGadgetsPerSlot = value; } } // 0x18 (24)
		
		protected uint m_GadgetSlots = new uint();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(1495102982)]
		public uint GadgetSlots { get { return m_GadgetSlots; } set { if (OnPropertyChanging("GearBagSpec." + nameof(GadgetSlots), this, m_GadgetSlots, value)) m_GadgetSlots = value; } } // 0x1C (28)
		
		protected RefArray<GearBagSpec> m_ChildSpecs = new RefArray<GearBagSpec>();
		[ContainerField(32), ContainerFieldNameHash(220592377)]
		public RefArray<GearBagSpec> ChildSpecs { get { return m_ChildSpecs; } set { if (OnPropertyChanging("GearBagSpec." + nameof(ChildSpecs), this, m_ChildSpecs, value)) m_ChildSpecs = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 696409228:
					MaxPrimaryWeapons = (uint) p_Value;
					break;

				case 1632631226:
					MaxSecondaryWeapons = (uint) p_Value;
					break;

				case 2534033543:
					MaxSidearms = (uint) p_Value;
					break;

				case 3632758453:
					MaxGadgetsPerSlot = (uint) p_Value;
					break;

				case 1495102982:
					GadgetSlots = (uint) p_Value;
					break;

				case 220592377:
					ChildSpecs = (RefArray<GearBagSpec>) p_Value;
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
				case 696409228:
					return MaxPrimaryWeapons;

				case 1632631226:
					return MaxSecondaryWeapons;

				case 2534033543:
					return MaxSidearms;

				case 3632758453:
					return MaxGadgetsPerSlot;

				case 1495102982:
					return GadgetSlots;

				case 220592377:
					return ChildSpecs;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 696409228:
					return typeof(GearBagSpec).GetProperty(nameof(MaxPrimaryWeapons));

				case 1632631226:
					return typeof(GearBagSpec).GetProperty(nameof(MaxSecondaryWeapons));

				case 2534033543:
					return typeof(GearBagSpec).GetProperty(nameof(MaxSidearms));

				case 3632758453:
					return typeof(GearBagSpec).GetProperty(nameof(MaxGadgetsPerSlot));

				case 1495102982:
					return typeof(GearBagSpec).GetProperty(nameof(GadgetSlots));

				case 220592377:
					return typeof(GearBagSpec).GetProperty(nameof(ChildSpecs));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
