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

[ContainerType(8, 56)]
public class UIHUDMessageBinding
	: fb.UI.UIDataBinding
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public UISimpleDataSource MessageQuery { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public UISimpleDataSource VisibilityQuery { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int NumberOfRows { get; set; } = 1;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		MessageQuery.Serialize(p_Writer, p_EbxWriter);
		VisibilityQuery.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(NumberOfRows);
		p_Writer.WriteNullBytes(4);
	}
}

