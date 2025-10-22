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

using fb.Entity;
using fb.Core;

namespace fb.GameShared;

[ContainerType(16, 256)]
public class CharacterEntryComponentData
	: fb.GameShared.EntryComponentData
{
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public AimingConstraintsData AimingConstraints { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		AimingConstraints.Serialize(p_Writer, p_EbxWriter);
	}
}

