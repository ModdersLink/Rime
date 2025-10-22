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

namespace fb.BFAI2Data;

[ContainerType(8, 40)]
public class CoverQueryScoreRuntime
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public int RelationMask { get; set; } = 0;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public int Flags { get; set; } = 0;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public int Filter { get; set; } = 0;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public CoverQueryStyle XStyle { get; set; } = CoverQueryStyle.CoverQueryStyle_Distance;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public CoverQueryPosition FromPosition { get; set; } = CoverQueryPosition.CoverQueryPosition_ActorPosition;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public CoverQueryPosition ToPosition { get; set; } = CoverQueryPosition.CoverQueryPosition_ActorPosition;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public CoverQueryDirection ReferenceDirection { get; set; } = CoverQueryDirection.CoverQueryDirection_CoverDirection;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public CoverQueryCurveXSource CurveXSource { get; set; } = CoverQueryCurveXSource.CoverQueryCurveXSource_Custom;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<float> Curve { get; set; } = new();
	
}

