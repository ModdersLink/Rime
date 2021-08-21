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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 36)]
	public class AmmoConfigData : FrostbiteContainer
	{
		[ContainerField(Name: "MagazineCapacity", Offset: 0, NameHash: 1634670339, Flags: 49405), LayoutImmutable, Blittable]
		public int MagazineCapacity { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "NumberOfMagazines", Offset: 4, NameHash: 2684433166, Flags: 49405), LayoutImmutable, Blittable]
		public int NumberOfMagazines { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "TraceFrequency", Offset: 8, NameHash: 1101083936, Flags: 49421), LayoutImmutable, Blittable]
		public uint TraceFrequency { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "AmmoPickupMinAmount", Offset: 12, NameHash: 1049056889, Flags: 49421), LayoutImmutable, Blittable]
		public uint AmmoPickupMinAmount { get; set; } // 0xC (12)
		
		[ContainerField(Name: "AmmoPickupMaxAmount", Offset: 16, NameHash: 1825618791, Flags: 49421), LayoutImmutable, Blittable]
		public uint AmmoPickupMaxAmount { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "AutoReplenishDelay", Offset: 20, NameHash: 2884902349, Flags: 49469), LayoutImmutable, Blittable]
		public float AutoReplenishDelay { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "AmmoBagPickupAmount", Offset: 24, NameHash: 3198605367, Flags: 49405), LayoutImmutable, Blittable]
		public int AmmoBagPickupAmount { get; set; } // 0x18 (24)
		
		[ContainerField(Name: "AmmoBagPickupDelayMultiplier", Offset: 28, NameHash: 3753352741, Flags: 49469), LayoutImmutable, Blittable]
		public float AmmoBagPickupDelayMultiplier { get; set; } // 0x1C (28)
		
		[ContainerField(Name: "AutoReplenishMagazine", Offset: 32, NameHash: 3199294250, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoReplenishMagazine { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1634670339:
					MagazineCapacity = (int) p_Value;
					break;

				case 2684433166:
					NumberOfMagazines = (int) p_Value;
					break;

				case 1101083936:
					TraceFrequency = (uint) p_Value;
					break;

				case 1049056889:
					AmmoPickupMinAmount = (uint) p_Value;
					break;

				case 1825618791:
					AmmoPickupMaxAmount = (uint) p_Value;
					break;

				case 2884902349:
					AutoReplenishDelay = (float) p_Value;
					break;

				case 3198605367:
					AmmoBagPickupAmount = (int) p_Value;
					break;

				case 3753352741:
					AmmoBagPickupDelayMultiplier = (float) p_Value;
					break;

				case 3199294250:
					AutoReplenishMagazine = (bool) p_Value;
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
				case 1634670339:
					return MagazineCapacity;

				case 2684433166:
					return NumberOfMagazines;

				case 1101083936:
					return TraceFrequency;

				case 1049056889:
					return AmmoPickupMinAmount;

				case 1825618791:
					return AmmoPickupMaxAmount;

				case 2884902349:
					return AutoReplenishDelay;

				case 3198605367:
					return AmmoBagPickupAmount;

				case 3753352741:
					return AmmoBagPickupDelayMultiplier;

				case 3199294250:
					return AutoReplenishMagazine;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1634670339:
					return typeof(AmmoConfigData).GetProperty(nameof(MagazineCapacity));

				case 2684433166:
					return typeof(AmmoConfigData).GetProperty(nameof(NumberOfMagazines));

				case 1101083936:
					return typeof(AmmoConfigData).GetProperty(nameof(TraceFrequency));

				case 1049056889:
					return typeof(AmmoConfigData).GetProperty(nameof(AmmoPickupMinAmount));

				case 1825618791:
					return typeof(AmmoConfigData).GetProperty(nameof(AmmoPickupMaxAmount));

				case 2884902349:
					return typeof(AmmoConfigData).GetProperty(nameof(AutoReplenishDelay));

				case 3198605367:
					return typeof(AmmoConfigData).GetProperty(nameof(AmmoBagPickupAmount));

				case 3753352741:
					return typeof(AmmoConfigData).GetProperty(nameof(AmmoBagPickupDelayMultiplier));

				case 3199294250:
					return typeof(AmmoConfigData).GetProperty(nameof(AutoReplenishMagazine));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
