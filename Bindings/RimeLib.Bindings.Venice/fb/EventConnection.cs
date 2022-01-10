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
	[ContainerType(4, 20)]
	public class EventConnection
	{
		[ContainerField(0)]
		public CtrRef<DataContainer> Source { get; set; } = new();
		
		[ContainerField(4)]
		public CtrRef<DataContainer> Target { get; set; } = new();
		
		[ContainerField(8)]
		public EventSpec SourceEvent { get; set; } = new();
		
		[ContainerField(12)]
		public EventSpec TargetEvent { get; set; } = new();
		
		[ContainerField(16)]
		public EventConnectionTargetType TargetType { get; set; } = new();
		
		public static void Deserialize(EventConnection p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Source.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Target.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.EventSpec.Deserialize(p_Instance.SourceEvent, p_Reader, p_Parser);
			fb.EventSpec.Deserialize(p_Instance.TargetEvent, p_Reader, p_Parser);
			p_Instance.TargetType = (EventConnectionTargetType) p_Reader.ReadInt32();
		}
	}
}
