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
	[ContainerType(4, 52)]
	public class PersistenceData : 
		AbstractPersistenceData
	{
		[ContainerField(12), LayoutImmutable]
		public string PersistenceName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable]
		public string ClubPersistenceName { get; set; } = string.Empty;

		[ContainerField(20)]
		public CtrRef<PersistenceStatGroup> ClientDefaultGroup { get; set; } = new();

		[ContainerField(24)]
		public List<PersistentValueTemplateData> Values { get; set; } = new();

		[ContainerField(28)]
		public List<CustomReportValueData> CustomReportValues { get; set; } = new();

		[ContainerField(32)]
		public CtrRef<PersistenceStatGroup> ServerDefaultGroup { get; set; } = new();

		[ContainerField(36)]
		public CtrRef<PersistenceRetentionPolicy> RetentionPolicy { get; set; } = new();

		[ContainerField(40)]
		public List<PersistenceConsumableMapping> ConsumableMappings { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool HistoryDaily { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable]
		public bool HistoryWeekly { get; set; }

		[ContainerField(46), LayoutImmutable, Blittable]
		public bool HistoryMonthly { get; set; }

		[ContainerField(47), LayoutImmutable, Blittable]
		public bool OutputProperties { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool DeltaGameReports { get; set; }

		public static void Deserialize(PersistenceData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PersistenceName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ClubPersistenceName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ClientDefaultGroup.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Values.Clear();
			(RimeReader Reader, uint Count) s_Values = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Values.Count; ++i)
			{
				var s_Value = new PersistentValueTemplateData();
				fb.PersistentValueTemplateData.Deserialize(s_Value, s_Values.Reader, p_Parser);
				p_Instance.Values.Add(s_Value);
			}
			
			s_Values.Reader.Dispose();
			p_Instance.CustomReportValues.Clear();
			(RimeReader Reader, uint Count) s_CustomReportValues = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_CustomReportValues.Count; ++i)
			{
				var s_Value = new CustomReportValueData();
				fb.CustomReportValueData.Deserialize(s_Value, s_CustomReportValues.Reader, p_Parser);
				p_Instance.CustomReportValues.Add(s_Value);
			}
			
			s_CustomReportValues.Reader.Dispose();
			p_Instance.ServerDefaultGroup.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.RetentionPolicy.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ConsumableMappings.Clear();
			(RimeReader Reader, uint Count) s_ConsumableMappings = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ConsumableMappings.Count; ++i)
			{
				var s_Value = new PersistenceConsumableMapping();
				fb.PersistenceConsumableMapping.Deserialize(s_Value, s_ConsumableMappings.Reader, p_Parser);
				p_Instance.ConsumableMappings.Add(s_Value);
			}
			
			s_ConsumableMappings.Reader.Dispose();
			p_Instance.HistoryDaily = p_Reader.ReadBool();
			p_Instance.HistoryWeekly = p_Reader.ReadBool();
			p_Instance.HistoryMonthly = p_Reader.ReadBool();
			p_Instance.OutputProperties = p_Reader.ReadBool();
			p_Instance.DeltaGameReports = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
