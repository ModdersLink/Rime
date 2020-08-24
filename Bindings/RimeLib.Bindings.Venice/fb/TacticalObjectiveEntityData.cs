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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class TacticalObjectiveEntityData : 
		GameEntityData
	{
		protected string m_MissionSid = string.Empty;
		[ContainerField(96), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1231602263)]
		public string MissionSid { get { return m_MissionSid; } set { if (OnPropertyChanging("TacticalObjectiveEntityData." + nameof(MissionSid), this, m_MissionSid, value)) m_MissionSid = value; } } // 0x60 (96)
		
		protected string m_BriefingSidTeam1 = string.Empty;
		[ContainerField(100), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3340727469)]
		public string BriefingSidTeam1 { get { return m_BriefingSidTeam1; } set { if (OnPropertyChanging("TacticalObjectiveEntityData." + nameof(BriefingSidTeam1), this, m_BriefingSidTeam1, value)) m_BriefingSidTeam1 = value; } } // 0x64 (100)
		
		protected string m_BriefingSidTeam2 = string.Empty;
		[ContainerField(104), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3340727470)]
		public string BriefingSidTeam2 { get { return m_BriefingSidTeam2; } set { if (OnPropertyChanging("TacticalObjectiveEntityData." + nameof(BriefingSidTeam2), this, m_BriefingSidTeam2, value)) m_BriefingSidTeam2 = value; } } // 0x68 (104)
		
		protected float m_Team1Timer = new float();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2082003598)]
		public float Team1Timer { get { return m_Team1Timer; } set { if (OnPropertyChanging("TacticalObjectiveEntityData." + nameof(Team1Timer), this, m_Team1Timer, value)) m_Team1Timer = value; } } // 0x6C (108)
		
		protected float m_Team2Timer = new float();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2125739053)]
		public float Team2Timer { get { return m_Team2Timer; } set { if (OnPropertyChanging("TacticalObjectiveEntityData." + nameof(Team2Timer), this, m_Team2Timer, value)) m_Team2Timer = value; } } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1231602263:
					MissionSid = (string) p_Value;
					break;

				case 3340727469:
					BriefingSidTeam1 = (string) p_Value;
					break;

				case 3340727470:
					BriefingSidTeam2 = (string) p_Value;
					break;

				case 2082003598:
					Team1Timer = (float) p_Value;
					break;

				case 2125739053:
					Team2Timer = (float) p_Value;
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
				case 1231602263:
					return MissionSid;

				case 3340727469:
					return BriefingSidTeam1;

				case 3340727470:
					return BriefingSidTeam2;

				case 2082003598:
					return Team1Timer;

				case 2125739053:
					return Team2Timer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1231602263:
					return typeof(TacticalObjectiveEntityData).GetProperty(nameof(MissionSid));

				case 3340727469:
					return typeof(TacticalObjectiveEntityData).GetProperty(nameof(BriefingSidTeam1));

				case 3340727470:
					return typeof(TacticalObjectiveEntityData).GetProperty(nameof(BriefingSidTeam2));

				case 2082003598:
					return typeof(TacticalObjectiveEntityData).GetProperty(nameof(Team1Timer));

				case 2125739053:
					return typeof(TacticalObjectiveEntityData).GetProperty(nameof(Team2Timer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
