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
	[ContainerType(4, 48)]
	public partial class ScoringTypeData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private StatEvent _Measuring = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<StatsCategoryBaseData> _ParamX = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<StatsCategoryBaseData> _ParamY = new();

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _Limit;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		private string _DescriptionSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private ScoringVisibilityType _VisibilityType = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private ScoringBucket _Bucket = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _Score;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _AdditionalValueMultiplier;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private bool _ShowForTeam;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write((int) Measuring);
			p_Writer.Write(p_EbxWriter.WriteImport(ParamX));
			p_Writer.Write(p_EbxWriter.WriteImport(ParamY));
			p_Writer.Write(Limit);
			p_Writer.Write(p_EbxWriter.WriteString(DescriptionSid));
			p_Writer.Write((int) VisibilityType);
			p_Writer.Write((int) Bucket);
			p_Writer.Write(Score);
			p_Writer.Write(AdditionalValueMultiplier);
			p_Writer.Write(ShowForTeam);
			p_Writer.WriteNullBytes(3);
		}
	}
}
