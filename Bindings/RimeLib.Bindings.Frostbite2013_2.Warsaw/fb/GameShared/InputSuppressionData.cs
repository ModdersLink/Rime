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


namespace fb.GameShared;

[ContainerType(8, 8)]
public class InputSuppressionData
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public List<ActionSuppressor> SuppressVehicleInput { get; set; } = new();
	
}

