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
	[ContainerType(4, 4)]
	public class OnlineEnvironmentUrl :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public List<OnlineEnvironmentUrlData> Urls { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Urls = p_EbxWriter.GetArrayWriter(Urls.GetType(), Urls.Count);
			p_Writer.Write(s_Urls.ArrayIndex);
			foreach (var s_Entry in Urls)
			{
				s_Entry.Serialize(s_Urls.Writer, p_EbxWriter);
			}
		}
	}
}
