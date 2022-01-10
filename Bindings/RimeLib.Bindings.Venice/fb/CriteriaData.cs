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
	public class CriteriaData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float CompletionValue { get; set; }

		[ContainerField(12)]
		public CtrRef<CriteriaGateList> GateList { get; set; } = new();

		[ContainerField(16)]
		public StatEvent Measuring { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<StatsCategoryBaseData> ParamX { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<StatsCategoryBaseData> ParamY { get; set; } = new();

		[ContainerField(28)]
		public List<CtrRef<StatsCategoryBaseData>> OrParamsX { get; set; } = new();

		[ContainerField(32)]
		public CriteriaType CriteriaType { get; set; } = new();

		[ContainerField(36), LayoutImmutable]
		public string DescriptionSid { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, Blittable]
		public float ScaleFactor { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float Scale { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool ShouldSummarize { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable]
		public bool ShouldHide { get; set; }

		[ContainerField(50), LayoutImmutable, Blittable]
		public bool CountEvents { get; set; }

		public static void Deserialize(CriteriaData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CompletionValue = p_Reader.ReadSingle();
			p_Instance.GateList.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Measuring = (StatEvent) p_Reader.ReadInt32();
			p_Instance.ParamX.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ParamY.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.OrParamsX.Clear();
			(RimeReader Reader, uint Count) s_OrParamsX = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_OrParamsX.Count; ++i)
			{
				var s_CtrRef = new CtrRef<StatsCategoryBaseData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_OrParamsX.Reader.ReadUInt32()));
				p_Instance.OrParamsX.Add(s_CtrRef);
			}
			
			s_OrParamsX.Reader.Dispose();
			p_Instance.CriteriaType = (CriteriaType) p_Reader.ReadInt32();
			p_Instance.DescriptionSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ScaleFactor = p_Reader.ReadSingle();
			p_Instance.Scale = p_Reader.ReadSingle();
			p_Instance.ShouldSummarize = p_Reader.ReadBool();
			p_Instance.ShouldHide = p_Reader.ReadBool();
			p_Instance.CountEvents = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
