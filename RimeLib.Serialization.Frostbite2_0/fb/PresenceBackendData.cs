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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 16)]
	public class PresenceBackendData :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<PresenceRequest> Requests { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Requests = p_EbxWriter.GetArrayWriter(Requests.GetType(), Requests.Count);
			p_Writer.Write(s_Requests.ArrayIndex);
			foreach (var s_Entry in Requests)
			{
				s_Requests.Writer.Write((int) s_Entry);
			}
		}
	}
}
