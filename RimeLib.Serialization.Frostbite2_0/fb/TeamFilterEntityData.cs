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
	[ContainerType(16, 112)]
	public class TeamFilterEntityData :
		GameEntityData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public Realm Realm { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public TeamId Team { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public bool InvertFilter { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		public bool GenerateEventForEveryMatchingTeamMember { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			p_Writer.Write((int) Team);
			p_Writer.Write(InvertFilter);
			p_Writer.Write(GenerateEventForEveryMatchingTeamMember);
			p_Writer.WriteNullBytes(6);
		}
	}
}
