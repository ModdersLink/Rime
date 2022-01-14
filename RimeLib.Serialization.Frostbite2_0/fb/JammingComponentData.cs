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
	[ContainerType(16, 176)]
	public class JammingComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public SmokeJammingData SmokeJamming { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public AirMissileJammingData AirMissileJamming { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			SmokeJamming.Serialize(p_Writer, p_EbxWriter);
			AirMissileJamming.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(12);
		}
	}
}
