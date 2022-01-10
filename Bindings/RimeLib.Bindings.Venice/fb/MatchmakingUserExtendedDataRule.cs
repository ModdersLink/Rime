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
	public class MatchmakingUserExtendedDataRule
	{
		[ContainerField(0), LayoutImmutable]
		public string Rule { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string MinFitThresHold { get; set; } = string.Empty;
		
		public static void Deserialize(MatchmakingUserExtendedDataRule p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Rule = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.MinFitThresHold = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}
	}
}
