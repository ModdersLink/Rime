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
using fb.UI;

namespace fb.VeniceShared;

[ContainerType(8, 72)]
public class UICrosshairDataBinding
	: fb.UI.UIDataBinding
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public UISimpleDataSource Dispersion { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public UISimpleDataSource Zoomed { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public UISimpleDataSource Visibility { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float DispersionBaseOffset { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Dispersion.Serialize(p_Writer, p_EbxWriter);
		Zoomed.Serialize(p_Writer, p_EbxWriter);
		Visibility.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DispersionBaseOffset);
		p_Writer.WriteNullBytes(4);
	}
}

