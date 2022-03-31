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
	[ContainerType(4, 40)]
	public class GameModeInformation :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public GamePlatform Platform { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<GameModeSize> Sizes { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public GameModeSize DefaultSize { get; set; } = new();
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool AllowFallbackToDefault { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Platform);
			(RimeWriter Writer, uint ArrayIndex) s_Sizes = p_EbxWriter.GetArrayWriter(Sizes.GetType(), Sizes.Count);
			p_Writer.Write(s_Sizes.ArrayIndex);
			foreach (var s_Entry in Sizes)
			{
				s_Entry.Serialize(s_Sizes.Writer, p_EbxWriter);
			}
			DefaultSize.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AllowFallbackToDefault);
			p_Writer.WriteNullBytes(3);
		}
	}
}
