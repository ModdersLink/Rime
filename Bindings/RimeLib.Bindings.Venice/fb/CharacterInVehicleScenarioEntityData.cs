///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 128)]
	public class CharacterInVehicleScenarioEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new();

		[ContainerField(100)]
		public AntRef ScenarioAntRef { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public int LevelId { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public int ScenarioId { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public int ActorId { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public int PartId { get; set; }

		public static void Deserialize(CharacterInVehicleScenarioEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			fb.AntRef.Deserialize(p_Instance.ScenarioAntRef, p_Reader, p_Parser);
			p_Instance.LevelId = p_Reader.ReadInt32();
			p_Instance.ScenarioId = p_Reader.ReadInt32();
			p_Instance.ActorId = p_Reader.ReadInt32();
			p_Instance.PartId = p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
