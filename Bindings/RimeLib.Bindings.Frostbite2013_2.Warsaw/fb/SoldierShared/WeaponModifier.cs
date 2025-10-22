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

namespace fb.SoldierShared;

[ContainerType(8, 288)]
public class WeaponModifier
	: EbxSerializable
{
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public int Dummy2ToMakeFrostEDcompile { get; set; } = 0;
	
}

