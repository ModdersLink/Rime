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
	public class AntiRollBars
	{
		[ContainerField(0)]
		public CtrRef<AntiRollBar> Front { get; set; } = new();
		
		[ContainerField(4)]
		public CtrRef<AntiRollBar> Rear { get; set; } = new();
		
		public static void Deserialize(AntiRollBars p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Front.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Rear.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}
	}
}
