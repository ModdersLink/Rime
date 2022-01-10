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
	public class DataField
	{
		[ContainerField(0), LayoutImmutable]
		public string Value { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public CtrRef<DataContainer> ValueRef { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public int Id { get; set; }
		
		[ContainerField(12)]
		public FieldAccessType AccessType { get; set; } = new();
		
		public static void Deserialize(DataField p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Value = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ValueRef.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Id = p_Reader.ReadInt32();
			p_Instance.AccessType = (FieldAccessType) p_Reader.ReadInt32();
		}
	}
}
