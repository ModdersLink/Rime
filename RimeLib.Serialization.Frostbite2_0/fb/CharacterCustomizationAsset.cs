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
	[ContainerType(4, 32)]
	public class CharacterCustomizationAsset :
		Asset
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string LabelSid { get; set; } = string.Empty;

		[ContainerField(16), JsonProperty(Order = 16)]
		public UIHudIcon UIHudIcon { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<VoiceOverLabel> VoiceOverLabels { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<CustomizationTable> VisualTable { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<CustomizationTable> SpecializationTable { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(LabelSid));
			p_Writer.Write((int) UIHudIcon);
			(RimeWriter Writer, uint ArrayIndex) s_VoiceOverLabels = p_EbxWriter.GetArrayWriter(VoiceOverLabels.GetType(), VoiceOverLabels.Count);
			p_Writer.Write(s_VoiceOverLabels.ArrayIndex);
			foreach (var s_Entry in VoiceOverLabels)
			{
				s_VoiceOverLabels.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(VisualTable));
			p_Writer.Write(p_EbxWriter.WriteImport(SpecializationTable));
		}
	}
}
