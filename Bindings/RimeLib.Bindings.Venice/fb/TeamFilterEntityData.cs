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
	public class TeamFilterEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new();

		[ContainerField(100)]
		public TeamId Team { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool InvertFilter { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable]
		public bool GenerateEventForEveryMatchingTeamMember { get; set; }

		public static void Deserialize(TeamFilterEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.Team = (TeamId) p_Reader.ReadInt32();
			p_Instance.InvertFilter = p_Reader.ReadBool();
			p_Instance.GenerateEventForEveryMatchingTeamMember = p_Reader.ReadBool();
			p_Reader.Seek(6, SeekOrigin.Current);
		}

	}
}
