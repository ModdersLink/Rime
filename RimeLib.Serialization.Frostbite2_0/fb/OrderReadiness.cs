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
	public class OrderReadiness :
		UrgencyUserData
	{
		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string OrderType { get; set; } = string.Empty;

		[ContainerField(24), JsonProperty(Order = 24)]
		public ReadinessState MinimumReadiness { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(OrderType));
			p_Writer.Write((int) MinimumReadiness);
		}
	}
}
