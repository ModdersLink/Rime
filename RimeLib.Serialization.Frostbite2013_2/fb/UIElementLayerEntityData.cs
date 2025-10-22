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
public class UIElementLayerEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string LayerName { get; set; } = string.Empty;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<GameObjectData> Elements { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public UIElementInclusionSettings InclusionSettings { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public UICompareDataSource VisibilityDataSource { get; set; } = new();
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public bool Visible { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(LayerName));
		(RimeWriter Writer, uint ArrayIndex) s_Elements = p_EbxWriter.GetArrayWriter(Elements.GetType(), Elements.Count);
		p_Writer.Write(s_Elements.ArrayIndex);
		foreach (var s_Entry in Elements)
		{
			s_Elements.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		InclusionSettings.Serialize(p_Writer, p_EbxWriter);
		VisibilityDataSource.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Visible);
		p_Writer.WriteNullBytes(7);
	}
}

