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
	public class CannedAnimationBinding : FrostbiteContainer
	{
		[ContainerField(0)]
		public AntRef LevelIndex { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4)]
		public AntRef ScenarioIndex { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8)]
		public AntRef ActorIndex { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12)]
		public AntRef PartIndex { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16)]
		public AntRef TriggerCannedAnimation { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(20)]
		public AntRef ExitCannedAnimation { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24)]
		public AntRef ExternalTime { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(28)]
		public AntRef BlendValue { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(32)]
		public AntRef AdvanceScenario { get; set; } = new AntRef(); // 0x20 (32)
		
		[ContainerField(36)]
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
