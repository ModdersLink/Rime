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
	public class RichPresenceContextSetting
	{
		[ContainerField(0)]
		public CtrRef<RichPresenceContext> Context { get; set; } = new();
		
		[ContainerField(4)]
		public CtrRef<RichPresenceContextValue> Value { get; set; } = new();
		
		public static void Deserialize(RichPresenceContextSetting p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Context.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Value.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}
	}
}
