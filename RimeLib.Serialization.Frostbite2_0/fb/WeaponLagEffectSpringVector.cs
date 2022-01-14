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
	public class WeaponLagEffectSpringVector :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public WeaponLagEffectSpringData SpringX { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public WeaponLagEffectSpringData SpringY { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public WeaponLagEffectSpringData SpringZ { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			SpringX.Serialize(p_Writer, p_EbxWriter);
			SpringY.Serialize(p_Writer, p_EbxWriter);
			SpringZ.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
