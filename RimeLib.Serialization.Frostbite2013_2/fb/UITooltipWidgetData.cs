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

[ContainerType(8, 120)]
public class UITooltipWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float LineSpacing { get; set; } = 0.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float FadeInDuration { get; set; } = 1.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float FadeOutDuration { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LineSpacing);
		p_Writer.Write(FadeInDuration);
		p_Writer.Write(FadeOutDuration);
		p_Writer.WriteNullBytes(4);
	}
}

