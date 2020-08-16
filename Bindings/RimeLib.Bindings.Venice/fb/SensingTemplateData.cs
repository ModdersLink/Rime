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
	[ContainerType(8)]
	public class SensingTemplateData : 
		GameSensingTemplateData
	{
		protected double m_AwareForgetTime = new double();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(158765341)]
		public double AwareForgetTime { get { return m_AwareForgetTime; } set { if (OnPropertyChanging("SensingTemplateData." + nameof(AwareForgetTime), this, m_AwareForgetTime, value)) m_AwareForgetTime = value; } } // 0x10 (16)
		
		protected double m_LostForgetTime = new double();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(3823563097)]
		public double LostForgetTime { get { return m_LostForgetTime; } set { if (OnPropertyChanging("SensingTemplateData." + nameof(LostForgetTime), this, m_LostForgetTime, value)) m_LostForgetTime = value; } } // 0x18 (24)
		
		protected double m_TimeUntilUnseenIsLost = new double();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(3517626530)]
		public double TimeUntilUnseenIsLost { get { return m_TimeUntilUnseenIsLost; } set { if (OnPropertyChanging("SensingTemplateData." + nameof(TimeUntilUnseenIsLost), this, m_TimeUntilUnseenIsLost, value)) m_TimeUntilUnseenIsLost = value; } } // 0x20 (32)
		
		protected float m_MaximumMergeDistance = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(3512455094)]
		public float MaximumMergeDistance { get { return m_MaximumMergeDistance; } set { if (OnPropertyChanging("SensingTemplateData." + nameof(MaximumMergeDistance), this, m_MaximumMergeDistance, value)) m_MaximumMergeDistance = value; } } // 0x28 (40)
		
		protected float m_MaximumAlertDistance = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(3472158112)]
		public float MaximumAlertDistance { get { return m_MaximumAlertDistance; } set { if (OnPropertyChanging("SensingTemplateData." + nameof(MaximumAlertDistance), this, m_MaximumAlertDistance, value)) m_MaximumAlertDistance = value; } } // 0x2C (44)
		
		protected float m_MaximumReadinessRaiseDistance = new float();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(1016666322)]
		public float MaximumReadinessRaiseDistance { get { return m_MaximumReadinessRaiseDistance; } set { if (OnPropertyChanging("SensingTemplateData." + nameof(MaximumReadinessRaiseDistance), this, m_MaximumReadinessRaiseDistance, value)) m_MaximumReadinessRaiseDistance = value; } } // 0x30 (48)
		
		protected SensingLimits m_ReadyLimits = new SensingLimits();
		[ContainerField(52), ContainerFieldNameHash(2791692488)]
		public SensingLimits ReadyLimits { get { return m_ReadyLimits; } set { if (OnPropertyChanging("SensingTemplateData." + nameof(ReadyLimits), this, m_ReadyLimits, value)) m_ReadyLimits = value; } } // 0x34 (52)
		
		protected SensingLimits m_RelaxedLimits = new SensingLimits();
		[ContainerField(80), ContainerFieldNameHash(3953057472)]
		public SensingLimits RelaxedLimits { get { return m_RelaxedLimits; } set { if (OnPropertyChanging("SensingTemplateData." + nameof(RelaxedLimits), this, m_RelaxedLimits, value)) m_RelaxedLimits = value; } } // 0x50 (80)
		
		protected string m_DebugText = string.Empty;
		[ContainerField(108), LayoutImmutable, ContainerFieldNameHash(859165769)]
		public string DebugText { get { return m_DebugText; } set { if (OnPropertyChanging("SensingTemplateData." + nameof(DebugText), this, m_DebugText, value)) m_DebugText = value; } } // 0x6C (108)
		
		protected SensingLimits m_CombatLimits = new SensingLimits();
		[ContainerField(112), ContainerFieldNameHash(1598004373)]
		public SensingLimits CombatLimits { get { return m_CombatLimits; } set { if (OnPropertyChanging("SensingTemplateData." + nameof(CombatLimits), this, m_CombatLimits, value)) m_CombatLimits = value; } } // 0x70 (112)
		
		protected bool m_UseSenseSharing = new bool();
		[ContainerField(140), LayoutImmutable, Blittable, ContainerFieldNameHash(3340744448)]
		public bool UseSenseSharing { get { return m_UseSenseSharing; } set { if (OnPropertyChanging("SensingTemplateData." + nameof(UseSenseSharing), this, m_UseSenseSharing, value)) m_UseSenseSharing = value; } } // 0x8C (140)
		
		protected bool m_NoticeBullets = new bool();
		[ContainerField(141), LayoutImmutable, Blittable, ContainerFieldNameHash(3526314442)]
		public bool NoticeBullets { get { return m_NoticeBullets; } set { if (OnPropertyChanging("SensingTemplateData." + nameof(NoticeBullets), this, m_NoticeBullets, value)) m_NoticeBullets = value; } } // 0x8D (141)
		
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
