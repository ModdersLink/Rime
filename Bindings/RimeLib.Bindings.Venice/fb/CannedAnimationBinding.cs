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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 40)]
	public class CannedAnimationBinding : FrostbiteContainer
	{
		[ContainerField(Name: "LevelIndex", Offset: 0, NameHash: 1224148013, Flags: 41)]
		public AntRef LevelIndex { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "ScenarioIndex", Offset: 4, NameHash: 3733751989, Flags: 41)]
		public AntRef ScenarioIndex { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(Name: "ActorIndex", Offset: 8, NameHash: 4155216592, Flags: 41)]
		public AntRef ActorIndex { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(Name: "PartIndex", Offset: 12, NameHash: 3213901068, Flags: 41)]
		public AntRef PartIndex { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(Name: "TriggerCannedAnimation", Offset: 16, NameHash: 3299428744, Flags: 41)]
		public AntRef TriggerCannedAnimation { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(Name: "ExitCannedAnimation", Offset: 20, NameHash: 2312291536, Flags: 41)]
		public AntRef ExitCannedAnimation { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(Name: "ExternalTime", Offset: 24, NameHash: 2162678253, Flags: 41)]
		public AntRef ExternalTime { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(Name: "BlendValue", Offset: 28, NameHash: 236872047, Flags: 41)]
		public AntRef BlendValue { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(Name: "AdvanceScenario", Offset: 32, NameHash: 442020689, Flags: 41)]
		public AntRef AdvanceScenario { get; set; } = new AntRef(); // 0x20 (32)
		
		[ContainerField(Name: "EnteredLoop", Offset: 36, NameHash: 1022507888, Flags: 41)]
		public AntRef EnteredLoop { get; set; } = new AntRef(); // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1224148013:
					LevelIndex = (AntRef) p_Value;
					break;

				case 3733751989:
					ScenarioIndex = (AntRef) p_Value;
					break;

				case 4155216592:
					ActorIndex = (AntRef) p_Value;
					break;

				case 3213901068:
					PartIndex = (AntRef) p_Value;
					break;

				case 3299428744:
					TriggerCannedAnimation = (AntRef) p_Value;
					break;

				case 2312291536:
					ExitCannedAnimation = (AntRef) p_Value;
					break;

				case 2162678253:
					ExternalTime = (AntRef) p_Value;
					break;

				case 236872047:
					BlendValue = (AntRef) p_Value;
					break;

				case 442020689:
					AdvanceScenario = (AntRef) p_Value;
					break;

				case 1022507888:
					EnteredLoop = (AntRef) p_Value;
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
				case 1224148013:
					return LevelIndex;

				case 3733751989:
					return ScenarioIndex;

				case 4155216592:
					return ActorIndex;

				case 3213901068:
					return PartIndex;

				case 3299428744:
					return TriggerCannedAnimation;

				case 2312291536:
					return ExitCannedAnimation;

				case 2162678253:
					return ExternalTime;

				case 236872047:
					return BlendValue;

				case 442020689:
					return AdvanceScenario;

				case 1022507888:
					return EnteredLoop;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1224148013:
					return typeof(CannedAnimationBinding).GetProperty(nameof(LevelIndex));

				case 3733751989:
					return typeof(CannedAnimationBinding).GetProperty(nameof(ScenarioIndex));

				case 4155216592:
					return typeof(CannedAnimationBinding).GetProperty(nameof(ActorIndex));

				case 3213901068:
					return typeof(CannedAnimationBinding).GetProperty(nameof(PartIndex));

				case 3299428744:
					return typeof(CannedAnimationBinding).GetProperty(nameof(TriggerCannedAnimation));

				case 2312291536:
					return typeof(CannedAnimationBinding).GetProperty(nameof(ExitCannedAnimation));

				case 2162678253:
					return typeof(CannedAnimationBinding).GetProperty(nameof(ExternalTime));

				case 236872047:
					return typeof(CannedAnimationBinding).GetProperty(nameof(BlendValue));

				case 442020689:
					return typeof(CannedAnimationBinding).GetProperty(nameof(AdvanceScenario));

				case 1022507888:
					return typeof(CannedAnimationBinding).GetProperty(nameof(EnteredLoop));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
