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
	public class AILocoBinding : FrostbiteContainer
	{
		[ContainerField(0)]
		public AntRef LocoTarget { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4)]
		public AntRef AttentionState { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8)]
		public AntRef EndPoseEnum { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12)]
		public AntRef CurrentPoseEnum { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16)]
		public AntRef EnterExitPoseEnum { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(20)]
		public AntRef RunStyle { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24)]
		public AntRef TargetWaypointPosition { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(28)]
		public AntRef TargetSpeedLevel { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(32)]
		public AntRef EnableProceduralHeadAim { get; set; } = new AntRef(); // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1880034011:
					LocoTarget = (AntRef) p_Value;
					break;

				case 4224473092:
					AttentionState = (AntRef) p_Value;
					break;

				case 2112616464:
					EndPoseEnum = (AntRef) p_Value;
					break;

				case 2074109494:
					CurrentPoseEnum = (AntRef) p_Value;
					break;

				case 3252204311:
					EnterExitPoseEnum = (AntRef) p_Value;
					break;

				case 1984199259:
					RunStyle = (AntRef) p_Value;
					break;

				case 3424917486:
					TargetWaypointPosition = (AntRef) p_Value;
					break;

				case 1705448581:
					TargetSpeedLevel = (AntRef) p_Value;
					break;

				case 2283438924:
					EnableProceduralHeadAim = (AntRef) p_Value;
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
				case 1880034011:
					return LocoTarget;

				case 4224473092:
					return AttentionState;

				case 2112616464:
					return EndPoseEnum;

				case 2074109494:
					return CurrentPoseEnum;

				case 3252204311:
					return EnterExitPoseEnum;

				case 1984199259:
					return RunStyle;

				case 3424917486:
					return TargetWaypointPosition;

				case 1705448581:
					return TargetSpeedLevel;

				case 2283438924:
					return EnableProceduralHeadAim;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1880034011:
					return typeof(AILocoBinding).GetProperty(nameof(LocoTarget));

				case 4224473092:
					return typeof(AILocoBinding).GetProperty(nameof(AttentionState));

				case 2112616464:
					return typeof(AILocoBinding).GetProperty(nameof(EndPoseEnum));

				case 2074109494:
					return typeof(AILocoBinding).GetProperty(nameof(CurrentPoseEnum));

				case 3252204311:
					return typeof(AILocoBinding).GetProperty(nameof(EnterExitPoseEnum));

				case 1984199259:
					return typeof(AILocoBinding).GetProperty(nameof(RunStyle));

				case 3424917486:
					return typeof(AILocoBinding).GetProperty(nameof(TargetWaypointPosition));

				case 1705448581:
					return typeof(AILocoBinding).GetProperty(nameof(TargetSpeedLevel));

				case 2283438924:
					return typeof(AILocoBinding).GetProperty(nameof(EnableProceduralHeadAim));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
