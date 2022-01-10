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
	public class PreRoundEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public int RoundMaxPlayerCount { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public uint RoundRestartCountdown { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public int RoundMinPlayerCount { get; set; }

		public static void Deserialize(PreRoundEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RoundMaxPlayerCount = p_Reader.ReadInt32();
			p_Instance.RoundRestartCountdown = p_Reader.ReadUInt32();
			p_Instance.RoundMinPlayerCount = p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
