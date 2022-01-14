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
	[ContainerType(4, 80)]
	public class AdvancedDogTagData :
		DogTagData
	{
		[ContainerField(68), LayoutImmutable, JsonProperty(Order = 68)]
		public string StatCode { get; set; } = string.Empty;

		[ContainerField(72), LayoutImmutable, JsonProperty(Order = 72)]
		public string StatSID { get; set; } = string.Empty;

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public bool IsStatMeasuredInTime { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(StatCode));
			p_Writer.Write(p_EbxWriter.WriteString(StatSID));
			p_Writer.Write(IsStatMeasuredInTime);
			p_Writer.WriteNullBytes(3);
		}
	}
}
