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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class MaterialSoldierSoundSettings : 
		DataContainer
	{
		protected CtrRef<SoundAsset> m_FootStepSound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "FootStepSound", Offset: 8, NameHash: 556404134, Flags: 53)]
		public CtrRef<SoundAsset> FootStepSound { get { return m_FootStepSound; } set { if (OnPropertyChanging("MaterialSoldierSoundSettings." + nameof(FootStepSound), this, m_FootStepSound, value)) m_FootStepSound = value; } } // 0x8 (8)
		
		protected CtrRef<SoundAsset> m_ProneSound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "ProneSound", Offset: 12, NameHash: 130192352, Flags: 53)]
		public CtrRef<SoundAsset> ProneSound { get { return m_ProneSound; } set { if (OnPropertyChanging("MaterialSoldierSoundSettings." + nameof(ProneSound), this, m_ProneSound, value)) m_ProneSound = value; } } // 0xC (12)
		
		protected CtrRef<SoundAsset> m_LandSound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "LandSound", Offset: 16, NameHash: 3226502081, Flags: 53)]
		public CtrRef<SoundAsset> LandSound { get { return m_LandSound; } set { if (OnPropertyChanging("MaterialSoldierSoundSettings." + nameof(LandSound), this, m_LandSound, value)) m_LandSound = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 556404134:
					FootStepSound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 130192352:
					ProneSound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 3226502081:
					LandSound = (CtrRef<SoundAsset>) p_Value;
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
				case 556404134:
					return FootStepSound;

				case 130192352:
					return ProneSound;

				case 3226502081:
					return LandSound;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 556404134:
					return typeof(MaterialSoldierSoundSettings).GetProperty(nameof(FootStepSound));

				case 130192352:
					return typeof(MaterialSoldierSoundSettings).GetProperty(nameof(ProneSound));

				case 3226502081:
					return typeof(MaterialSoldierSoundSettings).GetProperty(nameof(LandSound));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
