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
	[ContainerType(4, 160)]
	public partial class UISquadCompData :
		UIComponentData
	{
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		private string _Squad15 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		private string _Squad32 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		private string _Squad1 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		private string _Squad2 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		private string _Squad3 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		private string _Squad4 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, JsonProperty(Order = 52)]
		private string _Squad5 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, JsonProperty(Order = 56)]
		private string _Squad6 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, JsonProperty(Order = 60)]
		private string _Squad7 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, JsonProperty(Order = 64)]
		private string _Squad8 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, JsonProperty(Order = 68)]
		private string _Squad9 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, JsonProperty(Order = 72)]
		private string _Squad10 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, JsonProperty(Order = 76)]
		private string _Squad11 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, JsonProperty(Order = 80)]
		private string _Squad12 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, JsonProperty(Order = 84)]
		private string _Squad13 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, JsonProperty(Order = 88)]
		private string _Squad14 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, JsonProperty(Order = 92)]
		private string _Squad16 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, JsonProperty(Order = 96)]
		private string _Squad24 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, JsonProperty(Order = 100)]
		private string _Squad17 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, JsonProperty(Order = 104)]
		private string _Squad18 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, JsonProperty(Order = 108)]
		private string _Squad19 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, JsonProperty(Order = 112)]
		private string _Squad20 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, JsonProperty(Order = 116)]
		private string _Squad21 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, JsonProperty(Order = 120)]
		private string _Squad22 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, JsonProperty(Order = 124)]
		private string _Squad23 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, JsonProperty(Order = 128)]
		private string _Squad31 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, JsonProperty(Order = 132)]
		private string _Squad25 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, JsonProperty(Order = 136)]
		private string _Squad26 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, JsonProperty(Order = 140)]
		private string _Squad27 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, JsonProperty(Order = 144)]
		private string _Squad28 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, JsonProperty(Order = 148)]
		private string _Squad29 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, JsonProperty(Order = 152)]
		private string _Squad30 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private bool _HideLocalSquadBoostData;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Squad15));
			p_Writer.Write(p_EbxWriter.WriteString(Squad32));
			p_Writer.Write(p_EbxWriter.WriteString(Squad1));
			p_Writer.Write(p_EbxWriter.WriteString(Squad2));
			p_Writer.Write(p_EbxWriter.WriteString(Squad3));
			p_Writer.Write(p_EbxWriter.WriteString(Squad4));
			p_Writer.Write(p_EbxWriter.WriteString(Squad5));
			p_Writer.Write(p_EbxWriter.WriteString(Squad6));
			p_Writer.Write(p_EbxWriter.WriteString(Squad7));
			p_Writer.Write(p_EbxWriter.WriteString(Squad8));
			p_Writer.Write(p_EbxWriter.WriteString(Squad9));
			p_Writer.Write(p_EbxWriter.WriteString(Squad10));
			p_Writer.Write(p_EbxWriter.WriteString(Squad11));
			p_Writer.Write(p_EbxWriter.WriteString(Squad12));
			p_Writer.Write(p_EbxWriter.WriteString(Squad13));
			p_Writer.Write(p_EbxWriter.WriteString(Squad14));
			p_Writer.Write(p_EbxWriter.WriteString(Squad16));
			p_Writer.Write(p_EbxWriter.WriteString(Squad24));
			p_Writer.Write(p_EbxWriter.WriteString(Squad17));
			p_Writer.Write(p_EbxWriter.WriteString(Squad18));
			p_Writer.Write(p_EbxWriter.WriteString(Squad19));
			p_Writer.Write(p_EbxWriter.WriteString(Squad20));
			p_Writer.Write(p_EbxWriter.WriteString(Squad21));
			p_Writer.Write(p_EbxWriter.WriteString(Squad22));
			p_Writer.Write(p_EbxWriter.WriteString(Squad23));
			p_Writer.Write(p_EbxWriter.WriteString(Squad31));
			p_Writer.Write(p_EbxWriter.WriteString(Squad25));
			p_Writer.Write(p_EbxWriter.WriteString(Squad26));
			p_Writer.Write(p_EbxWriter.WriteString(Squad27));
			p_Writer.Write(p_EbxWriter.WriteString(Squad28));
			p_Writer.Write(p_EbxWriter.WriteString(Squad29));
			p_Writer.Write(p_EbxWriter.WriteString(Squad30));
			p_Writer.Write(HideLocalSquadBoostData);
			p_Writer.WriteNullBytes(3);
		}
	}
}
