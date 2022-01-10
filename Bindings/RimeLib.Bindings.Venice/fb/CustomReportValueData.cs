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
	public class CustomReportValueData
	{
		[ContainerField(0), LayoutImmutable]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public CustomReportValueKind Kind { get; set; } = new();
		
		[ContainerField(8)]
		public PersistentValueDataType DataType { get; set; } = new();
		
		public static void Deserialize(CustomReportValueData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Kind = (CustomReportValueKind) p_Reader.ReadInt32();
			p_Instance.DataType = (PersistentValueDataType) p_Reader.ReadInt32();
		}
	}
}
