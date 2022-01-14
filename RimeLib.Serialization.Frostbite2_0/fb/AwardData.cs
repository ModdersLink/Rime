///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 100)]
	public class AwardData :
		AbstractAwardData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<AwardData> FilteredChildAwards { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<CriteriaData> Criteria { get; set; } = new();

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string Code { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string Description { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string NameSid { get; set; } = string.Empty;

		[ContainerField(32), JsonProperty(Order = 32)]
		public AwardKitAssociation KitAssociation { get; set; } = new();

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string ImageName { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		public string ImageSmallName { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		public string ImageFancyName { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		public string SoundName { get; set; } = string.Empty;

		[ContainerField(52), JsonProperty(Order = 52)]
		public AwardType Repeat { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public List<string> Licenses { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public uint MaxRepetitions { get; set; }

		[ContainerField(64), JsonProperty(Order = 64)]
		public List<CriteriaAward> Dependencies { get; set; } = new();

		[ContainerField(68), JsonProperty(Order = 68)]
		public AwardGroup Group { get; set; } = new();

		[ContainerField(72), JsonProperty(Order = 72)]
		public StatsMultiplicity Multiplicity { get; set; } = new();

		[ContainerField(76), JsonProperty(Order = 76)]
		public CtrRef<CriteriaGateList> UnlockGates { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public CtrRef<AwardData> ParentAward { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float Score { get; set; }

		[ContainerField(88), JsonProperty(Order = 88)]
		public ScoringBucket Bucket { get; set; } = new();

		[ContainerField(92), JsonProperty(Order = 92)]
		public List<BasicUnlockInfo> UnlockInfos { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public bool ActiveOnCreation { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		public bool Visible { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_FilteredChildAwards = p_EbxWriter.GetArrayWriter(FilteredChildAwards.GetType(), FilteredChildAwards.Count);
			p_Writer.Write(s_FilteredChildAwards.ArrayIndex);
			foreach (var s_Entry in FilteredChildAwards)
			{
				s_FilteredChildAwards.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Criteria = p_EbxWriter.GetArrayWriter(Criteria.GetType(), Criteria.Count);
			p_Writer.Write(s_Criteria.ArrayIndex);
			foreach (var s_Entry in Criteria)
			{
				s_Criteria.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteString(Code));
			p_Writer.Write(p_EbxWriter.WriteString(Description));
			p_Writer.Write(p_EbxWriter.WriteString(NameSid));
			p_Writer.Write((int) KitAssociation);
			p_Writer.Write(p_EbxWriter.WriteString(ImageName));
			p_Writer.Write(p_EbxWriter.WriteString(ImageSmallName));
			p_Writer.Write(p_EbxWriter.WriteString(ImageFancyName));
			p_Writer.Write(p_EbxWriter.WriteString(SoundName));
			p_Writer.Write((int) Repeat);
			(RimeWriter Writer, uint ArrayIndex) s_Licenses = p_EbxWriter.GetArrayWriter(Licenses.GetType(), Licenses.Count);
			p_Writer.Write(s_Licenses.ArrayIndex);
			foreach (var s_Entry in Licenses)
			{
				s_Licenses.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write(MaxRepetitions);
			(RimeWriter Writer, uint ArrayIndex) s_Dependencies = p_EbxWriter.GetArrayWriter(Dependencies.GetType(), Dependencies.Count);
			p_Writer.Write(s_Dependencies.ArrayIndex);
			foreach (var s_Entry in Dependencies)
			{
				s_Entry.Serialize(s_Dependencies.Writer, p_EbxWriter);
			}
			p_Writer.Write((int) Group);
			p_Writer.Write((int) Multiplicity);
			p_Writer.Write(p_EbxWriter.WriteImport(UnlockGates));
			p_Writer.Write(p_EbxWriter.WriteImport(ParentAward));
			p_Writer.Write(Score);
			p_Writer.Write((int) Bucket);
			(RimeWriter Writer, uint ArrayIndex) s_UnlockInfos = p_EbxWriter.GetArrayWriter(UnlockInfos.GetType(), UnlockInfos.Count);
			p_Writer.Write(s_UnlockInfos.ArrayIndex);
			foreach (var s_Entry in UnlockInfos)
			{
				s_Entry.Serialize(s_UnlockInfos.Writer, p_EbxWriter);
			}
			p_Writer.Write(ActiveOnCreation);
			p_Writer.Write(Visible);
			p_Writer.WriteNullBytes(2);
		}
	}
}
