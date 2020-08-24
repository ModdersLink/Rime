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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class CharacterSpawnReferenceObjectData : 
		SpawnReferenceObjectData
	{
		protected PlayerSpawnType m_PlayerType = new PlayerSpawnType();
		[ContainerField(384), MemberInfoFlag(137), ContainerFieldNameHash(774572558)]
		public PlayerSpawnType PlayerType { get { return m_PlayerType; } set { if (OnPropertyChanging("CharacterSpawnReferenceObjectData." + nameof(PlayerType), this, m_PlayerType, value)) m_PlayerType = value; } } // 0x180 (384)
		
		protected uint m_VehicleEntryIndex = new uint();
		[ContainerField(388), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3148172503)]
		public uint VehicleEntryIndex { get { return m_VehicleEntryIndex; } set { if (OnPropertyChanging("CharacterSpawnReferenceObjectData." + nameof(VehicleEntryIndex), this, m_VehicleEntryIndex, value)) m_VehicleEntryIndex = value; } } // 0x184 (388)
		
		protected CtrRef<SoldierSpawnTemplateData> m_Template = new CtrRef<SoldierSpawnTemplateData>();
		[ContainerField(392), MemberInfoFlag(53), ContainerFieldNameHash(2427043285), ContainerCtrRef]
		public CtrRef<SoldierSpawnTemplateData> Template { get { return m_Template; } set { if (OnPropertyChanging("CharacterSpawnReferenceObjectData." + nameof(Template), this, m_Template, value)) m_Template = value; } } // 0x188 (392)
		
		protected float m_HumanTargetPreference = new float();
		[ContainerField(396), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1981794192)]
		public float HumanTargetPreference { get { return m_HumanTargetPreference; } set { if (OnPropertyChanging("CharacterSpawnReferenceObjectData." + nameof(HumanTargetPreference), this, m_HumanTargetPreference, value)) m_HumanTargetPreference = value; } } // 0x18C (396)
		
		protected UIHudIcon m_MinimapIcon = new UIHudIcon();
		[ContainerField(400), MemberInfoFlag(137), ContainerFieldNameHash(1721945905)]
		public UIHudIcon MinimapIcon { get { return m_MinimapIcon; } set { if (OnPropertyChanging("CharacterSpawnReferenceObjectData." + nameof(MinimapIcon), this, m_MinimapIcon, value)) m_MinimapIcon = value; } } // 0x190 (400)
		
		protected bool m_AllowFallbackOnNextAvailabeVehicleEntry = new bool();
		[ContainerField(404), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1228692495)]
		public bool AllowFallbackOnNextAvailabeVehicleEntry { get { return m_AllowFallbackOnNextAvailabeVehicleEntry; } set { if (OnPropertyChanging("CharacterSpawnReferenceObjectData." + nameof(AllowFallbackOnNextAvailabeVehicleEntry), this, m_AllowFallbackOnNextAvailabeVehicleEntry, value)) m_AllowFallbackOnNextAvailabeVehicleEntry = value; } } // 0x194 (404)
		
		protected bool m_CheckMaxPlayersInVehicle = new bool();
		[ContainerField(405), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2575911368)]
		public bool CheckMaxPlayersInVehicle { get { return m_CheckMaxPlayersInVehicle; } set { if (OnPropertyChanging("CharacterSpawnReferenceObjectData." + nameof(CheckMaxPlayersInVehicle), this, m_CheckMaxPlayersInVehicle, value)) m_CheckMaxPlayersInVehicle = value; } } // 0x195 (405)
		
		protected bool m_AffectMinimapPosition = new bool();
		[ContainerField(406), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3321046512)]
		public bool AffectMinimapPosition { get { return m_AffectMinimapPosition; } set { if (OnPropertyChanging("CharacterSpawnReferenceObjectData." + nameof(AffectMinimapPosition), this, m_AffectMinimapPosition, value)) m_AffectMinimapPosition = value; } } // 0x196 (406)
		
		protected bool m_IsTarget = new bool();
		[ContainerField(407), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(495955022)]
		public bool IsTarget { get { return m_IsTarget; } set { if (OnPropertyChanging("CharacterSpawnReferenceObjectData." + nameof(IsTarget), this, m_IsTarget, value)) m_IsTarget = value; } } // 0x197 (407)
		
		protected bool m_IgnoreVehicleIcon = new bool();
		[ContainerField(408), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3203358734)]
		public bool IgnoreVehicleIcon { get { return m_IgnoreVehicleIcon; } set { if (OnPropertyChanging("CharacterSpawnReferenceObjectData." + nameof(IgnoreVehicleIcon), this, m_IgnoreVehicleIcon, value)) m_IgnoreVehicleIcon = value; } } // 0x198 (408)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 774572558:
					PlayerType = (PlayerSpawnType) Enum.ToObject(typeof(PlayerSpawnType), p_Value);
					break;

				case 3148172503:
					VehicleEntryIndex = (uint) p_Value;
					break;

				case 2427043285:
					Template = (CtrRef<SoldierSpawnTemplateData>) p_Value;
					break;

				case 1981794192:
					HumanTargetPreference = (float) p_Value;
					break;

				case 1721945905:
					MinimapIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 1228692495:
					AllowFallbackOnNextAvailabeVehicleEntry = (bool) p_Value;
					break;

				case 2575911368:
					CheckMaxPlayersInVehicle = (bool) p_Value;
					break;

				case 3321046512:
					AffectMinimapPosition = (bool) p_Value;
					break;

				case 495955022:
					IsTarget = (bool) p_Value;
					break;

				case 3203358734:
					IgnoreVehicleIcon = (bool) p_Value;
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
				case 774572558:
					return PlayerType;

				case 3148172503:
					return VehicleEntryIndex;

				case 2427043285:
					return Template;

				case 1981794192:
					return HumanTargetPreference;

				case 1721945905:
					return MinimapIcon;

				case 1228692495:
					return AllowFallbackOnNextAvailabeVehicleEntry;

				case 2575911368:
					return CheckMaxPlayersInVehicle;

				case 3321046512:
					return AffectMinimapPosition;

				case 495955022:
					return IsTarget;

				case 3203358734:
					return IgnoreVehicleIcon;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 774572558:
					return typeof(CharacterSpawnReferenceObjectData).GetProperty(nameof(PlayerType));

				case 3148172503:
					return typeof(CharacterSpawnReferenceObjectData).GetProperty(nameof(VehicleEntryIndex));

				case 2427043285:
					return typeof(CharacterSpawnReferenceObjectData).GetProperty(nameof(Template));

				case 1981794192:
					return typeof(CharacterSpawnReferenceObjectData).GetProperty(nameof(HumanTargetPreference));

				case 1721945905:
					return typeof(CharacterSpawnReferenceObjectData).GetProperty(nameof(MinimapIcon));

				case 1228692495:
					return typeof(CharacterSpawnReferenceObjectData).GetProperty(nameof(AllowFallbackOnNextAvailabeVehicleEntry));

				case 2575911368:
					return typeof(CharacterSpawnReferenceObjectData).GetProperty(nameof(CheckMaxPlayersInVehicle));

				case 3321046512:
					return typeof(CharacterSpawnReferenceObjectData).GetProperty(nameof(AffectMinimapPosition));

				case 495955022:
					return typeof(CharacterSpawnReferenceObjectData).GetProperty(nameof(IsTarget));

				case 3203358734:
					return typeof(CharacterSpawnReferenceObjectData).GetProperty(nameof(IgnoreVehicleIcon));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
