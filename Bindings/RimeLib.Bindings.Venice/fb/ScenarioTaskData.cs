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
	[ContainerType(16), MemberInfoFlag(41), ContainerStruct]
	public class ScenarioTaskData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec3 EndPointWorldOffset { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec3 StartPoint { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int ScenarioId { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int ActorId { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int PartId { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int LevelId { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float WorldAngle { get; set; } // 0x30 (48)
		
		[ContainerField(52), MemberInfoFlag(65), ContainerArray]
		public List<LinearTransform> ConnectTransforms { get; set; } = new List<LinearTransform>(); // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float StartTurnDistance { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float StartTimerDistance { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float TriggerScenarioDelay { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool TriggerScenario { get; set; } // 0x44 (68)
		
		[ContainerField(69), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool UseClientPosition { get; set; } // 0x45 (69)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 826674953:
					EndPointWorldOffset = (Vec3) p_Value;
					break;

				case 2755831849:
					StartPoint = (Vec3) p_Value;
					break;

				case 3278128294:
					ScenarioId = (int) p_Value;
					break;

				case 373715747:
					ActorId = (int) p_Value;
					break;

				case 3371573631:
					PartId = (int) p_Value;
					break;

				case 1464675646:
					LevelId = (int) p_Value;
					break;

				case 612547046:
					WorldAngle = (float) p_Value;
					break;

				case 763624964:
					ConnectTransforms = (List<LinearTransform>) p_Value;
					break;

				case 432617307:
					StartTurnDistance = (float) p_Value;
					break;

				case 1775830017:
					StartTimerDistance = (float) p_Value;
					break;

				case 2455523686:
					TriggerScenarioDelay = (float) p_Value;
					break;

				case 3734607443:
					TriggerScenario = (bool) p_Value;
					break;

				case 430257222:
					UseClientPosition = (bool) p_Value;
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
				case 826674953:
					return EndPointWorldOffset;

				case 2755831849:
					return StartPoint;

				case 3278128294:
					return ScenarioId;

				case 373715747:
					return ActorId;

				case 3371573631:
					return PartId;

				case 1464675646:
					return LevelId;

				case 612547046:
					return WorldAngle;

				case 763624964:
					return ConnectTransforms;

				case 432617307:
					return StartTurnDistance;

				case 1775830017:
					return StartTimerDistance;

				case 2455523686:
					return TriggerScenarioDelay;

				case 3734607443:
					return TriggerScenario;

				case 430257222:
					return UseClientPosition;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 826674953:
					return typeof(ScenarioTaskData).GetProperty(nameof(EndPointWorldOffset));

				case 2755831849:
					return typeof(ScenarioTaskData).GetProperty(nameof(StartPoint));

				case 3278128294:
					return typeof(ScenarioTaskData).GetProperty(nameof(ScenarioId));

				case 373715747:
					return typeof(ScenarioTaskData).GetProperty(nameof(ActorId));

				case 3371573631:
					return typeof(ScenarioTaskData).GetProperty(nameof(PartId));

				case 1464675646:
					return typeof(ScenarioTaskData).GetProperty(nameof(LevelId));

				case 612547046:
					return typeof(ScenarioTaskData).GetProperty(nameof(WorldAngle));

				case 763624964:
					return typeof(ScenarioTaskData).GetProperty(nameof(ConnectTransforms));

				case 432617307:
					return typeof(ScenarioTaskData).GetProperty(nameof(StartTurnDistance));

				case 1775830017:
					return typeof(ScenarioTaskData).GetProperty(nameof(StartTimerDistance));

				case 2455523686:
					return typeof(ScenarioTaskData).GetProperty(nameof(TriggerScenarioDelay));

				case 3734607443:
					return typeof(ScenarioTaskData).GetProperty(nameof(TriggerScenario));

				case 430257222:
					return typeof(ScenarioTaskData).GetProperty(nameof(UseClientPosition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
