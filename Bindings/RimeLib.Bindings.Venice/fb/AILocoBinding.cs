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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 36)]
	public class AILocoBinding : FrostbiteContainer
	{
		[ContainerField(Name: "LocoTarget", Offset: 0, NameHash: 1880034011, Flags: 41)]
		public AntRef LocoTarget { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "AttentionState", Offset: 4, NameHash: 4224473092, Flags: 41)]
		public AntRef AttentionState { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(Name: "EndPoseEnum", Offset: 8, NameHash: 2112616464, Flags: 41)]
		public AntRef EndPoseEnum { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(Name: "CurrentPoseEnum", Offset: 12, NameHash: 2074109494, Flags: 41)]
		public AntRef CurrentPoseEnum { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(Name: "EnterExitPoseEnum", Offset: 16, NameHash: 3252204311, Flags: 41)]
		public AntRef EnterExitPoseEnum { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(Name: "RunStyle", Offset: 20, NameHash: 1984199259, Flags: 41)]
		public AntRef RunStyle { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(Name: "TargetWaypointPosition", Offset: 24, NameHash: 3424917486, Flags: 41)]
		public AntRef TargetWaypointPosition { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(Name: "TargetSpeedLevel", Offset: 28, NameHash: 1705448581, Flags: 41)]
		public AntRef TargetSpeedLevel { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(Name: "EnableProceduralHeadAim", Offset: 32, NameHash: 2283438924, Flags: 41)]
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
