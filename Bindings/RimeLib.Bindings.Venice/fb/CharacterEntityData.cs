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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(160), ContainerClass]
	public class CharacterEntityData : 
		ControllableEntityData
	{
		protected PersonViewMode m_DefaultViewMode = new PersonViewMode();
		[ContainerField(144), MemberInfoFlag(137), ContainerFieldNameHash(3414667104)]
		public PersonViewMode DefaultViewMode { get { return m_DefaultViewMode; } set { if (OnPropertyChanging("CharacterEntityData." + nameof(DefaultViewMode), this, m_DefaultViewMode, value)) m_DefaultViewMode = value; } } // 0x90 (144)
		
		protected PlayerSpawnType m_PlayerSpawnType = new PlayerSpawnType();
		[ContainerField(148), MemberInfoFlag(137), ContainerFieldNameHash(350489269)]
		public PlayerSpawnType PlayerSpawnType { get { return m_PlayerSpawnType; } set { if (OnPropertyChanging("CharacterEntityData." + nameof(PlayerSpawnType), this, m_PlayerSpawnType, value)) m_PlayerSpawnType = value; } } // 0x94 (148)
		
		protected bool m_CharacterLightingEnable = new bool();
		[ContainerField(152), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4279193667)]
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
