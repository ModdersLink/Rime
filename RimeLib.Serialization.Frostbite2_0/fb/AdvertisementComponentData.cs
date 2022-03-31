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
	[ContainerType(16, 128)]
	public class AdvertisementComponentData :
		PartComponentData
	{
		[ContainerField(112), LayoutImmutable, JsonProperty(Order = 112)]
		public string Identifier { get; set; } = string.Empty;

		[ContainerField(116), LayoutImmutable, JsonProperty(Order = 116)]
		public string AdTexture { get; set; } = string.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Identifier));
			p_Writer.Write(p_EbxWriter.WriteString(AdTexture));
			p_Writer.WriteNullBytes(8);
		}
	}
}
