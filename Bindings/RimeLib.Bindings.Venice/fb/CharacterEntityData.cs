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
	public class CharacterEntityData : 
		ControllableEntityData
	{
		[ContainerField(144)]
		public PersonViewMode DefaultViewMode { get; set; } = new PersonViewMode(); // 0x90 (144)
		
		[ContainerField(148)]
		public PlayerSpawnType PlayerSpawnType { get; set; } = new PlayerSpawnType(); // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public bool CharacterLightingEnable { get; set; } // 0x98 (152)
		
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
