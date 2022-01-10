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
	public class MatchmakingVirtualizedRule
	{
		[ContainerField(0), LayoutImmutable]
		public string MinFitThreshold { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public MatchmakingVirtualizationMode VirtualizationMode { get; set; } = new();
		
		public static void Deserialize(MatchmakingVirtualizedRule p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MinFitThreshold = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.VirtualizationMode = (MatchmakingVirtualizationMode) p_Reader.ReadInt32();
		}
	}
}
