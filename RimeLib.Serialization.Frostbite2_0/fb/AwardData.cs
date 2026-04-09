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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 100)]
	public partial class AwardData :
		AbstractAwardData
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<AwardData> _FilteredChildAwards = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<CriteriaData> _Criteria = new();

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		private string _Code = string.Empty;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		private string _Description = string.Empty;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		private string _NameSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AwardKitAssociation _KitAssociation = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		private string _ImageName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		private string _ImageSmallName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		private string _ImageFancyName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		private string _SoundName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private AwardType _Repeat = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private List<string> _Licenses = new();

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private uint _MaxRepetitions;

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private List<CriteriaAward> _Dependencies = new();

		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private AwardGroup _Group = new();

		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private StatsMultiplicity _Multiplicity = new();

		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private CtrRef<CriteriaGateList> _UnlockGates = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private CtrRef<AwardData> _ParentAward = new();

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _Score;

		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private ScoringBucket _Bucket = new();

		[ObservableProperty]
		[property: ContainerField(92), JsonProperty(Order = 92)]
		private List<BasicUnlockInfo> _UnlockInfos = new();

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private bool _ActiveOnCreation;

		[ObservableProperty]
		[property: ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		private bool _Visible;

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
