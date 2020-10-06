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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(144), ContainerClass]
	public class ObjectiveEntityData : 
		GameEntityData
	{
		protected string m_ObjectiveBriefSid = string.Empty;
		[ContainerField(96), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2106225038)]
		public string ObjectiveBriefSid { get { return m_ObjectiveBriefSid; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(ObjectiveBriefSid), this, m_ObjectiveBriefSid, value)) m_ObjectiveBriefSid = value; } } // 0x60 (96)
		
		protected string m_ObjectiveSid = string.Empty;
		[ContainerField(100), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2081694452)]
		public string ObjectiveSid { get { return m_ObjectiveSid; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(ObjectiveSid), this, m_ObjectiveSid, value)) m_ObjectiveSid = value; } } // 0x64 (100)
		
		protected CtrRef<MissionObjectiveHudData> m_HudData = new CtrRef<MissionObjectiveHudData>();
		[ContainerField(104), MemberInfoFlag(53), ContainerFieldNameHash(2639805868), ContainerCtrRef]
		public CtrRef<MissionObjectiveHudData> HudData { get { return m_HudData; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(HudData), this, m_HudData, value)) m_HudData = value; } } // 0x68 (104)
		
		protected ObjectiveType m_ObjectiveType = new ObjectiveType();
		[ContainerField(108), MemberInfoFlag(137), ContainerFieldNameHash(4271777266)]
		public ObjectiveType ObjectiveType { get { return m_ObjectiveType; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(ObjectiveType), this, m_ObjectiveType, value)) m_ObjectiveType = value; } } // 0x6C (108)
		
		protected float m_DisplayTime = new float();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1925139498)]
		public float DisplayTime { get { return m_DisplayTime; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(DisplayTime), this, m_DisplayTime, value)) m_DisplayTime = value; } } // 0x70 (112)
		
		protected float m_DelayTime = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3694246245)]
		public float DelayTime { get { return m_DelayTime; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(DelayTime), this, m_DelayTime, value)) m_DelayTime = value; } } // 0x74 (116)
		
		protected SquadId m_SquadId = new SquadId();
		[ContainerField(120), MemberInfoFlag(137), ContainerFieldNameHash(2312333818)]
		public SquadId SquadId { get { return m_SquadId; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(SquadId), this, m_SquadId, value)) m_SquadId = value; } } // 0x78 (120)
		
		protected TeamId m_TeamId = new TeamId();
		[ContainerField(124), MemberInfoFlag(137), ContainerFieldNameHash(3220374101)]
		public TeamId TeamId { get { return m_TeamId; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(TeamId), this, m_TeamId, value)) m_TeamId = value; } } // 0x7C (124)
		
		protected string m_SuccessSid = string.Empty;
		[ContainerField(128), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1551323064)]
		public string SuccessSid { get { return m_SuccessSid; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(SuccessSid), this, m_SuccessSid, value)) m_SuccessSid = value; } } // 0x80 (128)
		
		protected MessageReciever m_Reciever = new MessageReciever();
		[ContainerField(132), MemberInfoFlag(137), ContainerFieldNameHash(688681692)]
		public MessageReciever Reciever { get { return m_Reciever; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(Reciever), this, m_Reciever, value)) m_Reciever = value; } } // 0x84 (132)
		
		protected bool m_RetriggerSuccessOnShowObjective = new bool();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1462402436)]
		public bool RetriggerSuccessOnShowObjective { get { return m_RetriggerSuccessOnShowObjective; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(RetriggerSuccessOnShowObjective), this, m_RetriggerSuccessOnShowObjective, value)) m_RetriggerSuccessOnShowObjective = value; } } // 0x88 (136)
		
		protected bool m_Tutorial = new bool();
		[ContainerField(137), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3626722569)]
		public bool Tutorial { get { return m_Tutorial; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(Tutorial), this, m_Tutorial, value)) m_Tutorial = value; } } // 0x89 (137)
		
		protected bool m_DisplaySuccess = new bool();
		[ContainerField(138), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4179535996)]
		public bool DisplaySuccess { get { return m_DisplaySuccess; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(DisplaySuccess), this, m_DisplaySuccess, value)) m_DisplaySuccess = value; } } // 0x8A (138)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2106225038:
					ObjectiveBriefSid = (string) p_Value;
					break;

				case 2081694452:
					ObjectiveSid = (string) p_Value;
					break;

				case 2639805868:
					HudData = (CtrRef<MissionObjectiveHudData>) p_Value;
					break;

				case 4271777266:
					ObjectiveType = (ObjectiveType) Enum.ToObject(typeof(ObjectiveType), p_Value);
					break;

				case 1925139498:
					DisplayTime = (float) p_Value;
					break;

				case 3694246245:
					DelayTime = (float) p_Value;
					break;

				case 2312333818:
					SquadId = (SquadId) Enum.ToObject(typeof(SquadId), p_Value);
					break;

				case 3220374101:
					TeamId = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 1551323064:
					SuccessSid = (string) p_Value;
					break;

				case 688681692:
					Reciever = (MessageReciever) Enum.ToObject(typeof(MessageReciever), p_Value);
					break;

				case 1462402436:
					RetriggerSuccessOnShowObjective = (bool) p_Value;
					break;

				case 3626722569:
					Tutorial = (bool) p_Value;
					break;

				case 4179535996:
					DisplaySuccess = (bool) p_Value;
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
				case 2106225038:
					return ObjectiveBriefSid;

				case 2081694452:
					return ObjectiveSid;

				case 2639805868:
					return HudData;

				case 4271777266:
					return ObjectiveType;

				case 1925139498:
					return DisplayTime;

				case 3694246245:
					return DelayTime;

				case 2312333818:
					return SquadId;

				case 3220374101:
					return TeamId;

				case 1551323064:
					return SuccessSid;

				case 688681692:
					return Reciever;

				case 1462402436:
					return RetriggerSuccessOnShowObjective;

				case 3626722569:
					return Tutorial;

				case 4179535996:
					return DisplaySuccess;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2106225038:
					return typeof(ObjectiveEntityData).GetProperty(nameof(ObjectiveBriefSid));

				case 2081694452:
					return typeof(ObjectiveEntityData).GetProperty(nameof(ObjectiveSid));

				case 2639805868:
					return typeof(ObjectiveEntityData).GetProperty(nameof(HudData));

				case 4271777266:
					return typeof(ObjectiveEntityData).GetProperty(nameof(ObjectiveType));

				case 1925139498:
					return typeof(ObjectiveEntityData).GetProperty(nameof(DisplayTime));

				case 3694246245:
					return typeof(ObjectiveEntityData).GetProperty(nameof(DelayTime));

				case 2312333818:
					return typeof(ObjectiveEntityData).GetProperty(nameof(SquadId));

				case 3220374101:
					return typeof(ObjectiveEntityData).GetProperty(nameof(TeamId));

				case 1551323064:
					return typeof(ObjectiveEntityData).GetProperty(nameof(SuccessSid));

				case 688681692:
					return typeof(ObjectiveEntityData).GetProperty(nameof(Reciever));

				case 1462402436:
					return typeof(ObjectiveEntityData).GetProperty(nameof(RetriggerSuccessOnShowObjective));

				case 3626722569:
					return typeof(ObjectiveEntityData).GetProperty(nameof(Tutorial));

				case 4179535996:
					return typeof(ObjectiveEntityData).GetProperty(nameof(DisplaySuccess));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
