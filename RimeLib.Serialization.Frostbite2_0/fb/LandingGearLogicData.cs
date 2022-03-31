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
	[ContainerType(4, 32)]
	public class LandingGearLogicData :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public LandingGearConditionData RetractCondition { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public LandingGearConditionData DeployCondition { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			RetractCondition.Serialize(p_Writer, p_EbxWriter);
			DeployCondition.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
