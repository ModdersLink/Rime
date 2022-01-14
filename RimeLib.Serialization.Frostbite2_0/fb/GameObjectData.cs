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
	[ContainerType(4, 12)]
	public class GameObjectData :
		GameDataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public ushort IndexInBlueprint { get; set; }

		[ContainerField(10), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
		public sbyte IsEventConnectionTarget { get; set; }

		[ContainerField(11), LayoutImmutable, Blittable, JsonProperty(Order = 11)]
		public sbyte IsPropertyConnectionTarget { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(IndexInBlueprint);
			p_Writer.Write(IsEventConnectionTarget);
			p_Writer.Write(IsPropertyConnectionTarget);
		}
	}
}
