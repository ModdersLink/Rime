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

[ContainerType(8, 96)]
public class UIBarDataBinding
	: fb.UI.UIDataBinding
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public UIDataSourceInfo Visibility { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public UIDataSourceInfo Value { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public UIDataSourceInfo Color { get; set; } = new();
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public bool Refresh { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Visibility.Serialize(p_Writer, p_EbxWriter);
		Value.Serialize(p_Writer, p_EbxWriter);
		Color.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Refresh);
		p_Writer.WriteNullBytes(7);
	}
}

