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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class FollowConstantData : 
		Asset
	{
		protected float m_DistanceFromPlayerBeforeTeleport = new float();
		[ContainerField(Name: "DistanceFromPlayerBeforeTeleport", Offset: 12, NameHash: 319792891, Flags: 49469), LayoutImmutable, Blittable]
		public float DistanceFromPlayerBeforeTeleport { get { return m_DistanceFromPlayerBeforeTeleport; } set { if (OnPropertyChanging("FollowConstantData." + nameof(DistanceFromPlayerBeforeTeleport), this, m_DistanceFromPlayerBeforeTeleport, value)) m_DistanceFromPlayerBeforeTeleport = value; } } // 0xC (12)
		
		protected float m_FollowHumanMaxDistance = new float();
		[ContainerField(Name: "FollowHumanMaxDistance", Offset: 16, NameHash: 2198728348, Flags: 49469), LayoutImmutable, Blittable]
		public float FollowHumanMaxDistance { get { return m_FollowHumanMaxDistance; } set { if (OnPropertyChanging("FollowConstantData." + nameof(FollowHumanMaxDistance), this, m_FollowHumanMaxDistance, value)) m_FollowHumanMaxDistance = value; } } // 0x10 (16)
		
		protected float m_FollowHumanInCombatMaxDistance = new float();
		[ContainerField(Name: "FollowHumanInCombatMaxDistance", Offset: 20, NameHash: 2131610797, Flags: 49469), LayoutImmutable, Blittable]
		public float FollowHumanInCombatMaxDistance { get { return m_FollowHumanInCombatMaxDistance; } set { if (OnPropertyChanging("FollowConstantData." + nameof(FollowHumanInCombatMaxDistance), this, m_FollowHumanInCombatMaxDistance, value)) m_FollowHumanInCombatMaxDistance = value; } } // 0x14 (20)
		
		protected float m_FollowAiMaxDistance = new float();
		[ContainerField(Name: "FollowAiMaxDistance", Offset: 24, NameHash: 2432155691, Flags: 49469), LayoutImmutable, Blittable]
		public float FollowAiMaxDistance { get { return m_FollowAiMaxDistance; } set { if (OnPropertyChanging("FollowConstantData." + nameof(FollowAiMaxDistance), this, m_FollowAiMaxDistance, value)) m_FollowAiMaxDistance = value; } } // 0x18 (24)
		
		protected float m_FollowAiInCombatMaxDistance = new float();
		[ContainerField(Name: "FollowAiInCombatMaxDistance", Offset: 28, NameHash: 1238135322, Flags: 49469), LayoutImmutable, Blittable]
		public float FollowAiInCombatMaxDistance { get { return m_FollowAiInCombatMaxDistance; } set { if (OnPropertyChanging("FollowConstantData." + nameof(FollowAiInCombatMaxDistance), this, m_FollowAiInCombatMaxDistance, value)) m_FollowAiInCombatMaxDistance = value; } } // 0x1C (28)
		
		protected float m_FollowMimicPoseDistance = new float();
		[ContainerField(Name: "FollowMimicPoseDistance", Offset: 32, NameHash: 691002653, Flags: 49469), LayoutImmutable, Blittable]
		public float FollowMimicPoseDistance { get { return m_FollowMimicPoseDistance; } set { if (OnPropertyChanging("FollowConstantData." + nameof(FollowMimicPoseDistance), this, m_FollowMimicPoseDistance, value)) m_FollowMimicPoseDistance = value; } } // 0x20 (32)
		
		protected float m_FollowInertia = new float();
		[ContainerField(Name: "FollowInertia", Offset: 36, NameHash: 3062247288, Flags: 49469), LayoutImmutable, Blittable]
		public float FollowInertia { get { return m_FollowInertia; } set { if (OnPropertyChanging("FollowConstantData." + nameof(FollowInertia), this, m_FollowInertia, value)) m_FollowInertia = value; } } // 0x24 (36)
		
		protected float m_LookAwayAngle = new float();
		[ContainerField(Name: "LookAwayAngle", Offset: 40, NameHash: 1146552301, Flags: 49469), LayoutImmutable, Blittable]
		public float LookAwayAngle { get { return m_LookAwayAngle; } set { if (OnPropertyChanging("FollowConstantData." + nameof(LookAwayAngle), this, m_LookAwayAngle, value)) m_LookAwayAngle = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 319792891:
					DistanceFromPlayerBeforeTeleport = (float) p_Value;
					break;

				case 2198728348:
					FollowHumanMaxDistance = (float) p_Value;
					break;

				case 2131610797:
					FollowHumanInCombatMaxDistance = (float) p_Value;
					break;

				case 2432155691:
					FollowAiMaxDistance = (float) p_Value;
					break;

				case 1238135322:
					FollowAiInCombatMaxDistance = (float) p_Value;
					break;

				case 691002653:
					FollowMimicPoseDistance = (float) p_Value;
					break;

				case 3062247288:
					FollowInertia = (float) p_Value;
					break;

				case 1146552301:
					LookAwayAngle = (float) p_Value;
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
				case 319792891:
					return DistanceFromPlayerBeforeTeleport;

				case 2198728348:
					return FollowHumanMaxDistance;

				case 2131610797:
					return FollowHumanInCombatMaxDistance;

				case 2432155691:
					return FollowAiMaxDistance;

				case 1238135322:
					return FollowAiInCombatMaxDistance;

				case 691002653:
					return FollowMimicPoseDistance;

				case 3062247288:
					return FollowInertia;

				case 1146552301:
					return LookAwayAngle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 319792891:
					return typeof(FollowConstantData).GetProperty(nameof(DistanceFromPlayerBeforeTeleport));

				case 2198728348:
					return typeof(FollowConstantData).GetProperty(nameof(FollowHumanMaxDistance));

				case 2131610797:
					return typeof(FollowConstantData).GetProperty(nameof(FollowHumanInCombatMaxDistance));

				case 2432155691:
					return typeof(FollowConstantData).GetProperty(nameof(FollowAiMaxDistance));

				case 1238135322:
					return typeof(FollowConstantData).GetProperty(nameof(FollowAiInCombatMaxDistance));

				case 691002653:
					return typeof(FollowConstantData).GetProperty(nameof(FollowMimicPoseDistance));

				case 3062247288:
					return typeof(FollowConstantData).GetProperty(nameof(FollowInertia));

				case 1146552301:
					return typeof(FollowConstantData).GetProperty(nameof(LookAwayAngle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
