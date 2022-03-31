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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 16)]
	public class SoldierEmoteNetworkedMessageMapping :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public SoldierEmote Emote { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public List<UIMessageType> Messages { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Emote);
			(RimeWriter Writer, uint ArrayIndex) s_Messages = p_EbxWriter.GetArrayWriter(Messages.GetType(), Messages.Count);
			p_Writer.Write(s_Messages.ArrayIndex);
			foreach (var s_Entry in Messages)
			{
				s_Messages.Writer.Write((int) s_Entry);
			}
		}
	}
}
