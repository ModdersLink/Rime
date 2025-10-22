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

namespace fb.Venice;

[ContainerType(16, 128)]
public class ShieldComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool IgnoreFriendlyProjectiles { get; set; } = true;
	
	[ContainerField(0x71), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
	public bool IgnoreOutgoingProjectiles { get; set; } = true;
	
	[ContainerField(0x72), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
	public bool Render { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(IgnoreFriendlyProjectiles);
		p_Writer.Write(IgnoreOutgoingProjectiles);
		p_Writer.Write(Render);
		p_Writer.WriteNullBytes(13);
	}
}

