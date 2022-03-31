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
	[ContainerType(16, 144)]
	public class ScenarioWaypointData :
		AbstractLocoWaypointData
	{
		[ContainerField(48), JsonProperty(Order = 48)]
		public AntRef ScenarioAntRef { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public ScenarioTaskData ScenarioTask { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ScenarioAntRef.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(12);
			ScenarioTask.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
