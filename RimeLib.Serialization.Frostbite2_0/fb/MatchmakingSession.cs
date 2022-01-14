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
	[ContainerType(4, 88)]
	public class MatchmakingSession :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public MatchmakingSessionMode Mode { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint DurationMs { get; set; }

		[ContainerField(16), JsonProperty(Order = 16)]
		public MatchmakingCriteria Criteria { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public MatchmakingCreateGameParameters CreateGameParams { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public CtrRef<MatchmakingSession> OnNotFound { get; set; } = new();

		[ContainerField(84), JsonProperty(Order = 84)]
		public RefArray<MatchmakingModifier> Modifiers { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Mode);
			p_Writer.Write(DurationMs);
			Criteria.Serialize(p_Writer, p_EbxWriter);
			CreateGameParams.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(OnNotFound));
			(RimeWriter Writer, uint ArrayIndex) s_Modifiers = p_EbxWriter.GetArrayWriter(Modifiers.GetType(), Modifiers.Count);
			p_Writer.Write(s_Modifiers.ArrayIndex);
			foreach (var s_Entry in Modifiers)
			{
				s_Modifiers.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
