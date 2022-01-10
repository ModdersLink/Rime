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
	[ContainerType(16, 112)]
	public class CharacterHealthComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float MaxHealth { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float RegenerateHealthPerSecond { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool RegenerateHealth { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable]
		public bool IsImmortal { get; set; }

		public static void Deserialize(CharacterHealthComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaxHealth = p_Reader.ReadSingle();
			p_Instance.RegenerateHealthPerSecond = p_Reader.ReadSingle();
			p_Instance.RegenerateHealth = p_Reader.ReadBool();
			p_Instance.IsImmortal = p_Reader.ReadBool();
			p_Reader.Seek(6, SeekOrigin.Current);
		}

	}
}
