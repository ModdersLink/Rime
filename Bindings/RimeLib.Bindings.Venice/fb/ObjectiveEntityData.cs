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
    [ContainerType(16)]
	public class ObjectiveEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable]
		public string ObjectiveBriefSid { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable]
		public string ObjectiveSid { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public CtrRef<MissionObjectiveHudData> HudData { get; set; } = new CtrRef<MissionObjectiveHudData>(); // 0x68 (104)
		
		[ContainerField(108)]
		public ObjectiveType ObjectiveType { get; set; } = new ObjectiveType(); // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float DisplayTime { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float DelayTime { get; set; } // 0x74 (116)
		
		[ContainerField(120)]
		public SquadId SquadId { get; set; } = new SquadId(); // 0x78 (120)
		
		[ContainerField(124)]
		public TeamId TeamId { get; set; } = new TeamId(); // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable]
		public string SuccessSid { get; set; } // 0x80 (128)
		
		[ContainerField(132)]
		public MessageReciever Reciever { get; set; } = new MessageReciever(); // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public bool RetriggerSuccessOnShowObjective { get; set; } // 0x88 (136)
		
		[ContainerField(137), LayoutImmutable, Blittable]
		public bool Tutorial { get; set; } // 0x89 (137)
		
		[ContainerField(138), LayoutImmutable, Blittable]
		public bool DisplaySuccess { get; set; } // 0x8A (138)
		
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
