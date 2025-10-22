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


namespace fb.SoldierShared;

[ContainerType(4, 184)]
public class GunSwayCrouchProneData
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public GunSwayBaseMoveData NoZoom { get; set; } = new();
	
	[ContainerField(0x5c), JsonProperty(Order = 92)]
	public GunSwayBaseMoveData Zoom { get; set; } = new();
	
}

