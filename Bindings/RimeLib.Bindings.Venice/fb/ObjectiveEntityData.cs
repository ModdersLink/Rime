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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 144)]
	public class ObjectiveEntityData : 
		GameEntityData
	{
		protected string m_ObjectiveBriefSid = string.Empty;
		[ContainerField(Name: "ObjectiveBriefSid", Offset: 96, NameHash: 2106225038, Flags: 16509), LayoutImmutable]
		public string ObjectiveBriefSid { get { return m_ObjectiveBriefSid; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(ObjectiveBriefSid), this, m_ObjectiveBriefSid, value)) m_ObjectiveBriefSid = value; } } // 0x60 (96)
		
		protected string m_ObjectiveSid = string.Empty;
		[ContainerField(Name: "ObjectiveSid", Offset: 100, NameHash: 2081694452, Flags: 16509), LayoutImmutable]
		public string ObjectiveSid { get { return m_ObjectiveSid; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(ObjectiveSid), this, m_ObjectiveSid, value)) m_ObjectiveSid = value; } } // 0x64 (100)
		
		protected CtrRef<MissionObjectiveHudData> m_HudData = new CtrRef<MissionObjectiveHudData>();
		[ContainerField(Name: "HudData", Offset: 104, NameHash: 2639805868, Flags: 53)]
		public CtrRef<MissionObjectiveHudData> HudData { get { return m_HudData; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(HudData), this, m_HudData, value)) m_HudData = value; } } // 0x68 (104)
		
		protected ObjectiveType m_ObjectiveType = new ObjectiveType();
		[ContainerField(Name: "ObjectiveType", Offset: 108, NameHash: 4271777266, Flags: 137)]
		public ObjectiveType ObjectiveType { get { return m_ObjectiveType; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(ObjectiveType), this, m_ObjectiveType, value)) m_ObjectiveType = value; } } // 0x6C (108)
		
		protected float m_DisplayTime = new float();
		[ContainerField(Name: "DisplayTime", Offset: 112, NameHash: 1925139498, Flags: 49469), LayoutImmutable, Blittable]
		public float DisplayTime { get { return m_DisplayTime; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(DisplayTime), this, m_DisplayTime, value)) m_DisplayTime = value; } } // 0x70 (112)
		
		protected float m_DelayTime = new float();
		[ContainerField(Name: "DelayTime", Offset: 116, NameHash: 3694246245, Flags: 49469), LayoutImmutable, Blittable]
		public float DelayTime { get { return m_DelayTime; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(DelayTime), this, m_DelayTime, value)) m_DelayTime = value; } } // 0x74 (116)
		
		protected SquadId m_SquadId = new SquadId();
		[ContainerField(Name: "SquadId", Offset: 120, NameHash: 2312333818, Flags: 137)]
		public SquadId SquadId { get { return m_SquadId; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(SquadId), this, m_SquadId, value)) m_SquadId = value; } } // 0x78 (120)
		
		protected TeamId m_TeamId = new TeamId();
		[ContainerField(Name: "TeamId", Offset: 124, NameHash: 3220374101, Flags: 137)]
		public TeamId TeamId { get { return m_TeamId; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(TeamId), this, m_TeamId, value)) m_TeamId = value; } } // 0x7C (124)
		
		protected string m_SuccessSid = string.Empty;
		[ContainerField(Name: "SuccessSid", Offset: 128, NameHash: 1551323064, Flags: 16509), LayoutImmutable]
		public string SuccessSid { get { return m_SuccessSid; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(SuccessSid), this, m_SuccessSid, value)) m_SuccessSid = value; } } // 0x80 (128)
		
		protected MessageReciever m_Reciever = new MessageReciever();
		[ContainerField(Name: "Reciever", Offset: 132, NameHash: 688681692, Flags: 137)]
		public MessageReciever Reciever { get { return m_Reciever; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(Reciever), this, m_Reciever, value)) m_Reciever = value; } } // 0x84 (132)
		
		protected bool m_RetriggerSuccessOnShowObjective = new bool();
		[ContainerField(Name: "RetriggerSuccessOnShowObjective", Offset: 136, NameHash: 1462402436, Flags: 49325), LayoutImmutable, Blittable]
		public bool RetriggerSuccessOnShowObjective { get { return m_RetriggerSuccessOnShowObjective; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(RetriggerSuccessOnShowObjective), this, m_RetriggerSuccessOnShowObjective, value)) m_RetriggerSuccessOnShowObjective = value; } } // 0x88 (136)
		
		protected bool m_Tutorial = new bool();
		[ContainerField(Name: "Tutorial", Offset: 137, NameHash: 3626722569, Flags: 49325), LayoutImmutable, Blittable]
		public bool Tutorial { get { return m_Tutorial; } set { if (OnPropertyChanging("ObjectiveEntityData." + nameof(Tutorial), this, m_Tutorial, value)) m_Tutorial = value; } } // 0x89 (137)
		
		protected bool m_DisplaySuccess = new bool();
		[ContainerField(Name: "DisplaySuccess", Offset: 138, NameHash: 4179535996, Flags: 49325), LayoutImmutable, Blittable]
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
