///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(88), ContainerClass]
	public class MatchmakingSession : 
		DataContainer
	{
		protected MatchmakingSessionMode m_Mode = new MatchmakingSessionMode();
		[ContainerField(8), MemberInfoFlag(137), ContainerFieldNameHash(2088772358)]
		public MatchmakingSessionMode Mode { get { return m_Mode; } set { if (OnPropertyChanging("MatchmakingSession." + nameof(Mode), this, m_Mode, value)) m_Mode = value; } } // 0x8 (8)
		
		protected uint m_DurationMs = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2674514117)]
		public uint DurationMs { get { return m_DurationMs; } set { if (OnPropertyChanging("MatchmakingSession." + nameof(DurationMs), this, m_DurationMs, value)) m_DurationMs = value; } } // 0xC (12)
		
		protected MatchmakingCriteria m_Criteria = new MatchmakingCriteria();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(335452726)]
		public MatchmakingCriteria Criteria { get { return m_Criteria; } set { if (OnPropertyChanging("MatchmakingSession." + nameof(Criteria), this, m_Criteria, value)) m_Criteria = value; } } // 0x10 (16)
		
		protected MatchmakingCreateGameParameters m_CreateGameParams = new MatchmakingCreateGameParameters();
		[ContainerField(48), MemberInfoFlag(41), ContainerFieldNameHash(2627200403)]
		public MatchmakingCreateGameParameters CreateGameParams { get { return m_CreateGameParams; } set { if (OnPropertyChanging("MatchmakingSession." + nameof(CreateGameParams), this, m_CreateGameParams, value)) m_CreateGameParams = value; } } // 0x30 (48)
		
		protected CtrRef<MatchmakingSession> m_OnNotFound = new CtrRef<MatchmakingSession>();
		[ContainerField(80), MemberInfoFlag(53), ContainerFieldNameHash(1193416487), ContainerCtrRef]
		public CtrRef<MatchmakingSession> OnNotFound { get { return m_OnNotFound; } set { if (OnPropertyChanging("MatchmakingSession." + nameof(OnNotFound), this, m_OnNotFound, value)) m_OnNotFound = value; } } // 0x50 (80)
		
		protected RefArray<MatchmakingModifier> m_Modifiers = new RefArray<MatchmakingModifier>();
		[ContainerField(84), MemberInfoFlag(65), ContainerFieldNameHash(105828545), ContainerRefArray]
		public RefArray<MatchmakingModifier> Modifiers { get { return m_Modifiers; } set { if (OnPropertyChanging("MatchmakingSession." + nameof(Modifiers), this, m_Modifiers, value)) m_Modifiers = value; } } // 0x54 (84)
		
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
