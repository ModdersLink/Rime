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
	public class UILevelSpecificPageHeader
	{
		[ContainerField(0), LayoutImmutable]
		public string LevelNameSID { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string Header { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable]
		public string SubHeader { get; set; } = string.Empty;
		
		public static void Deserialize(UILevelSpecificPageHeader p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.LevelNameSID = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Header = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SubHeader = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}
	}
}
