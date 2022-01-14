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
	[ContainerType(4, 28)]
	public class GameModeSize :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string ShortName { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string MetaIdentifier { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint PlayerCount { get; set; }
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public List<GameModeTeamSize> Teams { get; set; } = new();
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint RoundsPerMap { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public bool ForceSquad { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(p_EbxWriter.WriteString(ShortName));
			p_Writer.Write(p_EbxWriter.WriteString(MetaIdentifier));
			p_Writer.Write(PlayerCount);
			(RimeWriter Writer, uint ArrayIndex) s_Teams = p_EbxWriter.GetArrayWriter(Teams.GetType(), Teams.Count);
			p_Writer.Write(s_Teams.ArrayIndex);
			foreach (var s_Entry in Teams)
			{
				s_Entry.Serialize(s_Teams.Writer, p_EbxWriter);
			}
			p_Writer.Write(RoundsPerMap);
			p_Writer.Write(ForceSquad);
			p_Writer.WriteNullBytes(3);
		}
	}
}
