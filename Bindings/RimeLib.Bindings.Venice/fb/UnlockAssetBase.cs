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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class UnlockAssetBase : 
		Asset
	{
		protected uint m_UnlockScore = new uint();
		[ContainerField(Name: "UnlockScore", Offset: 12, NameHash: 4124076605, Flags: 49421), LayoutImmutable, Blittable]
		public uint UnlockScore { get { return m_UnlockScore; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(UnlockScore), this, m_UnlockScore, value)) m_UnlockScore = value; } } // 0xC (12)
		
		protected CtrRef<UnlockUserDataBase> m_UnlockUserData = new CtrRef<UnlockUserDataBase>();
		[ContainerField(Name: "UnlockUserData", Offset: 16, NameHash: 334679412, Flags: 53)]
		public CtrRef<UnlockUserDataBase> UnlockUserData { get { return m_UnlockUserData; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(UnlockUserData), this, m_UnlockUserData, value)) m_UnlockUserData = value; } } // 0x10 (16)
		
		protected string m_DebugUnlockId = string.Empty;
		[ContainerField(Name: "DebugUnlockId", Offset: 20, NameHash: 2468774985, Flags: 16509), LayoutImmutable]
		public string DebugUnlockId { get { return m_DebugUnlockId; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(DebugUnlockId), this, m_DebugUnlockId, value)) m_DebugUnlockId = value; } } // 0x14 (20)
		
		protected uint m_Identifier = new uint();
		[ContainerField(Name: "Identifier", Offset: 24, NameHash: 3512790342, Flags: 49421), LayoutImmutable, Blittable]
		public uint Identifier { get { return m_Identifier; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(Identifier), this, m_Identifier, value)) m_Identifier = value; } } // 0x18 (24)
		
		protected UnlockAvailability m_AvailableForPlayer = new UnlockAvailability();
		[ContainerField(Name: "AvailableForPlayer", Offset: 28, NameHash: 3398545844, Flags: 137)]
		public UnlockAvailability AvailableForPlayer { get { return m_AvailableForPlayer; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(AvailableForPlayer), this, m_AvailableForPlayer, value)) m_AvailableForPlayer = value; } } // 0x1C (28)
		
		protected CtrRef<UnlockAssetBase> m_NextLevelUnlockAsset = new CtrRef<UnlockAssetBase>();
		[ContainerField(Name: "NextLevelUnlockAsset", Offset: 32, NameHash: 3071818964, Flags: 53)]
		public CtrRef<UnlockAssetBase> NextLevelUnlockAsset { get { return m_NextLevelUnlockAsset; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(NextLevelUnlockAsset), this, m_NextLevelUnlockAsset, value)) m_NextLevelUnlockAsset = value; } } // 0x20 (32)
		
		protected bool m_AutoAvailable = new bool();
		[ContainerField(Name: "AutoAvailable", Offset: 36, NameHash: 1619872979, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoAvailable { get { return m_AutoAvailable; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(AutoAvailable), this, m_AutoAvailable, value)) m_AutoAvailable = value; } } // 0x24 (36)
		
		protected bool m_HiddenInProgression = new bool();
		[ContainerField(Name: "HiddenInProgression", Offset: 37, NameHash: 1800564573, Flags: 49325), LayoutImmutable, Blittable]
		public bool HiddenInProgression { get { return m_HiddenInProgression; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(HiddenInProgression), this, m_HiddenInProgression, value)) m_HiddenInProgression = value; } } // 0x25 (37)
		
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
