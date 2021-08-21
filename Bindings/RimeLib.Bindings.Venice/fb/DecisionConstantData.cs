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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class DecisionConstantData : 
		Asset
	{
		protected float m_NewEnemyDecideMaxDistance = new float();
		[ContainerField(Name: "NewEnemyDecideMaxDistance", Offset: 12, NameHash: 816843358, Flags: 49469), LayoutImmutable, Blittable]
		public float NewEnemyDecideMaxDistance { get { return m_NewEnemyDecideMaxDistance; } set { if (OnPropertyChanging("DecisionConstantData." + nameof(NewEnemyDecideMaxDistance), this, m_NewEnemyDecideMaxDistance, value)) m_NewEnemyDecideMaxDistance = value; } } // 0xC (12)
		
		protected bool m_AllowEmergencyGoalInterrupt = new bool();
		[ContainerField(Name: "AllowEmergencyGoalInterrupt", Offset: 16, NameHash: 3191314423, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowEmergencyGoalInterrupt { get { return m_AllowEmergencyGoalInterrupt; } set { if (OnPropertyChanging("DecisionConstantData." + nameof(AllowEmergencyGoalInterrupt), this, m_AllowEmergencyGoalInterrupt, value)) m_AllowEmergencyGoalInterrupt = value; } } // 0x10 (16)
		
		protected bool m_AllowUninterruptibleBehaviours = new bool();
		[ContainerField(Name: "AllowUninterruptibleBehaviours", Offset: 17, NameHash: 2964152968, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowUninterruptibleBehaviours { get { return m_AllowUninterruptibleBehaviours; } set { if (OnPropertyChanging("DecisionConstantData." + nameof(AllowUninterruptibleBehaviours), this, m_AllowUninterruptibleBehaviours, value)) m_AllowUninterruptibleBehaviours = value; } } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 816843358:
					NewEnemyDecideMaxDistance = (float) p_Value;
					break;

				case 3191314423:
					AllowEmergencyGoalInterrupt = (bool) p_Value;
					break;

				case 2964152968:
					AllowUninterruptibleBehaviours = (bool) p_Value;
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
				case 816843358:
					return NewEnemyDecideMaxDistance;

				case 3191314423:
					return AllowEmergencyGoalInterrupt;

				case 2964152968:
					return AllowUninterruptibleBehaviours;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 816843358:
					return typeof(DecisionConstantData).GetProperty(nameof(NewEnemyDecideMaxDistance));

				case 3191314423:
					return typeof(DecisionConstantData).GetProperty(nameof(AllowEmergencyGoalInterrupt));

				case 2964152968:
					return typeof(DecisionConstantData).GetProperty(nameof(AllowUninterruptibleBehaviours));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
