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
using fb.Audio;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 72)]
public class CharacterCustomizationAsset
	: fb.Entity.DataContainerPolicyAsset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public UIHudIcon UIHudIcon { get; set; } = fb.GameShared.UIHudIcon.UIHudIcon_Unused;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string UIKitIconName { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string LabelSid { get; set; } = string.Empty;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<CustomizationTable> VisualTable { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<CustomizationTable> SpecializationTable { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public RefArray<VoiceOverLabel> VoiceOverLabels { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) UIHudIcon);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(UIKitIconName));
		p_Writer.Write(p_EbxWriter.WriteString(LabelSid));
		p_Writer.Write(p_EbxWriter.WriteImport(VisualTable));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SpecializationTable));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_VoiceOverLabels = p_EbxWriter.GetArrayWriter(VoiceOverLabels.GetType(), VoiceOverLabels.Count);
		p_Writer.Write(s_VoiceOverLabels.ArrayIndex);
		foreach (var s_Entry in VoiceOverLabels)
		{
			s_VoiceOverLabels.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

