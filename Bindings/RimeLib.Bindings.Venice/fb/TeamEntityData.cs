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
	public class TeamEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<TeamData> Team { get; set; } = new();

		[ContainerField(100)]
		public TeamId Id { get; set; } = new();

		public static void Deserialize(TeamEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Team.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Id = (TeamId) p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
