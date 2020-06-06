///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class FollowConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float DistanceFromPlayerBeforeTeleport { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float FollowHumanMaxDistance { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float FollowHumanInCombatMaxDistance { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float FollowAiMaxDistance { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float FollowAiInCombatMaxDistance { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float FollowMimicPoseDistance { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float FollowInertia { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float LookAwayAngle { get; set; } // 0x28 (40)
		
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
