///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 88)]
	public class MatchmakingSession : 
		DataContainer
	{
		[ContainerField(8)]
		public MatchmakingSessionMode Mode { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint DurationMs { get; set; }

		[ContainerField(16)]
		public MatchmakingCriteria Criteria { get; set; } = new();

		[ContainerField(48)]
		public MatchmakingCreateGameParameters CreateGameParams { get; set; } = new();

		[ContainerField(80)]
		public CtrRef<MatchmakingSession> OnNotFound { get; set; } = new();

		[ContainerField(84)]
		public List<CtrRef<MatchmakingModifier>> Modifiers { get; set; } = new();

		public static void Deserialize(MatchmakingSession p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Mode = (MatchmakingSessionMode) p_Reader.ReadInt32();
			p_Instance.DurationMs = p_Reader.ReadUInt32();
			fb.MatchmakingCriteria.Deserialize(p_Instance.Criteria, p_Reader, p_Parser);
			fb.MatchmakingCreateGameParameters.Deserialize(p_Instance.CreateGameParams, p_Reader, p_Parser);
			p_Instance.OnNotFound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Modifiers.Clear();
			(RimeReader Reader, uint Count) s_Modifiers = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Modifiers.Count; ++i)
			{
				var s_CtrRef = new CtrRef<MatchmakingModifier>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Modifiers.Reader.ReadUInt32()));
				p_Instance.Modifiers.Add(s_CtrRef);
			}
			
			s_Modifiers.Reader.Dispose();
		}

	}
}
