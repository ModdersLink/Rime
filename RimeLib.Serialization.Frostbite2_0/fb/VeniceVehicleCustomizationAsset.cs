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
	[ContainerType(4, 24)]
	public class VeniceVehicleCustomizationAsset :
		VehicleCustomizationAsset
	{
		[ContainerField(16), JsonProperty(Order = 16)]
		public VehicleCategory Category { get; set; } = new();

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string NameSid { get; set; } = string.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Category);
			p_Writer.Write(p_EbxWriter.WriteString(NameSid));
		}
	}
}
