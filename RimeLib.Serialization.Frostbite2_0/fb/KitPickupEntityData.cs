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
	[ContainerType(16, 192)]
	public class KitPickupEntityData :
		PickupEntityData
	{
		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public bool KeepAdditionalWeapons { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
		public bool KeepAmmoState { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(KeepAdditionalWeapons);
			p_Writer.Write(KeepAmmoState);
			p_Writer.WriteNullBytes(14);
		}
	}
}
