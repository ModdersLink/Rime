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
	public class GearBagSpec : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint MaxPrimaryWeapons { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint MaxSecondaryWeapons { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint MaxSidearms { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint MaxGadgetsPerSlot { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint GadgetSlots { get; set; } // 0x1C (28)
		
		[ContainerField(32)]
		public RefArray<GearBagSpec> ChildSpecs { get; set; } = new RefArray<GearBagSpec>(); // 0x20 (32)
		
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
