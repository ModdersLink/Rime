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

namespace fb.GameShared;

[ContainerType(8, 32)]
public class BoolUnlockValuePair
	: fb.GameShared.UnlockValuePair
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public bool DefaultValue { get; set; } = false;
	
	[ContainerField(0x19), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
	public bool UnlockedValue { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DefaultValue);
		p_Writer.Write(UnlockedValue);
		p_Writer.WriteNullBytes(6);
	}
}

