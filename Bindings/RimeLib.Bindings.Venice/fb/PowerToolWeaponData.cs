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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class PowerToolWeaponData : 
		WeaponData
	{
		protected CtrRef<SoundAsset> m_RepairSound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "RepairSound", Offset: 16, NameHash: 3648939963, Flags: 53)]
		public CtrRef<SoundAsset> RepairSound { get { return m_RepairSound; } set { if (OnPropertyChanging("PowerToolWeaponData." + nameof(RepairSound), this, m_RepairSound, value)) m_RepairSound = value; } } // 0x10 (16)
		
		protected CtrRef<SoundAsset> m_RepairCompletedSound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "RepairCompletedSound", Offset: 20, NameHash: 1421478710, Flags: 53)]
		public CtrRef<SoundAsset> RepairCompletedSound { get { return m_RepairCompletedSound; } set { if (OnPropertyChanging("PowerToolWeaponData." + nameof(RepairCompletedSound), this, m_RepairCompletedSound, value)) m_RepairCompletedSound = value; } } // 0x14 (20)
		
		protected CtrRef<SoundAsset> m_DamageSound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "DamageSound", Offset: 24, NameHash: 2233576717, Flags: 53)]
		public CtrRef<SoundAsset> DamageSound { get { return m_DamageSound; } set { if (OnPropertyChanging("PowerToolWeaponData." + nameof(DamageSound), this, m_DamageSound, value)) m_DamageSound = value; } } // 0x18 (24)
		
		protected CtrRef<MaterialContainerPair> m_RepairMaterialPair = new CtrRef<MaterialContainerPair>();
		[ContainerField(Name: "RepairMaterialPair", Offset: 28, NameHash: 3188237177, Flags: 53)]
		public CtrRef<MaterialContainerPair> RepairMaterialPair { get { return m_RepairMaterialPair; } set { if (OnPropertyChanging("PowerToolWeaponData." + nameof(RepairMaterialPair), this, m_RepairMaterialPair, value)) m_RepairMaterialPair = value; } } // 0x1C (28)
		
		protected bool m_PlayFireEffectOnRepairOnly = new bool();
		[ContainerField(Name: "PlayFireEffectOnRepairOnly", Offset: 32, NameHash: 295476486, Flags: 49325), LayoutImmutable, Blittable]
		public bool PlayFireEffectOnRepairOnly { get { return m_PlayFireEffectOnRepairOnly; } set { if (OnPropertyChanging("PowerToolWeaponData." + nameof(PlayFireEffectOnRepairOnly), this, m_PlayFireEffectOnRepairOnly, value)) m_PlayFireEffectOnRepairOnly = value; } } // 0x20 (32)
		
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
