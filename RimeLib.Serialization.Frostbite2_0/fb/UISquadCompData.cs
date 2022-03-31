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

namespace fb
{
	[ContainerType(4, 160)]
	public class UISquadCompData :
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string Squad15 { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string Squad32 { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string Squad1 { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		public string Squad2 { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		public string Squad3 { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		public string Squad4 { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable, JsonProperty(Order = 52)]
		public string Squad5 { get; set; } = string.Empty;

		[ContainerField(56), LayoutImmutable, JsonProperty(Order = 56)]
		public string Squad6 { get; set; } = string.Empty;

		[ContainerField(60), LayoutImmutable, JsonProperty(Order = 60)]
		public string Squad7 { get; set; } = string.Empty;

		[ContainerField(64), LayoutImmutable, JsonProperty(Order = 64)]
		public string Squad8 { get; set; } = string.Empty;

		[ContainerField(68), LayoutImmutable, JsonProperty(Order = 68)]
		public string Squad9 { get; set; } = string.Empty;

		[ContainerField(72), LayoutImmutable, JsonProperty(Order = 72)]
		public string Squad10 { get; set; } = string.Empty;

		[ContainerField(76), LayoutImmutable, JsonProperty(Order = 76)]
		public string Squad11 { get; set; } = string.Empty;

		[ContainerField(80), LayoutImmutable, JsonProperty(Order = 80)]
		public string Squad12 { get; set; } = string.Empty;

		[ContainerField(84), LayoutImmutable, JsonProperty(Order = 84)]
		public string Squad13 { get; set; } = string.Empty;

		[ContainerField(88), LayoutImmutable, JsonProperty(Order = 88)]
		public string Squad14 { get; set; } = string.Empty;

		[ContainerField(92), LayoutImmutable, JsonProperty(Order = 92)]
		public string Squad16 { get; set; } = string.Empty;

		[ContainerField(96), LayoutImmutable, JsonProperty(Order = 96)]
		public string Squad24 { get; set; } = string.Empty;

		[ContainerField(100), LayoutImmutable, JsonProperty(Order = 100)]
		public string Squad17 { get; set; } = string.Empty;

		[ContainerField(104), LayoutImmutable, JsonProperty(Order = 104)]
		public string Squad18 { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable, JsonProperty(Order = 108)]
		public string Squad19 { get; set; } = string.Empty;

		[ContainerField(112), LayoutImmutable, JsonProperty(Order = 112)]
		public string Squad20 { get; set; } = string.Empty;

		[ContainerField(116), LayoutImmutable, JsonProperty(Order = 116)]
		public string Squad21 { get; set; } = string.Empty;

		[ContainerField(120), LayoutImmutable, JsonProperty(Order = 120)]
		public string Squad22 { get; set; } = string.Empty;

		[ContainerField(124), LayoutImmutable, JsonProperty(Order = 124)]
		public string Squad23 { get; set; } = string.Empty;

		[ContainerField(128), LayoutImmutable, JsonProperty(Order = 128)]
		public string Squad31 { get; set; } = string.Empty;

		[ContainerField(132), LayoutImmutable, JsonProperty(Order = 132)]
		public string Squad25 { get; set; } = string.Empty;

		[ContainerField(136), LayoutImmutable, JsonProperty(Order = 136)]
		public string Squad26 { get; set; } = string.Empty;

		[ContainerField(140), LayoutImmutable, JsonProperty(Order = 140)]
		public string Squad27 { get; set; } = string.Empty;

		[ContainerField(144), LayoutImmutable, JsonProperty(Order = 144)]
		public string Squad28 { get; set; } = string.Empty;

		[ContainerField(148), LayoutImmutable, JsonProperty(Order = 148)]
		public string Squad29 { get; set; } = string.Empty;

		[ContainerField(152), LayoutImmutable, JsonProperty(Order = 152)]
		public string Squad30 { get; set; } = string.Empty;

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public bool HideLocalSquadBoostData { get; set; }

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
