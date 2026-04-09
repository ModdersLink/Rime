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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 88)]
	public partial class MatchmakingSession :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private MatchmakingSessionMode _Mode = new();

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _DurationMs;

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private MatchmakingCriteria _Criteria = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private MatchmakingCreateGameParameters _CreateGameParams = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private CtrRef<MatchmakingSession> _OnNotFound = new();

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private RefArray<MatchmakingModifier> _Modifiers = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
