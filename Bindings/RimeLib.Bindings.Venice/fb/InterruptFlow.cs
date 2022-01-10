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
	public class InterruptFlow
	{
		[ContainerField(0)]
		public UIInterruptID interruptEnum { get; set; } = new();
		
		[ContainerField(4)]
		public CtrRef<UIGraphAsset> interruptFlow { get; set; } = new();
		
		public static void Deserialize(InterruptFlow p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.interruptEnum = (UIInterruptID) p_Reader.ReadInt32();
			p_Instance.interruptFlow.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}
	}
}
