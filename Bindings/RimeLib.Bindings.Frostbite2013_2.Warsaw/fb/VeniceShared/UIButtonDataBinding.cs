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

[ContainerType(8, 80)]
public class UIButtonDataBinding
	: fb.UI.UIDataBinding
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public UIDataSourceInfo ButtonsDatasource { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public UIButtonSet DefaultButtonSet { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public UIDataSourceInfo Visibility { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool InvertVisible { get; set; } = false;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool Visible { get; set; } = true;
	
	[ContainerField(0x4a), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
	public bool InputOnRelease { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		ButtonsDatasource.Serialize(p_Writer, p_EbxWriter);
		DefaultButtonSet.Serialize(p_Writer, p_EbxWriter);
		Visibility.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(InvertVisible);
		p_Writer.Write(Visible);
		p_Writer.Write(InputOnRelease);
		p_Writer.WriteNullBytes(5);
	}
}

