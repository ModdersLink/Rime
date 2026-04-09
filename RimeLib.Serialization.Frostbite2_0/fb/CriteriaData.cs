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
	[ContainerType(4, 52)]
	public partial class CriteriaData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _CompletionValue;

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<CriteriaGateList> _GateList = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private StatEvent _Measuring = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<StatsCategoryBaseData> _ParamX = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<StatsCategoryBaseData> _ParamY = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private RefArray<StatsCategoryBaseData> _OrParamsX = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CriteriaType _CriteriaType = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		private string _DescriptionSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _ScaleFactor;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _Scale;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private bool _ShouldSummarize;

		[ObservableProperty]
		[property: ContainerField(49), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
		private bool _ShouldHide;

		[ObservableProperty]
		[property: ContainerField(50), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
		private bool _CountEvents;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(CompletionValue);
			p_Writer.Write(p_EbxWriter.WriteImport(GateList));
			p_Writer.Write((int) Measuring);
			p_Writer.Write(p_EbxWriter.WriteImport(ParamX));
			p_Writer.Write(p_EbxWriter.WriteImport(ParamY));
			(RimeWriter Writer, uint ArrayIndex) s_OrParamsX = p_EbxWriter.GetArrayWriter(OrParamsX.GetType(), OrParamsX.Count);
			p_Writer.Write(s_OrParamsX.ArrayIndex);
			foreach (var s_Entry in OrParamsX)
			{
				s_OrParamsX.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) CriteriaType);
			p_Writer.Write(p_EbxWriter.WriteString(DescriptionSid));
			p_Writer.Write(ScaleFactor);
			p_Writer.Write(Scale);
			p_Writer.Write(ShouldSummarize);
			p_Writer.Write(ShouldHide);
			p_Writer.Write(CountEvents);
			p_Writer.WriteNullBytes(1);
		}
	}
}
