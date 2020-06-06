///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MatchmakingSession : 
		DataContainer
	{
		[ContainerField(8)]
		public MatchmakingSessionMode Mode { get; set; } = new MatchmakingSessionMode(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint DurationMs { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public MatchmakingCriteria Criteria { get; set; } = new MatchmakingCriteria(); // 0x10 (16)
		
		[ContainerField(48)]
		public MatchmakingCreateGameParameters CreateGameParams { get; set; } = new MatchmakingCreateGameParameters(); // 0x30 (48)
		
		[ContainerField(80)]
		public CtrRef<MatchmakingSession> OnNotFound { get; set; } = new CtrRef<MatchmakingSession>(); // 0x50 (80)
		
		[ContainerField(84)]
		public RefArray<MatchmakingModifier> Modifiers { get; set; } = new RefArray<MatchmakingModifier>(); // 0x54 (84)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088772358:
					Mode = (MatchmakingSessionMode) Enum.ToObject(typeof(MatchmakingSessionMode), p_Value);
					break;

				case 2674514117:
					DurationMs = (uint) p_Value;
					break;

				case 335452726:
					Criteria = (MatchmakingCriteria) p_Value;
					break;

				case 2627200403:
					CreateGameParams = (MatchmakingCreateGameParameters) p_Value;
					break;

				case 1193416487:
					OnNotFound = (CtrRef<MatchmakingSession>) p_Value;
					break;

				case 105828545:
					Modifiers = (RefArray<MatchmakingModifier>) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088772358:
					return Mode;

				case 2674514117:
					return DurationMs;

				case 335452726:
					return Criteria;

				case 2627200403:
					return CreateGameParams;

				case 1193416487:
					return OnNotFound;

				case 105828545:
					return Modifiers;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088772358:
					return typeof(MatchmakingSession).GetProperty(nameof(Mode));

				case 2674514117:
					return typeof(MatchmakingSession).GetProperty(nameof(DurationMs));

				case 335452726:
					return typeof(MatchmakingSession).GetProperty(nameof(Criteria));

				case 2627200403:
					return typeof(MatchmakingSession).GetProperty(nameof(CreateGameParams));

				case 1193416487:
					return typeof(MatchmakingSession).GetProperty(nameof(OnNotFound));

				case 105828545:
					return typeof(MatchmakingSession).GetProperty(nameof(Modifiers));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
