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
	[ContainerType(16, 112)]
	public class PlayerTakeOverTriggerEntityData :
		GameEntityData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public TeamId TeamId { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float TimeToLoseControl { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) TeamId);
			p_Writer.Write(TimeToLoseControl);
			p_Writer.WriteNullBytes(8);
		}
	}
}
