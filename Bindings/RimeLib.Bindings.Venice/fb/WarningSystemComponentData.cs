///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class WarningSystemComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<SoundAsset> AimWarnSoundEffect { get; set; } = new CtrRef<SoundAsset>(); // 0x60 (96)
		
		[ContainerField(100)]
		public CtrRef<SoundAsset> MissileWarnSoundEffect { get; set; } = new CtrRef<SoundAsset>(); // 0x64 (100)
		
		[ContainerField(104)]
		public CtrRef<SoundAsset> LowHealthWarnSoundEffect { get; set; } = new CtrRef<SoundAsset>(); // 0x68 (104)
		
		[ContainerField(108)]
		public CtrRef<SoundAsset> LockingWarnSoundEffect { get; set; } = new CtrRef<SoundAsset>(); // 0x6C (108)
		
		[ContainerField(112)]
		public CtrRef<SoundAsset> LockedWarnSoundEffect { get; set; } = new CtrRef<SoundAsset>(); // 0x70 (112)
		
		[ContainerField(116)]
		public WarningPlayerType PlayerType { get; set; } = new WarningPlayerType(); // 0x74 (116)
		
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
