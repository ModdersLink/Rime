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
	[ContainerType(4, 28)]
	public class SettingEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16), LayoutImmutable]
		public string BoolSettingName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string IntSettingName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string FloatSettingName { get; set; } = string.Empty;

		public static void Deserialize(SettingEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.BoolSettingName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.IntSettingName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.FloatSettingName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}

	}
}
