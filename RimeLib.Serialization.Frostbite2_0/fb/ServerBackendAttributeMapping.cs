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
	[ContainerType(4, 12)]
	public class ServerBackendAttributeMapping :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public ServerBackendAttribute Attribute { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string Setting { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string DefaultValue { get; set; } = string.Empty;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Attribute);
			p_Writer.Write(p_EbxWriter.WriteString(Setting));
			p_Writer.Write(p_EbxWriter.WriteString(DefaultValue));
		}
	}
}
