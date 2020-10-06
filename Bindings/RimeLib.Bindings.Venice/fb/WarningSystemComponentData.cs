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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(128), ContainerClass]
	public class WarningSystemComponentData : 
		ComponentData
	{
		protected CtrRef<SoundAsset> m_AimWarnSoundEffect = new CtrRef<SoundAsset>();
		[ContainerField(96), MemberInfoFlag(53), ContainerFieldNameHash(2573535070), ContainerCtrRef]
		public CtrRef<SoundAsset> AimWarnSoundEffect { get { return m_AimWarnSoundEffect; } set { if (OnPropertyChanging("WarningSystemComponentData." + nameof(AimWarnSoundEffect), this, m_AimWarnSoundEffect, value)) m_AimWarnSoundEffect = value; } } // 0x60 (96)
		
		protected CtrRef<SoundAsset> m_MissileWarnSoundEffect = new CtrRef<SoundAsset>();
		[ContainerField(100), MemberInfoFlag(53), ContainerFieldNameHash(3117773919), ContainerCtrRef]
		public CtrRef<SoundAsset> MissileWarnSoundEffect { get { return m_MissileWarnSoundEffect; } set { if (OnPropertyChanging("WarningSystemComponentData." + nameof(MissileWarnSoundEffect), this, m_MissileWarnSoundEffect, value)) m_MissileWarnSoundEffect = value; } } // 0x64 (100)
		
		protected CtrRef<SoundAsset> m_LowHealthWarnSoundEffect = new CtrRef<SoundAsset>();
		[ContainerField(104), MemberInfoFlag(53), ContainerFieldNameHash(2886566771), ContainerCtrRef]
		public CtrRef<SoundAsset> LowHealthWarnSoundEffect { get { return m_LowHealthWarnSoundEffect; } set { if (OnPropertyChanging("WarningSystemComponentData." + nameof(LowHealthWarnSoundEffect), this, m_LowHealthWarnSoundEffect, value)) m_LowHealthWarnSoundEffect = value; } } // 0x68 (104)
		
		protected CtrRef<SoundAsset> m_LockingWarnSoundEffect = new CtrRef<SoundAsset>();
		[ContainerField(108), MemberInfoFlag(53), ContainerFieldNameHash(893923632), ContainerCtrRef]
		public CtrRef<SoundAsset> LockingWarnSoundEffect { get { return m_LockingWarnSoundEffect; } set { if (OnPropertyChanging("WarningSystemComponentData." + nameof(LockingWarnSoundEffect), this, m_LockingWarnSoundEffect, value)) m_LockingWarnSoundEffect = value; } } // 0x6C (108)
		
		protected CtrRef<SoundAsset> m_LockedWarnSoundEffect = new CtrRef<SoundAsset>();
		[ContainerField(112), MemberInfoFlag(53), ContainerFieldNameHash(1254781329), ContainerCtrRef]
		public CtrRef<SoundAsset> LockedWarnSoundEffect { get { return m_LockedWarnSoundEffect; } set { if (OnPropertyChanging("WarningSystemComponentData." + nameof(LockedWarnSoundEffect), this, m_LockedWarnSoundEffect, value)) m_LockedWarnSoundEffect = value; } } // 0x70 (112)
		
		protected WarningPlayerType m_PlayerType = new WarningPlayerType();
		[ContainerField(116), MemberInfoFlag(137), ContainerFieldNameHash(774572558)]
		public WarningPlayerType PlayerType { get { return m_PlayerType; } set { if (OnPropertyChanging("WarningSystemComponentData." + nameof(PlayerType), this, m_PlayerType, value)) m_PlayerType = value; } } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2573535070:
					AimWarnSoundEffect = (CtrRef<SoundAsset>) p_Value;
					break;

				case 3117773919:
					MissileWarnSoundEffect = (CtrRef<SoundAsset>) p_Value;
					break;

				case 2886566771:
					LowHealthWarnSoundEffect = (CtrRef<SoundAsset>) p_Value;
					break;

				case 893923632:
					LockingWarnSoundEffect = (CtrRef<SoundAsset>) p_Value;
					break;

				case 1254781329:
					LockedWarnSoundEffect = (CtrRef<SoundAsset>) p_Value;
					break;

				case 774572558:
					PlayerType = (WarningPlayerType) Enum.ToObject(typeof(WarningPlayerType), p_Value);
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
				case 2573535070:
					return AimWarnSoundEffect;

				case 3117773919:
					return MissileWarnSoundEffect;

				case 2886566771:
					return LowHealthWarnSoundEffect;

				case 893923632:
					return LockingWarnSoundEffect;

				case 1254781329:
					return LockedWarnSoundEffect;

				case 774572558:
					return PlayerType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2573535070:
					return typeof(WarningSystemComponentData).GetProperty(nameof(AimWarnSoundEffect));

				case 3117773919:
					return typeof(WarningSystemComponentData).GetProperty(nameof(MissileWarnSoundEffect));

				case 2886566771:
					return typeof(WarningSystemComponentData).GetProperty(nameof(LowHealthWarnSoundEffect));

				case 893923632:
					return typeof(WarningSystemComponentData).GetProperty(nameof(LockingWarnSoundEffect));

				case 1254781329:
					return typeof(WarningSystemComponentData).GetProperty(nameof(LockedWarnSoundEffect));

				case 774572558:
					return typeof(WarningSystemComponentData).GetProperty(nameof(PlayerType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
