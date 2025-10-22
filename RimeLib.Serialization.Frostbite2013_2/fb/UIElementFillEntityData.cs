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

[ContainerType(16, 224)]
public class UIElementFillEntityData
	: fb.GameShared.UIElementEntityData
{
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<UIElementFillData> Style { get; set; } = new();
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public bool DrawBackground { get; set; } = true;
	
	[ContainerField(0xd9), LayoutImmutable, Blittable, JsonProperty(Order = 217)]
	public bool DrawOutline { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Style));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DrawBackground);
		p_Writer.Write(DrawOutline);
		p_Writer.WriteNullBytes(6);
	}
}

