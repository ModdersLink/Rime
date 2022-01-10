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
	[ContainerType(4, 16)]
	public class UILevelStatData
	{
		[ContainerField(0), LayoutImmutable]
		public string StatEasy { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string StatMedium { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable]
		public string StatHard { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable]
		public string StatHardcore { get; set; } = string.Empty;
		
		public static void Deserialize(UILevelStatData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.StatEasy = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.StatMedium = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.StatHard = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.StatHardcore = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}
	}
}
