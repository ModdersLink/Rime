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
	public class SubsystemTimingConfigData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Sensing { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Evaluation { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float GoalUpdates { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float IntentUpdates { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float BehaviourSelection { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float BehaviourExecution { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2773286638:
					Sensing = (float) p_Value;
					break;

				case 2114752051:
					Evaluation = (float) p_Value;
					break;

				case 1646124194:
					GoalUpdates = (float) p_Value;
					break;

				case 3880187307:
					IntentUpdates = (float) p_Value;
					break;

				case 2270407900:
					BehaviourSelection = (float) p_Value;
					break;

				case 4008376558:
					BehaviourExecution = (float) p_Value;
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
				case 2773286638:
					return Sensing;

				case 2114752051:
					return Evaluation;

				case 1646124194:
					return GoalUpdates;

				case 3880187307:
					return IntentUpdates;

				case 2270407900:
					return BehaviourSelection;

				case 4008376558:
					return BehaviourExecution;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2773286638:
					return typeof(SubsystemTimingConfigData).GetProperty(nameof(Sensing));

				case 2114752051:
					return typeof(SubsystemTimingConfigData).GetProperty(nameof(Evaluation));

				case 1646124194:
					return typeof(SubsystemTimingConfigData).GetProperty(nameof(GoalUpdates));

				case 3880187307:
					return typeof(SubsystemTimingConfigData).GetProperty(nameof(IntentUpdates));

				case 2270407900:
					return typeof(SubsystemTimingConfigData).GetProperty(nameof(BehaviourSelection));

				case 4008376558:
					return typeof(SubsystemTimingConfigData).GetProperty(nameof(BehaviourExecution));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
