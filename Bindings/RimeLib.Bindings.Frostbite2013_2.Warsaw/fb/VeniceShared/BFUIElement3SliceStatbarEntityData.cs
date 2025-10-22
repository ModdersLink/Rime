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
using fb.GameShared;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 272)]
public class BFUIElement3SliceStatbarEntityData
	: fb.VeniceShared.UIElementStatbarBaseEntityData
{
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public CtrRef<BFUIElement3SliceStatbarStyle> Style { get; set; } = new();
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public BFUIColorizationData ColorizationData { get; set; } = new();
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public bool RightAligned { get; set; } = false;
	
	[ContainerField(0x105), LayoutImmutable, Blittable, JsonProperty(Order = 261)]
	public bool Vertical { get; set; } = false;
	
	[ContainerField(0x106), LayoutImmutable, Blittable, JsonProperty(Order = 262)]
	public bool UseColorization { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Style));
		p_Writer.WriteNullBytes(4);
		ColorizationData.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RightAligned);
		p_Writer.Write(Vertical);
		p_Writer.Write(UseColorization);
		p_Writer.WriteNullBytes(9);
	}
}

