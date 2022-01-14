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
	[ContainerType(4, 20)]
	public class WeaponLagBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef EntityPitch { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef EntityYaw { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef PitchResult { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef YawResult { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef RollResult { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			EntityPitch.Serialize(p_Writer, p_EbxWriter);
			EntityYaw.Serialize(p_Writer, p_EbxWriter);
			PitchResult.Serialize(p_Writer, p_EbxWriter);
			YawResult.Serialize(p_Writer, p_EbxWriter);
			RollResult.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
