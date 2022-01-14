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
	[ContainerType(16, 160)]
	public class CharacterEntityData :
		ControllableEntityData
	{
		[ContainerField(144), JsonProperty(Order = 144)]
		public PersonViewMode DefaultViewMode { get; set; } = new();

		[ContainerField(148), JsonProperty(Order = 148)]
		public PlayerSpawnType PlayerSpawnType { get; set; } = new();

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public bool CharacterLightingEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) DefaultViewMode);
			p_Writer.Write((int) PlayerSpawnType);
			p_Writer.Write(CharacterLightingEnable);
			p_Writer.WriteNullBytes(7);
		}
	}
}
