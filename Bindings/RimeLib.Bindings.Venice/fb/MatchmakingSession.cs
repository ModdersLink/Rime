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
		public RefArray<MatchmakingModifier> Modifiers { get; set; } = new();

	}
}
