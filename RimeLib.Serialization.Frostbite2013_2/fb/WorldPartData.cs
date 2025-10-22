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

namespace fb.Entity;

[ContainerType(8, 96)]
public class WorldPartData
	: fb.Entity.PrefabBlueprint
{
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public GUID HackToSolveRealTimeTweakingIssue { get; set; } = GUID.Empty;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public bool Enabled { get; set; } = true;
	
	[ContainerField(0x59), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
	public bool UseDeferredEntityCreation { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		HackToSolveRealTimeTweakingIssue.Serialize(p_Writer);
		p_Writer.Write(Enabled);
		p_Writer.Write(UseDeferredEntityCreation);
		p_Writer.WriteNullBytes(6);
	}
}

