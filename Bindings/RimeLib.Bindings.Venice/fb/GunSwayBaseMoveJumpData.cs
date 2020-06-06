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
	public class GunSwayBaseMoveJumpData : FrostbiteContainer
	{
		[ContainerField(0)]
		public GunSwayDispersionData BaseValue { get; set; } = new GunSwayDispersionData(); // 0x0 (0)
		
		[ContainerField(16)]
		public GunSwayDispersionData Moving { get; set; } = new GunSwayDispersionData(); // 0x10 (16)
		
		[ContainerField(32)]
		public GunSwayDispersionData Jumping { get; set; } = new GunSwayDispersionData(); // 0x20 (32)
		
		[ContainerField(48)]
		public GunSwayDispersionData Sprinting { get; set; } = new GunSwayDispersionData(); // 0x30 (48)
		
		[ContainerField(64)]
		public GunSwayDispersionData VaultingSmallObject { get; set; } = new GunSwayDispersionData(); // 0x40 (64)
		
		[ContainerField(80)]
		public GunSwayDispersionData VaultingMediumObject { get; set; } = new GunSwayDispersionData(); // 0x50 (80)
		
		[ContainerField(96)]
		public GunSwayRecoilData Recoil { get; set; } = new GunSwayRecoilData(); // 0x60 (96)
		
		[ContainerField(120)]
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
