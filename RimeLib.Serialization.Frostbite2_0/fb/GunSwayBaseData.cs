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
	[ContainerType(4, 60)]
	public class GunSwayBaseData :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public GunSwayDispersionData BaseValue { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public GunSwayRecoilData Recoil { get; set; } = new();
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public GunSwayLagData GunSwayLag { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			BaseValue.Serialize(p_Writer, p_EbxWriter);
			Recoil.Serialize(p_Writer, p_EbxWriter);
			GunSwayLag.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
