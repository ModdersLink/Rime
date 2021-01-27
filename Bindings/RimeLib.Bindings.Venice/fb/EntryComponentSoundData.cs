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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class EntryComponentSoundData : 
		DataContainer
	{
		protected List<StanceSwitchSoundData> m_StanceSounds = new List<StanceSwitchSoundData>();
		[ContainerField(Name: "StanceSounds", Offset: 8, NameHash: 3318640379, Flags: 65)]
		public List<StanceSwitchSoundData> StanceSounds { get { return m_StanceSounds; } set { if (OnPropertyChanging("EntryComponentSoundData." + nameof(StanceSounds), this, m_StanceSounds, value)) m_StanceSounds = value; } } // 0x8 (8)
		
		protected CtrRef<SoundAsset> m_StanceSwitchSound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "StanceSwitchSound", Offset: 12, NameHash: 865104730, Flags: 53)]
		public CtrRef<SoundAsset> StanceSwitchSound { get { return m_StanceSwitchSound; } set { if (OnPropertyChanging("EntryComponentSoundData." + nameof(StanceSwitchSound), this, m_StanceSwitchSound, value)) m_StanceSwitchSound = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3318640379:
					StanceSounds = (List<StanceSwitchSoundData>) p_Value;
					break;

				case 865104730:
					StanceSwitchSound = (CtrRef<SoundAsset>) p_Value;
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
				case 3318640379:
					return StanceSounds;

				case 865104730:
					return StanceSwitchSound;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3318640379:
					return typeof(EntryComponentSoundData).GetProperty(nameof(StanceSounds));

				case 865104730:
					return typeof(EntryComponentSoundData).GetProperty(nameof(StanceSwitchSound));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
