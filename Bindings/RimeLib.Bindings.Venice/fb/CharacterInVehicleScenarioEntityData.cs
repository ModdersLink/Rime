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
	public class CharacterInVehicleScenarioEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new Realm(); // 0x60 (96)
		
		[ContainerField(100)]
		public AntRef ScenarioAntRef { get; set; } = new AntRef(); // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public int LevelId { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public int ScenarioId { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public int ActorId { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public int PartId { get; set; } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 3249359201:
					ScenarioAntRef = (AntRef) p_Value;
					break;

				case 1464675646:
					LevelId = (int) p_Value;
					break;

				case 3278128294:
					ScenarioId = (int) p_Value;
					break;

				case 373715747:
					ActorId = (int) p_Value;
					break;

				case 3371573631:
					PartId = (int) p_Value;
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
				case 229961746:
					return Realm;

				case 3249359201:
					return ScenarioAntRef;

				case 1464675646:
					return LevelId;

				case 3278128294:
					return ScenarioId;

				case 373715747:
					return ActorId;

				case 3371573631:
					return PartId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(CharacterInVehicleScenarioEntityData).GetProperty(nameof(Realm));

				case 3249359201:
					return typeof(CharacterInVehicleScenarioEntityData).GetProperty(nameof(ScenarioAntRef));

				case 1464675646:
					return typeof(CharacterInVehicleScenarioEntityData).GetProperty(nameof(LevelId));

				case 3278128294:
					return typeof(CharacterInVehicleScenarioEntityData).GetProperty(nameof(ScenarioId));

				case 373715747:
					return typeof(CharacterInVehicleScenarioEntityData).GetProperty(nameof(ActorId));

				case 3371573631:
					return typeof(CharacterInVehicleScenarioEntityData).GetProperty(nameof(PartId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
