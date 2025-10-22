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


namespace fb.Core;

[ContainerType(8, 16)]
public class AudioCurve
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public List<AudioCurvePoint> Points { get; set; } = new();
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public AudioCurveType CurveType { get; set; } = AudioCurveType.AudioCurveType_Spline;
	
}

