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

using fb.Core;
using fb.GameShared;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 168)]
public class AwardData
	: fb.VeniceShared.AbstractAwardData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public RefArray<AwardData> FilteredChildAwards { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<CriteriaData> Criteria { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string Code { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string Description { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string NameSid { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public AwardKitAssociation KitAssociation { get; set; } = AwardKitAssociation.AwardKitAssociation_Undefined;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string ImageName { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string ImageSmallName { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string ImageFancyName { get; set; } = string.Empty;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public string SoundName { get; set; } = string.Empty;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public AwardType Repeat { get; set; } = AwardType.AwardType_OnceGlobally;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public uint MaxRepetitions { get; set; } = 1;
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public List<CriteriaAward> Dependencies { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public AwardGroup Group { get; set; } = AwardGroup.AwardGroup_Undefined;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public StatsMultiplicity Multiplicity { get; set; } = StatsMultiplicity.StatsMultiplicity_Solo;
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<AwardData> ParentAward { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float Score { get; set; } = 0.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public ScoringBucket Bucket { get; set; } = ScoringBucket.ScoringBucket_Award;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public List<BasicUnlockInfo> UnlockInfos { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<CriteriaGateList> UnlockGates { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public List<string> Licenses { get; set; } = new();
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public bool Visible { get; set; } = true;
	
	[ContainerField(0xa1), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
	public bool VisibleAsDependecy { get; set; } = true;
	
	[ContainerField(0xa2), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
	public bool VisibleForcedWhenAwarded { get; set; } = false;
	
	[ContainerField(0xa3), LayoutImmutable, Blittable, JsonProperty(Order = 163)]
	public bool CriteriaVisibleWithoutLicense { get; set; } = true;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public bool HideIfDependenciesNotFulfilled { get; set; } = false;
	
	[ContainerField(0xa5), LayoutImmutable, Blittable, JsonProperty(Order = 165)]
	public bool ForceShowInLicensesTab { get; set; } = false;
	
	[ContainerField(0xa6), LayoutImmutable, Blittable, JsonProperty(Order = 166)]
	public bool HasSameUIMetaDataForMultipleUnlocks { get; set; } = false;
	
	[ContainerField(0xa7), LayoutImmutable, Blittable, JsonProperty(Order = 167)]
	public bool ActiveOnCreation { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_FilteredChildAwards = p_EbxWriter.GetArrayWriter(FilteredChildAwards.GetType(), FilteredChildAwards.Count);
		p_Writer.Write(s_FilteredChildAwards.ArrayIndex);
		foreach (var s_Entry in FilteredChildAwards)
		{
			s_FilteredChildAwards.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Criteria = p_EbxWriter.GetArrayWriter(Criteria.GetType(), Criteria.Count);
		p_Writer.Write(s_Criteria.ArrayIndex);
		foreach (var s_Entry in Criteria)
		{
			s_Criteria.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(Code));
		p_Writer.Write(p_EbxWriter.WriteString(Description));
		p_Writer.Write(p_EbxWriter.WriteString(NameSid));
		p_Writer.Write((int) KitAssociation);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(ImageName));
		p_Writer.Write(p_EbxWriter.WriteString(ImageSmallName));
		p_Writer.Write(p_EbxWriter.WriteString(ImageFancyName));
		p_Writer.Write(p_EbxWriter.WriteString(SoundName));
		p_Writer.Write((int) Repeat);
		p_Writer.Write(MaxRepetitions);
		(RimeWriter Writer, uint ArrayIndex) s_Dependencies = p_EbxWriter.GetArrayWriter(Dependencies.GetType(), Dependencies.Count);
		p_Writer.Write(s_Dependencies.ArrayIndex);
		foreach (var s_Entry in Dependencies)
		{
			s_Entry.Serialize(s_Dependencies.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Group);
		p_Writer.Write((int) Multiplicity);
		p_Writer.Write(p_EbxWriter.WriteImport(ParentAward));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Score);
		p_Writer.Write((int) Bucket);
		(RimeWriter Writer, uint ArrayIndex) s_UnlockInfos = p_EbxWriter.GetArrayWriter(UnlockInfos.GetType(), UnlockInfos.Count);
		p_Writer.Write(s_UnlockInfos.ArrayIndex);
		foreach (var s_Entry in UnlockInfos)
		{
			s_Entry.Serialize(s_UnlockInfos.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(UnlockGates));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Licenses = p_EbxWriter.GetArrayWriter(Licenses.GetType(), Licenses.Count);
		p_Writer.Write(s_Licenses.ArrayIndex);
		foreach (var s_Entry in Licenses)
		{
			s_Licenses.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Visible);
		p_Writer.Write(VisibleAsDependecy);
		p_Writer.Write(VisibleForcedWhenAwarded);
		p_Writer.Write(CriteriaVisibleWithoutLicense);
		p_Writer.Write(HideIfDependenciesNotFulfilled);
		p_Writer.Write(ForceShowInLicensesTab);
		p_Writer.Write(HasSameUIMetaDataForMultipleUnlocks);
		p_Writer.Write(ActiveOnCreation);
	}
}

