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

namespace fb.VeniceShared;

[ContainerType(8, 48)]
public class GeographicalData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public UIGeoLatitude Latitude { get; set; } = new();
	
	[ContainerField(0x1c), JsonProperty(Order = 28)]
	public UIGeoLongitude Longitude { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float SeaLevelOffset { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Latitude.Serialize(p_Writer, p_EbxWriter);
		Longitude.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SeaLevelOffset);
		p_Writer.WriteNullBytes(4);
	}
}

