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
	[ContainerType(4, 32)]
	public class FriendZoneEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public int EnemyWeight { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public int FriendlyWeight { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public int CorpsTimeout { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public int CorpsWeight { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool CountCorpsesForAllTeams { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable]
		public bool InitialZoneRandomized { get; set; }

		public static void Deserialize(FriendZoneEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.EnemyWeight = p_Reader.ReadInt32();
			p_Instance.FriendlyWeight = p_Reader.ReadInt32();
			p_Instance.CorpsTimeout = p_Reader.ReadInt32();
			p_Instance.CorpsWeight = p_Reader.ReadInt32();
			p_Instance.CountCorpsesForAllTeams = p_Reader.ReadBool();
			p_Instance.InitialZoneRandomized = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
