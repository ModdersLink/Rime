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

[ContainerType(8, 32)]
public class SoldierEmoteNetworkedMessageMapping
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public SoldierEmote Emote { get; set; } = SoldierEmote.SoldierEmote_Spot;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<UIMessageType> Messages { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Emote);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Messages = p_EbxWriter.GetArrayWriter(Messages.GetType(), Messages.Count);
		p_Writer.Write(s_Messages.ArrayIndex);
		foreach (var s_Entry in Messages)
		{
			s_Messages.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
	}
}

