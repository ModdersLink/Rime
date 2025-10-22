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

[ContainerType(4, 376)]
public class GunSwayStandData
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public GunSwayBaseMoveJumpData NoZoom { get; set; } = new();
	
	[ContainerField(0xbc), JsonProperty(Order = 188)]
	public GunSwayBaseMoveJumpData Zoom { get; set; } = new();
	
}

