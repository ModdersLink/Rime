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
	public class HumanPlayerEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float PlayerKilledDelay { get; set; }

		[ContainerField(100), LayoutImmutable]
		public string LastManStandingSid { get; set; } = string.Empty;

		[ContainerField(104), LayoutImmutable, Blittable]
		public float DisplayTime { get; set; }

		public static void Deserialize(HumanPlayerEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PlayerKilledDelay = p_Reader.ReadSingle();
			p_Instance.LastManStandingSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.DisplayTime = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
