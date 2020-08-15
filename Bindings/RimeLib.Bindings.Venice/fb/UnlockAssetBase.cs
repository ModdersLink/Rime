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
	[ContainerType(4)]
	public class UnlockAssetBase : 
		Asset
	{
		protected uint m_UnlockScore = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(4124076605)]
		public uint UnlockScore { get { return m_UnlockScore; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(UnlockScore), this, m_UnlockScore, value)) m_UnlockScore = value; } } // 0xC (12)
		
		protected CtrRef<UnlockUserDataBase> m_UnlockUserData = new CtrRef<UnlockUserDataBase>();
		[ContainerField(16), ContainerFieldNameHash(334679412)]
		public CtrRef<UnlockUserDataBase> UnlockUserData { get { return m_UnlockUserData; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(UnlockUserData), this, m_UnlockUserData, value)) m_UnlockUserData = value; } } // 0x10 (16)
		
		protected string m_DebugUnlockId = new string();
		[ContainerField(20), LayoutImmutable, ContainerFieldNameHash(2468774985)]
		public string DebugUnlockId { get { return m_DebugUnlockId; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(DebugUnlockId), this, m_DebugUnlockId, value)) m_DebugUnlockId = value; } } // 0x14 (20)
		
		protected uint m_Identifier = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(3512790342)]
		public uint Identifier { get { return m_Identifier; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(Identifier), this, m_Identifier, value)) m_Identifier = value; } } // 0x18 (24)
		
		protected UnlockAvailability m_AvailableForPlayer = new UnlockAvailability();
		[ContainerField(28), ContainerFieldNameHash(3398545844)]
		public UnlockAvailability AvailableForPlayer { get { return m_AvailableForPlayer; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(AvailableForPlayer), this, m_AvailableForPlayer, value)) m_AvailableForPlayer = value; } } // 0x1C (28)
		
		protected CtrRef<UnlockAssetBase> m_NextLevelUnlockAsset = new CtrRef<UnlockAssetBase>();
		[ContainerField(32), ContainerFieldNameHash(3071818964)]
		public CtrRef<UnlockAssetBase> NextLevelUnlockAsset { get { return m_NextLevelUnlockAsset; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(NextLevelUnlockAsset), this, m_NextLevelUnlockAsset, value)) m_NextLevelUnlockAsset = value; } } // 0x20 (32)
		
		protected bool m_AutoAvailable = new bool();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(1619872979)]
		public bool AutoAvailable { get { return m_AutoAvailable; } set { if (OnPropertyChanging("UnlockAssetBase." + nameof(AutoAvailable), this, m_AutoAvailable, value)) m_AutoAvailable = value; } } // 0x24 (36)
		
		protected bool m_HiddenInProgression = new bool();
		[ContainerField(37), LayoutImmutable, Blittable, ContainerFieldNameHash(1800564573)]
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
