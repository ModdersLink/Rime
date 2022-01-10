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
	[ContainerType(4, 100)]
	public class AwardData : 
		AbstractAwardData
	{
		[ContainerField(12)]
		public List<CtrRef<AwardData>> FilteredChildAwards { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<CriteriaData>> Criteria { get; set; } = new();

		[ContainerField(20), LayoutImmutable]
		public string Code { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string Description { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string NameSid { get; set; } = string.Empty;

		[ContainerField(32)]
		public AwardKitAssociation KitAssociation { get; set; } = new();

		[ContainerField(36), LayoutImmutable]
		public string ImageName { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable]
		public string ImageSmallName { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable]
		public string ImageFancyName { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable]
		public string SoundName { get; set; } = string.Empty;

		[ContainerField(52)]
		public AwardType Repeat { get; set; } = new();

		[ContainerField(56)]
		public List<string> Licenses { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable]
		public uint MaxRepetitions { get; set; }

		[ContainerField(64)]
		public List<CriteriaAward> Dependencies { get; set; } = new();

		[ContainerField(68)]
		public AwardGroup Group { get; set; } = new();

		[ContainerField(72)]
		public StatsMultiplicity Multiplicity { get; set; } = new();

		[ContainerField(76)]
		public CtrRef<CriteriaGateList> UnlockGates { get; set; } = new();

		[ContainerField(80)]
		public CtrRef<AwardData> ParentAward { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public float Score { get; set; }

		[ContainerField(88)]
		public ScoringBucket Bucket { get; set; } = new();

		[ContainerField(92)]
		public List<BasicUnlockInfo> UnlockInfos { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool ActiveOnCreation { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable]
		public bool Visible { get; set; }

		public static void Deserialize(AwardData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FilteredChildAwards.Clear();
			(RimeReader Reader, uint Count) s_FilteredChildAwards = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_FilteredChildAwards.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AwardData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_FilteredChildAwards.Reader.ReadUInt32()));
				p_Instance.FilteredChildAwards.Add(s_CtrRef);
			}
			
			s_FilteredChildAwards.Reader.Dispose();
			p_Instance.Criteria.Clear();
			(RimeReader Reader, uint Count) s_Criteria = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Criteria.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CriteriaData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Criteria.Reader.ReadUInt32()));
				p_Instance.Criteria.Add(s_CtrRef);
			}
			
			s_Criteria.Reader.Dispose();
			p_Instance.Code = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Description = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.NameSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.KitAssociation = (AwardKitAssociation) p_Reader.ReadInt32();
			p_Instance.ImageName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ImageSmallName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ImageFancyName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SoundName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Repeat = (AwardType) p_Reader.ReadInt32();
			p_Instance.Licenses.Clear();
			(RimeReader Reader, uint Count) s_Licenses = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Licenses.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Licenses.Reader.ReadUInt32());
				p_Instance.Licenses.Add(s_Value);
			}
			
			s_Licenses.Reader.Dispose();
			p_Instance.MaxRepetitions = p_Reader.ReadUInt32();
			p_Instance.Dependencies.Clear();
			(RimeReader Reader, uint Count) s_Dependencies = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Dependencies.Count; ++i)
			{
				var s_Value = new CriteriaAward();
				fb.CriteriaAward.Deserialize(s_Value, s_Dependencies.Reader, p_Parser);
				p_Instance.Dependencies.Add(s_Value);
			}
			
			s_Dependencies.Reader.Dispose();
			p_Instance.Group = (AwardGroup) p_Reader.ReadInt32();
			p_Instance.Multiplicity = (StatsMultiplicity) p_Reader.ReadInt32();
			p_Instance.UnlockGates.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ParentAward.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Score = p_Reader.ReadSingle();
			p_Instance.Bucket = (ScoringBucket) p_Reader.ReadInt32();
			p_Instance.UnlockInfos.Clear();
			(RimeReader Reader, uint Count) s_UnlockInfos = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UnlockInfos.Count; ++i)
			{
				var s_Value = new BasicUnlockInfo();
				fb.BasicUnlockInfo.Deserialize(s_Value, s_UnlockInfos.Reader, p_Parser);
				p_Instance.UnlockInfos.Add(s_Value);
			}
			
			s_UnlockInfos.Reader.Dispose();
			p_Instance.ActiveOnCreation = p_Reader.ReadBool();
			p_Instance.Visible = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
