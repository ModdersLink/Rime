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
	[ContainerType(4, 20)]
	public class SoldierParachuteBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef Enabled { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef SteerLeftRight { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef AccelerateBrake { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef Pitch { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef Roll { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Enabled.Serialize(p_Writer, p_EbxWriter);
			SteerLeftRight.Serialize(p_Writer, p_EbxWriter);
			AccelerateBrake.Serialize(p_Writer, p_EbxWriter);
			Pitch.Serialize(p_Writer, p_EbxWriter);
			Roll.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
