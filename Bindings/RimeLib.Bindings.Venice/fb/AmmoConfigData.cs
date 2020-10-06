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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(36), ContainerStruct]
	public class AmmoConfigData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int MagazineCapacity { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int NumberOfMagazines { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint TraceFrequency { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint AmmoPickupMinAmount { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint AmmoPickupMaxAmount { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float AutoReplenishDelay { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int AmmoBagPickupAmount { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float AmmoBagPickupDelayMultiplier { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
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
