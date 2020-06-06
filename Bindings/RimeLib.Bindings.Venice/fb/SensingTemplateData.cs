///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(8)]
	public class SensingTemplateData : 
		GameSensingTemplateData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public double AwareForgetTime { get; set; } // 0x10 (16)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public double LostForgetTime { get; set; } // 0x18 (24)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public double TimeUntilUnseenIsLost { get; set; } // 0x20 (32)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaximumMergeDistance { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float MaximumAlertDistance { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float MaximumReadinessRaiseDistance { get; set; } // 0x30 (48)
		
		[ContainerField(52)]
		public SensingLimits ReadyLimits { get; set; } = new SensingLimits(); // 0x34 (52)
		
		[ContainerField(80)]
		public SensingLimits RelaxedLimits { get; set; } = new SensingLimits(); // 0x50 (80)
		
		[ContainerField(108), LayoutImmutable]
		public string DebugText { get; set; } // 0x6C (108)
		
		[ContainerField(112)]
		public SensingLimits CombatLimits { get; set; } = new SensingLimits(); // 0x70 (112)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public bool UseSenseSharing { get; set; } // 0x8C (140)
		
		[ContainerField(141), LayoutImmutable, Blittable]
		public bool NoticeBullets { get; set; } // 0x8D (141)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 158765341:
					AwareForgetTime = (double) p_Value;
					break;

				case 3823563097:
					LostForgetTime = (double) p_Value;
					break;

				case 3517626530:
					TimeUntilUnseenIsLost = (double) p_Value;
					break;

				case 3512455094:
					MaximumMergeDistance = (float) p_Value;
					break;

				case 3472158112:
					MaximumAlertDistance = (float) p_Value;
					break;

				case 1016666322:
					MaximumReadinessRaiseDistance = (float) p_Value;
					break;

				case 2791692488:
					ReadyLimits = (SensingLimits) p_Value;
					break;

				case 3953057472:
					RelaxedLimits = (SensingLimits) p_Value;
					break;

				case 859165769:
					DebugText = (string) p_Value;
					break;

				case 1598004373:
					CombatLimits = (SensingLimits) p_Value;
					break;

				case 3340744448:
					UseSenseSharing = (bool) p_Value;
					break;

				case 3526314442:
					NoticeBullets = (bool) p_Value;
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
				case 158765341:
					return AwareForgetTime;

				case 3823563097:
					return LostForgetTime;

				case 3517626530:
					return TimeUntilUnseenIsLost;

				case 3512455094:
					return MaximumMergeDistance;

				case 3472158112:
					return MaximumAlertDistance;

				case 1016666322:
					return MaximumReadinessRaiseDistance;

				case 2791692488:
					return ReadyLimits;

				case 3953057472:
					return RelaxedLimits;

				case 859165769:
					return DebugText;

				case 1598004373:
					return CombatLimits;

				case 3340744448:
					return UseSenseSharing;

				case 3526314442:
					return NoticeBullets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 158765341:
					return typeof(SensingTemplateData).GetProperty(nameof(AwareForgetTime));

				case 3823563097:
					return typeof(SensingTemplateData).GetProperty(nameof(LostForgetTime));

				case 3517626530:
					return typeof(SensingTemplateData).GetProperty(nameof(TimeUntilUnseenIsLost));

				case 3512455094:
					return typeof(SensingTemplateData).GetProperty(nameof(MaximumMergeDistance));

				case 3472158112:
					return typeof(SensingTemplateData).GetProperty(nameof(MaximumAlertDistance));

				case 1016666322:
					return typeof(SensingTemplateData).GetProperty(nameof(MaximumReadinessRaiseDistance));

				case 2791692488:
					return typeof(SensingTemplateData).GetProperty(nameof(ReadyLimits));

				case 3953057472:
					return typeof(SensingTemplateData).GetProperty(nameof(RelaxedLimits));

				case 859165769:
					return typeof(SensingTemplateData).GetProperty(nameof(DebugText));

				case 1598004373:
					return typeof(SensingTemplateData).GetProperty(nameof(CombatLimits));

				case 3340744448:
					return typeof(SensingTemplateData).GetProperty(nameof(UseSenseSharing));

				case 3526314442:
					return typeof(SensingTemplateData).GetProperty(nameof(NoticeBullets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
