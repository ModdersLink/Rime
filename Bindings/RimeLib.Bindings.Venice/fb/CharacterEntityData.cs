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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 160)]
	public class CharacterEntityData : 
		ControllableEntityData
	{
		protected PersonViewMode m_DefaultViewMode = new PersonViewMode();
		[ContainerField(Name: "DefaultViewMode", Offset: 144, NameHash: 3414667104, Flags: 137)]
		public PersonViewMode DefaultViewMode { get { return m_DefaultViewMode; } set { if (OnPropertyChanging("CharacterEntityData." + nameof(DefaultViewMode), this, m_DefaultViewMode, value)) m_DefaultViewMode = value; } } // 0x90 (144)
		
		protected PlayerSpawnType m_PlayerSpawnType = new PlayerSpawnType();
		[ContainerField(Name: "PlayerSpawnType", Offset: 148, NameHash: 350489269, Flags: 137)]
		public PlayerSpawnType PlayerSpawnType { get { return m_PlayerSpawnType; } set { if (OnPropertyChanging("CharacterEntityData." + nameof(PlayerSpawnType), this, m_PlayerSpawnType, value)) m_PlayerSpawnType = value; } } // 0x94 (148)
		
		protected bool m_CharacterLightingEnable = new bool();
		[ContainerField(Name: "CharacterLightingEnable", Offset: 152, NameHash: 4279193667, Flags: 49325), LayoutImmutable, Blittable]
		public bool CharacterLightingEnable { get { return m_CharacterLightingEnable; } set { if (OnPropertyChanging("CharacterEntityData." + nameof(CharacterLightingEnable), this, m_CharacterLightingEnable, value)) m_CharacterLightingEnable = value; } } // 0x98 (152)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3414667104:
					DefaultViewMode = (PersonViewMode) Enum.ToObject(typeof(PersonViewMode), p_Value);
					break;

				case 350489269:
					PlayerSpawnType = (PlayerSpawnType) Enum.ToObject(typeof(PlayerSpawnType), p_Value);
					break;

				case 4279193667:
					CharacterLightingEnable = (bool) p_Value;
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
				case 3414667104:
					return DefaultViewMode;

				case 350489269:
					return PlayerSpawnType;

				case 4279193667:
					return CharacterLightingEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3414667104:
					return typeof(CharacterEntityData).GetProperty(nameof(DefaultViewMode));

				case 350489269:
					return typeof(CharacterEntityData).GetProperty(nameof(PlayerSpawnType));

				case 4279193667:
					return typeof(CharacterEntityData).GetProperty(nameof(CharacterLightingEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
