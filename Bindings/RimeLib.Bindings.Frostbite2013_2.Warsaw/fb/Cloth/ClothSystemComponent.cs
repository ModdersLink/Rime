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
using fb.Entity;

namespace fb.Cloth;

[ContainerType(8, 48)]
public class ClothSystemComponent
	: fb.Entity.SubWorldDataComponent
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public QualityScalableInt VertexBuffersSize { get; set; } = new()
	{
		Ultra = -1,
		High = -1,
		Medium = -1,
		Low = -1,
	};
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public QualityScalableFloat ActivationRadius { get; set; } = new()
	{
		Ultra = 250.000f,
		High = 250.000f,
		Medium = 250.000f,
		Low = 250.000f,
	};
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		VertexBuffersSize.Serialize(p_Writer, p_EbxWriter);
		ActivationRadius.Serialize(p_Writer, p_EbxWriter);
	}
}

