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
	public class DecisionConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float NewEnemyDecideMaxDistance { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool AllowEmergencyGoalInterrupt { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool AllowUninterruptibleBehaviours { get; set; } // 0x11 (17)
		
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
