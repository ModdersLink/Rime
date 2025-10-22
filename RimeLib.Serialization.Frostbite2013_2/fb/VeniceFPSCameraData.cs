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
using fb.Render;
using fb.Entity;

namespace fb.Venice;

[ContainerType(16, 288)]
public class VeniceFPSCameraData
	: fb.GameShared.FPSCameraData
{
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float SuppressionBlurAmountMultiplier { get; set; } = 2.000f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float SuppressionBlurSizeMultiplier { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SuppressionBlurAmountMultiplier);
		p_Writer.Write(SuppressionBlurSizeMultiplier);
		p_Writer.WriteNullBytes(8);
	}
}

