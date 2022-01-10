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
	[ContainerType(4, 48)]
	public class ScoringTypeData : 
		DataContainer
	{
		[ContainerField(8)]
		public StatEvent Measuring { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<StatsCategoryBaseData> ParamX { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<StatsCategoryBaseData> ParamY { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Limit { get; set; }

		[ContainerField(24), LayoutImmutable]
		public string DescriptionSid { get; set; } = string.Empty;

		[ContainerField(28)]
		public ScoringVisibilityType VisibilityType { get; set; } = new();

		[ContainerField(32)]
		public ScoringBucket Bucket { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public float Score { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float AdditionalValueMultiplier { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool ShowForTeam { get; set; }

		public static void Deserialize(ScoringTypeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Measuring = (StatEvent) p_Reader.ReadInt32();
			p_Instance.ParamX.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ParamY.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Limit = p_Reader.ReadSingle();
			p_Instance.DescriptionSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.VisibilityType = (ScoringVisibilityType) p_Reader.ReadInt32();
			p_Instance.Bucket = (ScoringBucket) p_Reader.ReadInt32();
			p_Instance.Score = p_Reader.ReadSingle();
			p_Instance.AdditionalValueMultiplier = p_Reader.ReadSingle();
			p_Instance.ShowForTeam = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
