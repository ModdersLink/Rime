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
	[ContainerType(4, 16)]
	public class CharacterMeleeBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef TriggerMelee { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef SelfActor { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef OtherActor { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef MeleeActive { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			TriggerMelee.Serialize(p_Writer, p_EbxWriter);
			SelfActor.Serialize(p_Writer, p_EbxWriter);
			OtherActor.Serialize(p_Writer, p_EbxWriter);
			MeleeActive.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
