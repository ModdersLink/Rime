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
    [ContainerType(4)]
	public class UnlockAssetBase : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint UnlockScore { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<UnlockUserDataBase> UnlockUserData { get; set; } = new CtrRef<UnlockUserDataBase>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string DebugUnlockId { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint Identifier { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public UnlockAvailability AvailableForPlayer { get; set; } = new UnlockAvailability(); // 0x1C (28)
		
		[ContainerField(32)]
		public CtrRef<UnlockAssetBase> NextLevelUnlockAsset { get; set; } = new CtrRef<UnlockAssetBase>(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool AutoAvailable { get; set; } // 0x24 (36)
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool HiddenInProgression { get; set; } // 0x25 (37)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4124076605:
					UnlockScore = (uint) p_Value;
					break;

				case 334679412:
					UnlockUserData = (CtrRef<UnlockUserDataBase>) p_Value;
					break;

				case 2468774985:
					DebugUnlockId = (string) p_Value;
					break;

				case 3512790342:
					Identifier = (uint) p_Value;
					break;

				case 3398545844:
					AvailableForPlayer = (UnlockAvailability) Enum.ToObject(typeof(UnlockAvailability), p_Value);
					break;

				case 3071818964:
					NextLevelUnlockAsset = (CtrRef<UnlockAssetBase>) p_Value;
					break;

				case 1619872979:
					AutoAvailable = (bool) p_Value;
					break;

				case 1800564573:
					HiddenInProgression = (bool) p_Value;
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
				case 4124076605:
					return UnlockScore;

				case 334679412:
					return UnlockUserData;

				case 2468774985:
					return DebugUnlockId;

				case 3512790342:
					return Identifier;

				case 3398545844:
					return AvailableForPlayer;

				case 3071818964:
					return NextLevelUnlockAsset;

				case 1619872979:
					return AutoAvailable;

				case 1800564573:
					return HiddenInProgression;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4124076605:
					return typeof(UnlockAssetBase).GetProperty(nameof(UnlockScore));

				case 334679412:
					return typeof(UnlockAssetBase).GetProperty(nameof(UnlockUserData));

				case 2468774985:
					return typeof(UnlockAssetBase).GetProperty(nameof(DebugUnlockId));

				case 3512790342:
					return typeof(UnlockAssetBase).GetProperty(nameof(Identifier));

				case 3398545844:
					return typeof(UnlockAssetBase).GetProperty(nameof(AvailableForPlayer));

				case 3071818964:
					return typeof(UnlockAssetBase).GetProperty(nameof(NextLevelUnlockAsset));

				case 1619872979:
					return typeof(UnlockAssetBase).GetProperty(nameof(AutoAvailable));

				case 1800564573:
					return typeof(UnlockAssetBase).GetProperty(nameof(HiddenInProgression));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
