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
	public class AutoSquadEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public SquadId SquadId { get; set; } = new();

		public static void Deserialize(AutoSquadEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SquadId = (SquadId) p_Reader.ReadInt32();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
