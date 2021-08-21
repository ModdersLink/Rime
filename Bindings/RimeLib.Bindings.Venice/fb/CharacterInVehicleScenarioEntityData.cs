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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class CharacterInVehicleScenarioEntityData : 
		GameEntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 96, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("CharacterInVehicleScenarioEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x60 (96)
		
		protected AntRef m_ScenarioAntRef = new AntRef();
		[ContainerField(Name: "ScenarioAntRef", Offset: 100, NameHash: 3249359201, Flags: 41)]
		public AntRef ScenarioAntRef { get { return m_ScenarioAntRef; } set { if (OnPropertyChanging("CharacterInVehicleScenarioEntityData." + nameof(ScenarioAntRef), this, m_ScenarioAntRef, value)) m_ScenarioAntRef = value; } } // 0x64 (100)
		
		protected int m_LevelId = new int();
		[ContainerField(Name: "LevelId", Offset: 104, NameHash: 1464675646, Flags: 49405), LayoutImmutable, Blittable]
		public int LevelId { get { return m_LevelId; } set { if (OnPropertyChanging("CharacterInVehicleScenarioEntityData." + nameof(LevelId), this, m_LevelId, value)) m_LevelId = value; } } // 0x68 (104)
		
		protected int m_ScenarioId = new int();
		[ContainerField(Name: "ScenarioId", Offset: 108, NameHash: 3278128294, Flags: 49405), LayoutImmutable, Blittable]
		public int ScenarioId { get { return m_ScenarioId; } set { if (OnPropertyChanging("CharacterInVehicleScenarioEntityData." + nameof(ScenarioId), this, m_ScenarioId, value)) m_ScenarioId = value; } } // 0x6C (108)
		
		protected int m_ActorId = new int();
		[ContainerField(Name: "ActorId", Offset: 112, NameHash: 373715747, Flags: 49405), LayoutImmutable, Blittable]
		public int ActorId { get { return m_ActorId; } set { if (OnPropertyChanging("CharacterInVehicleScenarioEntityData." + nameof(ActorId), this, m_ActorId, value)) m_ActorId = value; } } // 0x70 (112)
		
		protected int m_PartId = new int();
		[ContainerField(Name: "PartId", Offset: 116, NameHash: 3371573631, Flags: 49405), LayoutImmutable, Blittable]
		public int PartId { get { return m_PartId; } set { if (OnPropertyChanging("CharacterInVehicleScenarioEntityData." + nameof(PartId), this, m_PartId, value)) m_PartId = value; } } // 0x74 (116)
		
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
