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
	[ContainerType(4, 28)]
	public class SettingEntityData :
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string BoolSettingName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string IntSettingName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string FloatSettingName { get; set; } = string.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			p_Writer.Write(p_EbxWriter.WriteString(BoolSettingName));
			p_Writer.Write(p_EbxWriter.WriteString(IntSettingName));
			p_Writer.Write(p_EbxWriter.WriteString(FloatSettingName));
		}
	}
}
