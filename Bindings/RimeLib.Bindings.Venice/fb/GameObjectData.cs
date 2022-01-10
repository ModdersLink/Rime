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
	[ContainerType(4, 12)]
	public class GameObjectData : 
		GameDataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public ushort IndexInBlueprint { get; set; }

		[ContainerField(10), LayoutImmutable, Blittable]
		public sbyte IsEventConnectionTarget { get; set; }

		[ContainerField(11), LayoutImmutable, Blittable]
		public sbyte IsPropertyConnectionTarget { get; set; }

		public static void Deserialize(GameObjectData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.IndexInBlueprint = p_Reader.ReadUInt16();
			p_Instance.IsEventConnectionTarget = p_Reader.ReadSByte();
			p_Instance.IsPropertyConnectionTarget = p_Reader.ReadSByte();
		}

	}
}
