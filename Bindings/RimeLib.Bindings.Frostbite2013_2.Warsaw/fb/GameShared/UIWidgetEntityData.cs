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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 104)]
public class UIWidgetEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public UIElementSize Size { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<UIElementLayerEntityData> Layers { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<UITextureMappingAsset> TextureMappings { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<GameObjectData> Components { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public UICompareDataSource VisibilityDataSource { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public List<string> InputEvents { get; set; } = new();
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public bool Visible { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Size.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Layers = p_EbxWriter.GetArrayWriter(Layers.GetType(), Layers.Count);
		p_Writer.Write(s_Layers.ArrayIndex);
		foreach (var s_Entry in Layers)
		{
			s_Layers.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_TextureMappings = p_EbxWriter.GetArrayWriter(TextureMappings.GetType(), TextureMappings.Count);
		p_Writer.Write(s_TextureMappings.ArrayIndex);
		foreach (var s_Entry in TextureMappings)
		{
			s_TextureMappings.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Components = p_EbxWriter.GetArrayWriter(Components.GetType(), Components.Count);
		p_Writer.Write(s_Components.ArrayIndex);
		foreach (var s_Entry in Components)
		{
			s_Components.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		VisibilityDataSource.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_InputEvents = p_EbxWriter.GetArrayWriter(InputEvents.GetType(), InputEvents.Count);
		p_Writer.Write(s_InputEvents.ArrayIndex);
		foreach (var s_Entry in InputEvents)
		{
			s_InputEvents.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Visible);
		p_Writer.WriteNullBytes(7);
	}
}

