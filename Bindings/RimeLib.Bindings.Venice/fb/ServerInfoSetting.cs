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
	public class ServerInfoSetting
	{
		[ContainerField(0), LayoutImmutable]
		public string Key { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool IsBool { get; set; }
		
		public static void Deserialize(ServerInfoSetting p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Key = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.IsBool = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
