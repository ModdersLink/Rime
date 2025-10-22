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

namespace fb.GameShared;

[ContainerType(8, 48)]
public class UITextureMappingAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public UITextureMappingCompartment Compartment { get; set; } = UITextureMappingCompartment.UITextureMappingCompartment_Default;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<UITextureMappingOutputEntry> Output { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool DisableAtlas { get; set; } = false;
	
	[ContainerField(0x29), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
	public bool ForceAtlas { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Compartment);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Output = p_EbxWriter.GetArrayWriter(Output.GetType(), Output.Count);
		p_Writer.Write(s_Output.ArrayIndex);
		foreach (var s_Entry in Output)
		{
			s_Entry.Serialize(s_Output.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DisableAtlas);
		p_Writer.Write(ForceAtlas);
		p_Writer.WriteNullBytes(6);
	}
}

