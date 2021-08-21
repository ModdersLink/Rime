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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 44)]
	public class SupplyData : FrostbiteContainer
	{
		[ContainerField(Name: "Healing", Offset: 0, NameHash: 2008873029, Flags: 41)]
		public SupplyUnitSphereData Healing { get; set; } = new SupplyUnitSphereData(); // 0x0 (0)
		
		[ContainerField(Name: "Ammo", Offset: 20, NameHash: 2088639403, Flags: 41)]
		public SupplyUnitSphereData Ammo { get; set; } = new SupplyUnitSphereData(); // 0x14 (20)
		
		[ContainerField(Name: "SupplyVehicles", Offset: 40, NameHash: 827934845, Flags: 49325), LayoutImmutable, Blittable]
		public bool SupplyVehicles { get; set; } // 0x28 (40)
		
		[ContainerField(Name: "SupplySoldiers", Offset: 41, NameHash: 1875571247, Flags: 49325), LayoutImmutable, Blittable]
		public bool SupplySoldiers { get; set; } // 0x29 (41)
		
		[ContainerField(Name: "TeamSpecific", Offset: 42, NameHash: 3883487160, Flags: 49325), LayoutImmutable, Blittable]
		public bool TeamSpecific { get; set; } // 0x2A (42)
		
		[ContainerField(Name: "ExcludeSelf", Offset: 43, NameHash: 1064218111, Flags: 49325), LayoutImmutable, Blittable]
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
