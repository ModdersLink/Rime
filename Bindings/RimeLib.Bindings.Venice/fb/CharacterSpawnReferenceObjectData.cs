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
	public class CharacterSpawnReferenceObjectData : 
		SpawnReferenceObjectData
	{
		[ContainerField(384)]
		public PlayerSpawnType PlayerType { get; set; } = new PlayerSpawnType(); // 0x180 (384)
		
		[ContainerField(388), LayoutImmutable, Blittable]
		public uint VehicleEntryIndex { get; set; } // 0x184 (388)
		
		[ContainerField(392)]
		public CtrRef<SoldierSpawnTemplateData> Template { get; set; } = new CtrRef<SoldierSpawnTemplateData>(); // 0x188 (392)
		
		[ContainerField(396), LayoutImmutable, Blittable]
		public float HumanTargetPreference { get; set; } // 0x18C (396)
		
		[ContainerField(400)]
		public UIHudIcon MinimapIcon { get; set; } = new UIHudIcon(); // 0x190 (400)
		
		[ContainerField(404), LayoutImmutable, Blittable]
		public bool AllowFallbackOnNextAvailabeVehicleEntry { get; set; } // 0x194 (404)
		
		[ContainerField(405), LayoutImmutable, Blittable]
		public bool CheckMaxPlayersInVehicle { get; set; } // 0x195 (405)
		
		[ContainerField(406), LayoutImmutable, Blittable]
		public bool AffectMinimapPosition { get; set; } // 0x196 (406)
		
		[ContainerField(407), LayoutImmutable, Blittable]
		public bool IsTarget { get; set; } // 0x197 (407)
		
		[ContainerField(408), LayoutImmutable, Blittable]
		public bool IgnoreVehicleIcon { get; set; } // 0x198 (408)
		
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
