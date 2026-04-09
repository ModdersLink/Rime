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
	[ContainerType(4, 32)]
	public partial class CharacterCustomizationAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _LabelSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private UIHudIcon _UIHudIcon = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<VoiceOverLabel> _VoiceOverLabels = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<CustomizationTable> _VisualTable = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CtrRef<CustomizationTable> _SpecializationTable = new();

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
