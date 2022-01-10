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
	[ContainerType(4, 8)]
	public class LockedSettingConfig
	{
		[ContainerField(0), LayoutImmutable]
		public string Key { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint Value { get; set; }
		
		public static void Deserialize(LockedSettingConfig p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Key = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Value = p_Reader.ReadUInt32();
		}
	}
}
