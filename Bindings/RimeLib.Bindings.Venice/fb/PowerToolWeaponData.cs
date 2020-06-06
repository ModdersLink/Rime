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
	public class PowerToolWeaponData : 
		WeaponData
	{
		[ContainerField(16)]
		public CtrRef<SoundAsset> RepairSound { get; set; } = new CtrRef<SoundAsset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<SoundAsset> RepairCompletedSound { get; set; } = new CtrRef<SoundAsset>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<SoundAsset> DamageSound { get; set; } = new CtrRef<SoundAsset>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<MaterialContainerPair> RepairMaterialPair { get; set; } = new CtrRef<MaterialContainerPair>(); // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool PlayFireEffectOnRepairOnly { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3648939963:
					RepairSound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 1421478710:
					RepairCompletedSound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 2233576717:
					DamageSound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 3188237177:
					RepairMaterialPair = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 295476486:
					PlayFireEffectOnRepairOnly = (bool) p_Value;
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
				case 3648939963:
					return RepairSound;

				case 1421478710:
					return RepairCompletedSound;

				case 2233576717:
					return DamageSound;

				case 3188237177:
					return RepairMaterialPair;

				case 295476486:
					return PlayFireEffectOnRepairOnly;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3648939963:
					return typeof(PowerToolWeaponData).GetProperty(nameof(RepairSound));

				case 1421478710:
					return typeof(PowerToolWeaponData).GetProperty(nameof(RepairCompletedSound));

				case 2233576717:
					return typeof(PowerToolWeaponData).GetProperty(nameof(DamageSound));

				case 3188237177:
					return typeof(PowerToolWeaponData).GetProperty(nameof(RepairMaterialPair));

				case 295476486:
					return typeof(PowerToolWeaponData).GetProperty(nameof(PlayFireEffectOnRepairOnly));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
