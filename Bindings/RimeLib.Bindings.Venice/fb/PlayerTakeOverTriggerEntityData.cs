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
	public class PlayerTakeOverTriggerEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public TeamId TeamId { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float TimeToLoseControl { get; set; }

		public static void Deserialize(PlayerTakeOverTriggerEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TeamId = (TeamId) p_Reader.ReadInt32();
			p_Instance.TimeToLoseControl = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
