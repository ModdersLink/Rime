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
	[ContainerType(4, 36)]
	public class ReadinessLevels :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public ReadinessLevelCharacteristics Patrol { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public ReadinessLevelCharacteristics Ready { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public ReadinessLevelCharacteristics Combat { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Patrol.Serialize(p_Writer, p_EbxWriter);
			Ready.Serialize(p_Writer, p_EbxWriter);
			Combat.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
