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
	public class DecisionConstantData :
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float NewEnemyDecideMaxDistance { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool AllowEmergencyGoalInterrupt { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		public bool AllowUninterruptibleBehaviours { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(NewEnemyDecideMaxDistance);
			p_Writer.Write(AllowEmergencyGoalInterrupt);
			p_Writer.Write(AllowUninterruptibleBehaviours);
			p_Writer.WriteNullBytes(2);
		}
	}
}
