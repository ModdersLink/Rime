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
	[ContainerType(4, 36)]
	public class PersistentValueTemplateData
	{
		[ContainerField(0), LayoutImmutable]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string DefaultValue { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float DefaultFloatValue { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int DefaultIntValue { get; set; }
		
		[ContainerField(16)]
		public PersistentValueType ValueType { get; set; } = new();
		
		[ContainerField(20)]
		public PersistentValueDataType DataType { get; set; } = new();
		
		[ContainerField(24)]
		public PersistentValueHistoryType HistoryType { get; set; } = new();
		
		[ContainerField(28)]
		public AwardGroup Group { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool ClubStat { get; set; }
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool ForceIntoTemplate { get; set; }
		
		public static void Deserialize(PersistentValueTemplateData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.DefaultValue = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.DefaultFloatValue = p_Reader.ReadSingle();
			p_Instance.DefaultIntValue = p_Reader.ReadInt32();
			p_Instance.ValueType = (PersistentValueType) p_Reader.ReadInt32();
			p_Instance.DataType = (PersistentValueDataType) p_Reader.ReadInt32();
			p_Instance.HistoryType = (PersistentValueHistoryType) p_Reader.ReadInt32();
			p_Instance.Group = (AwardGroup) p_Reader.ReadInt32();
			p_Instance.ClubStat = p_Reader.ReadBool();
			p_Instance.ForceIntoTemplate = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}
	}
}
