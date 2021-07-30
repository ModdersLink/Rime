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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 24)]
	public class SubsystemTimingConfigData : FrostbiteContainer
	{
		[ContainerField(Name: "Sensing", Offset: 0, NameHash: 2773286638, Flags: 49469), LayoutImmutable, Blittable]
		public float Sensing { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Evaluation", Offset: 4, NameHash: 2114752051, Flags: 49469), LayoutImmutable, Blittable]
		public float Evaluation { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "GoalUpdates", Offset: 8, NameHash: 1646124194, Flags: 49469), LayoutImmutable, Blittable]
		public float GoalUpdates { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "IntentUpdates", Offset: 12, NameHash: 3880187307, Flags: 49469), LayoutImmutable, Blittable]
		public float IntentUpdates { get; set; } // 0xC (12)
		
		[ContainerField(Name: "BehaviourSelection", Offset: 16, NameHash: 2270407900, Flags: 49469), LayoutImmutable, Blittable]
		public float BehaviourSelection { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "BehaviourExecution", Offset: 20, NameHash: 4008376558, Flags: 49469), LayoutImmutable, Blittable]
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
