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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class GameSoundEntityData : 
		GameEntityData
	{
		protected CtrRef<SoundAsset> m_Sound = new CtrRef<SoundAsset>();
		[ContainerField(96), MemberInfoFlag(53), ContainerFieldNameHash(231353798), ContainerCtrRef]
		public CtrRef<SoundAsset> Sound { get { return m_Sound; } set { if (OnPropertyChanging("GameSoundEntityData." + nameof(Sound), this, m_Sound, value)) m_Sound = value; } } // 0x60 (96)
		
		protected bool m_PlayOnCreation = new bool();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2168204873)]
		public bool PlayOnCreation { get { return m_PlayOnCreation; } set { if (OnPropertyChanging("GameSoundEntityData." + nameof(PlayOnCreation), this, m_PlayOnCreation, value)) m_PlayOnCreation = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231353798:
					Sound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 2168204873:
					PlayOnCreation = (bool) p_Value;
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
				case 231353798:
					return Sound;

				case 2168204873:
					return PlayOnCreation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231353798:
					return typeof(GameSoundEntityData).GetProperty(nameof(Sound));

				case 2168204873:
					return typeof(GameSoundEntityData).GetProperty(nameof(PlayOnCreation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
