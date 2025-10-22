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

[ContainerType(8, 88)]
public class UIImageDataBinding
	: fb.UI.UIDataBinding
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public UIAlignMode AlignMode { get; set; } = UIAlignMode.topLeft;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public UIScaleMode ScaleMode { get; set; } = UIScaleMode.noScaling;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string StaticImageUrl { get; set; } = string.Empty;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public UIDataSourceInfo ImageData { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public UIDataSourceInfo Visibility { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool Visible { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) AlignMode);
		p_Writer.Write((int) ScaleMode);
		p_Writer.Write(p_EbxWriter.WriteString(StaticImageUrl));
		ImageData.Serialize(p_Writer, p_EbxWriter);
		Visibility.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Visible);
		p_Writer.WriteNullBytes(7);
	}
}

