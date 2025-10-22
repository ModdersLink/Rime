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

namespace fb.VeniceShared;

[ContainerType(8, 88)]
public class UIOptionsScreenAdjustScreenData
	: fb.VeniceShared.BFUICppScreenData
{
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string ArrowTexture { get; set; } = string.Empty;
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<UIElementFillData> SafeAreaStyle { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string ResetDefaultTitle { get; set; } = @"ID_M_REWARDMESSAGE_STARFORMAT";
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public int LeftArrowOffset { get; set; } = 0;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public int RightArrowOffset { get; set; } = 0;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public int UpArrowOffset { get; set; } = 0;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public int DownArrowOffset { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ArrowTexture));
		p_Writer.Write(p_EbxWriter.WriteImport(SafeAreaStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(ResetDefaultTitle));
		p_Writer.Write(LeftArrowOffset);
		p_Writer.Write(RightArrowOffset);
		p_Writer.Write(UpArrowOffset);
		p_Writer.Write(DownArrowOffset);
	}
}

