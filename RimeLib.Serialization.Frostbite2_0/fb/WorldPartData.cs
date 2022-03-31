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
	[ContainerType(4, 56)]
	public class WorldPartData :
		SpatialPrefabBlueprint
	{
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public GUID HackToSolveRealTimeTweakingIssue { get; set; } = GUID.Empty;

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public bool UseDeferredEntityCreation { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		public bool Enabled { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			HackToSolveRealTimeTweakingIssue.Serialize(p_Writer);
			p_Writer.Write(UseDeferredEntityCreation);
			p_Writer.Write(Enabled);
			p_Writer.WriteNullBytes(2);
		}
	}
}
