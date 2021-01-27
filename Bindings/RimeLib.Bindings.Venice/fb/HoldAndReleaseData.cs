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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 28)]
	public class HoldAndReleaseData : FrostbiteContainer
	{
		[ContainerField(Name: "MaxHoldTime", Offset: 0, NameHash: 2026966059, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxHoldTime { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "MinPowerModifier", Offset: 4, NameHash: 1396894279, Flags: 49469), LayoutImmutable, Blittable]
		public float MinPowerModifier { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "MaxPowerModifier", Offset: 8, NameHash: 4200451609, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxPowerModifier { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "PowerIncreasePerSecond", Offset: 12, NameHash: 1198568329, Flags: 49469), LayoutImmutable, Blittable]
		public float PowerIncreasePerSecond { get; set; } // 0xC (12)
		
		[ContainerField(Name: "Delay", Offset: 16, NameHash: 208768368, Flags: 49469), LayoutImmutable, Blittable]
		public float Delay { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "KilledHoldingPowerModifier", Offset: 20, NameHash: 1213290625, Flags: 49469), LayoutImmutable, Blittable]
		public float KilledHoldingPowerModifier { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "ForceFireWhenKilledHolding", Offset: 24, NameHash: 2172080088, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForceFireWhenKilledHolding { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2026966059:
					MaxHoldTime = (float) p_Value;
					break;

				case 1396894279:
					MinPowerModifier = (float) p_Value;
					break;

				case 4200451609:
					MaxPowerModifier = (float) p_Value;
					break;

				case 1198568329:
					PowerIncreasePerSecond = (float) p_Value;
					break;

				case 208768368:
					Delay = (float) p_Value;
					break;

				case 1213290625:
					KilledHoldingPowerModifier = (float) p_Value;
					break;

				case 2172080088:
					ForceFireWhenKilledHolding = (bool) p_Value;
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
				case 2026966059:
					return MaxHoldTime;

				case 1396894279:
					return MinPowerModifier;

				case 4200451609:
					return MaxPowerModifier;

				case 1198568329:
					return PowerIncreasePerSecond;

				case 208768368:
					return Delay;

				case 1213290625:
					return KilledHoldingPowerModifier;

				case 2172080088:
					return ForceFireWhenKilledHolding;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2026966059:
					return typeof(HoldAndReleaseData).GetProperty(nameof(MaxHoldTime));

				case 1396894279:
					return typeof(HoldAndReleaseData).GetProperty(nameof(MinPowerModifier));

				case 4200451609:
					return typeof(HoldAndReleaseData).GetProperty(nameof(MaxPowerModifier));

				case 1198568329:
					return typeof(HoldAndReleaseData).GetProperty(nameof(PowerIncreasePerSecond));

				case 208768368:
					return typeof(HoldAndReleaseData).GetProperty(nameof(Delay));

				case 1213290625:
					return typeof(HoldAndReleaseData).GetProperty(nameof(KilledHoldingPowerModifier));

				case 2172080088:
					return typeof(HoldAndReleaseData).GetProperty(nameof(ForceFireWhenKilledHolding));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
