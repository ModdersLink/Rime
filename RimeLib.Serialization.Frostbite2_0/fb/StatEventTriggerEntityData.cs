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
	[ContainerType(16, 112)]
	public class StatEventTriggerEntityData :
		GameEntityData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public StatEvent StatEvent { get; set; } = new();

		[ContainerField(100), LayoutImmutable, JsonProperty(Order = 100)]
		public string MiscParamX { get; set; } = string.Empty;

		[ContainerField(104), LayoutImmutable, JsonProperty(Order = 104)]
		public string MiscParamY { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public bool SendToAll { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) StatEvent);
			p_Writer.Write(p_EbxWriter.WriteString(MiscParamX));
			p_Writer.Write(p_EbxWriter.WriteString(MiscParamY));
			p_Writer.Write(SendToAll);
			p_Writer.WriteNullBytes(3);
		}
	}
}
