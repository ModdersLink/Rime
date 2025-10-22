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

using fb.UI;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 96)]
public class UICompassDataBinding
	: fb.UI.UIDataBinding
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public UISimpleDataSource Heading { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public UISimpleDataSource Objectives { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public UISimpleDataSource Visibility { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public UISimpleDataSource ShowAirRadar { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public UISimpleDataSource RadarSweepDegree { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Heading.Serialize(p_Writer, p_EbxWriter);
		Objectives.Serialize(p_Writer, p_EbxWriter);
		Visibility.Serialize(p_Writer, p_EbxWriter);
		ShowAirRadar.Serialize(p_Writer, p_EbxWriter);
		RadarSweepDegree.Serialize(p_Writer, p_EbxWriter);
	}
}

