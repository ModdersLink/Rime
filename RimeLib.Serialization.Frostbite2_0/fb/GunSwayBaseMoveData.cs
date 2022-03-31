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
	[ContainerType(4, 76)]
	public class GunSwayBaseMoveData :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public GunSwayDispersionData BaseValue { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public GunSwayDispersionData Moving { get; set; } = new();
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public GunSwayRecoilData Recoil { get; set; } = new();
		
		[ContainerField(56), JsonProperty(Order = 56)]
		public GunSwayLagData GunSwayLag { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			BaseValue.Serialize(p_Writer, p_EbxWriter);
			Moving.Serialize(p_Writer, p_EbxWriter);
			Recoil.Serialize(p_Writer, p_EbxWriter);
			GunSwayLag.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
