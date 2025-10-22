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

using fb.GameShared;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 72)]
public class NuiSpeechInputActionPhrase
	: fb.VeniceShared.NuiSpeechPhrase
{
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public InputDeviceMessageEvent Event { get; set; } = InputDeviceMessageEvent.IDME_ThrowGrenade;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Event);
		p_Writer.WriteNullBytes(4);
	}
}

