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

namespace fb.Render;

[ContainerType(16, 128)]
public class ViewFxData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public PoissonRadialBlurData PoissonRadialBlur { get; set; } = new();
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float BlurAdd { get; set; } = 0.000f;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public ColorTintData ColorTint { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool PoissonRadialBlurEnable { get; set; } = false;
	
	[ContainerField(0x71), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
	public bool ColorTintEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		PoissonRadialBlur.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(BlurAdd);
		p_Writer.WriteNullBytes(8);
		ColorTint.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(PoissonRadialBlurEnable);
		p_Writer.Write(ColorTintEnable);
		p_Writer.WriteNullBytes(14);
	}
}

