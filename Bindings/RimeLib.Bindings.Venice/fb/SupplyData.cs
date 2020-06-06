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
	public class SupplyData : FrostbiteContainer
	{
		[ContainerField(0)]
		public SupplyUnitSphereData Healing { get; set; } = new SupplyUnitSphereData(); // 0x0 (0)
		
		[ContainerField(20)]
		public SupplyUnitSphereData Ammo { get; set; } = new SupplyUnitSphereData(); // 0x14 (20)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool SupplyVehicles { get; set; } // 0x28 (40)
		
		[ContainerField(41), LayoutImmutable, Blittable]
		public bool SupplySoldiers { get; set; } // 0x29 (41)
		
		[ContainerField(42), LayoutImmutable, Blittable]
		public bool TeamSpecific { get; set; } // 0x2A (42)
		
		[ContainerField(43), LayoutImmutable, Blittable]
		public bool ExcludeSelf { get; set; } // 0x2B (43)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2008873029:
					Healing = (SupplyUnitSphereData) p_Value;
					break;

				case 2088639403:
					Ammo = (SupplyUnitSphereData) p_Value;
					break;

				case 827934845:
					SupplyVehicles = (bool) p_Value;
					break;

				case 1875571247:
					SupplySoldiers = (bool) p_Value;
					break;

				case 3883487160:
					TeamSpecific = (bool) p_Value;
					break;

				case 1064218111:
					ExcludeSelf = (bool) p_Value;
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
				case 2008873029:
					return Healing;

				case 2088639403:
					return Ammo;

				case 827934845:
					return SupplyVehicles;

				case 1875571247:
					return SupplySoldiers;

				case 3883487160:
					return TeamSpecific;

				case 1064218111:
					return ExcludeSelf;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2008873029:
					return typeof(SupplyData).GetProperty(nameof(Healing));

				case 2088639403:
					return typeof(SupplyData).GetProperty(nameof(Ammo));

				case 827934845:
					return typeof(SupplyData).GetProperty(nameof(SupplyVehicles));

				case 1875571247:
					return typeof(SupplyData).GetProperty(nameof(SupplySoldiers));

				case 3883487160:
					return typeof(SupplyData).GetProperty(nameof(TeamSpecific));

				case 1064218111:
					return typeof(SupplyData).GetProperty(nameof(ExcludeSelf));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
