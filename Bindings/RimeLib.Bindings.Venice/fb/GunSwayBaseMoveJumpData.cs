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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 140)]
	public class GunSwayBaseMoveJumpData : FrostbiteContainer
	{
		[ContainerField(Name: "BaseValue", Offset: 0, NameHash: 1681448475, Flags: 41)]
		public GunSwayDispersionData BaseValue { get; set; } = new GunSwayDispersionData(); // 0x0 (0)
		
		[ContainerField(Name: "Moving", Offset: 16, NameHash: 2636043921, Flags: 41)]
		public GunSwayDispersionData Moving { get; set; } = new GunSwayDispersionData(); // 0x10 (16)
		
		[ContainerField(Name: "Jumping", Offset: 32, NameHash: 198865735, Flags: 41)]
		public GunSwayDispersionData Jumping { get; set; } = new GunSwayDispersionData(); // 0x20 (32)
		
		[ContainerField(Name: "Sprinting", Offset: 48, NameHash: 3687360775, Flags: 41)]
		public GunSwayDispersionData Sprinting { get; set; } = new GunSwayDispersionData(); // 0x30 (48)
		
		[ContainerField(Name: "VaultingSmallObject", Offset: 64, NameHash: 4088072437, Flags: 41)]
		public GunSwayDispersionData VaultingSmallObject { get; set; } = new GunSwayDispersionData(); // 0x40 (64)
		
		[ContainerField(Name: "VaultingMediumObject", Offset: 80, NameHash: 4114061975, Flags: 41)]
		public GunSwayDispersionData VaultingMediumObject { get; set; } = new GunSwayDispersionData(); // 0x50 (80)
		
		[ContainerField(Name: "Recoil", Offset: 96, NameHash: 3293845435, Flags: 41)]
		public GunSwayRecoilData Recoil { get; set; } = new GunSwayRecoilData(); // 0x60 (96)
		
		[ContainerField(Name: "GunSwayLag", Offset: 120, NameHash: 938474159, Flags: 41)]
		public GunSwayLagData GunSwayLag { get; set; } = new GunSwayLagData(); // 0x78 (120)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1681448475:
					BaseValue = (GunSwayDispersionData) p_Value;
					break;

				case 2636043921:
					Moving = (GunSwayDispersionData) p_Value;
					break;

				case 198865735:
					Jumping = (GunSwayDispersionData) p_Value;
					break;

				case 3687360775:
					Sprinting = (GunSwayDispersionData) p_Value;
					break;

				case 4088072437:
					VaultingSmallObject = (GunSwayDispersionData) p_Value;
					break;

				case 4114061975:
					VaultingMediumObject = (GunSwayDispersionData) p_Value;
					break;

				case 3293845435:
					Recoil = (GunSwayRecoilData) p_Value;
					break;

				case 938474159:
					GunSwayLag = (GunSwayLagData) p_Value;
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
				case 1681448475:
					return BaseValue;

				case 2636043921:
					return Moving;

				case 198865735:
					return Jumping;

				case 3687360775:
					return Sprinting;

				case 4088072437:
					return VaultingSmallObject;

				case 4114061975:
					return VaultingMediumObject;

				case 3293845435:
					return Recoil;

				case 938474159:
					return GunSwayLag;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1681448475:
					return typeof(GunSwayBaseMoveJumpData).GetProperty(nameof(BaseValue));

				case 2636043921:
					return typeof(GunSwayBaseMoveJumpData).GetProperty(nameof(Moving));

				case 198865735:
					return typeof(GunSwayBaseMoveJumpData).GetProperty(nameof(Jumping));

				case 3687360775:
					return typeof(GunSwayBaseMoveJumpData).GetProperty(nameof(Sprinting));

				case 4088072437:
					return typeof(GunSwayBaseMoveJumpData).GetProperty(nameof(VaultingSmallObject));

				case 4114061975:
					return typeof(GunSwayBaseMoveJumpData).GetProperty(nameof(VaultingMediumObject));

				case 3293845435:
					return typeof(GunSwayBaseMoveJumpData).GetProperty(nameof(Recoil));

				case 938474159:
					return typeof(GunSwayBaseMoveJumpData).GetProperty(nameof(GunSwayLag));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
