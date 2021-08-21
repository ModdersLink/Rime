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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 32)]
	public class AILocoBaseTaskData : FrostbiteContainer
	{
		[ContainerField(Name: "PoseChangeMovingTowards", Offset: 0, NameHash: 1377364758, Flags: 137)]
		public AntPoseEnum PoseChangeMovingTowards { get; set; } = new AntPoseEnum(); // 0x0 (0)
		
		[ContainerField(Name: "AttentionChangeMovingTowards", Offset: 4, NameHash: 1439359817, Flags: 137)]
		public AntAttentionStateEnum AttentionChangeMovingTowards { get; set; } = new AntAttentionStateEnum(); // 0x4 (4)
		
		[ContainerField(Name: "SpeedChangeMovingTowards", Offset: 8, NameHash: 1457701336, Flags: 137)]
		public AntSpeedLevel SpeedChangeMovingTowards { get; set; } = new AntSpeedLevel(); // 0x8 (8)
		
		[ContainerField(Name: "PoseChange", Offset: 12, NameHash: 3977623818, Flags: 137)]
		public AntPoseEnum PoseChange { get; set; } = new AntPoseEnum(); // 0xC (12)
		
		[ContainerField(Name: "AttentionStateChange", Offset: 16, NameHash: 2093421058, Flags: 137)]
		public AntAttentionStateEnum AttentionStateChange { get; set; } = new AntAttentionStateEnum(); // 0x10 (16)
		
		[ContainerField(Name: "SpeedLevelChange", Offset: 20, NameHash: 4237171346, Flags: 137)]
		public AntSpeedLevel SpeedLevelChange { get; set; } = new AntSpeedLevel(); // 0x14 (20)
		
		[ContainerField(Name: "Radius", Offset: 24, NameHash: 3298407133, Flags: 49469), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0x18 (24)
		
		[ContainerField(Name: "IsScripted", Offset: 28, NameHash: 2618831345, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsScripted { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1377364758:
						PoseChangeMovingTowards = (AntPoseEnum) Enum.ToObject(typeof(AntPoseEnum), p_Value);
					break;

				case 1439359817:
						AttentionChangeMovingTowards = (AntAttentionStateEnum) Enum.ToObject(typeof(AntAttentionStateEnum), p_Value);
					break;

				case 1457701336:
						SpeedChangeMovingTowards = (AntSpeedLevel) Enum.ToObject(typeof(AntSpeedLevel), p_Value);
					break;

				case 3977623818:
						PoseChange = (AntPoseEnum) Enum.ToObject(typeof(AntPoseEnum), p_Value);
					break;

				case 2093421058:
						AttentionStateChange = (AntAttentionStateEnum) Enum.ToObject(typeof(AntAttentionStateEnum), p_Value);
					break;

				case 4237171346:
						SpeedLevelChange = (AntSpeedLevel) Enum.ToObject(typeof(AntSpeedLevel), p_Value);
					break;

				case 3298407133:
					Radius = (float) p_Value;
					break;

				case 2618831345:
					IsScripted = (bool) p_Value;
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
				case 1377364758:
					return PoseChangeMovingTowards;

				case 1439359817:
					return AttentionChangeMovingTowards;

				case 1457701336:
					return SpeedChangeMovingTowards;

				case 3977623818:
					return PoseChange;

				case 2093421058:
					return AttentionStateChange;

				case 4237171346:
					return SpeedLevelChange;

				case 3298407133:
					return Radius;

				case 2618831345:
					return IsScripted;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1377364758:
					return typeof(AILocoBaseTaskData).GetProperty(nameof(PoseChangeMovingTowards));

				case 1439359817:
					return typeof(AILocoBaseTaskData).GetProperty(nameof(AttentionChangeMovingTowards));

				case 1457701336:
					return typeof(AILocoBaseTaskData).GetProperty(nameof(SpeedChangeMovingTowards));

				case 3977623818:
					return typeof(AILocoBaseTaskData).GetProperty(nameof(PoseChange));

				case 2093421058:
					return typeof(AILocoBaseTaskData).GetProperty(nameof(AttentionStateChange));

				case 4237171346:
					return typeof(AILocoBaseTaskData).GetProperty(nameof(SpeedLevelChange));

				case 3298407133:
					return typeof(AILocoBaseTaskData).GetProperty(nameof(Radius));

				case 2618831345:
					return typeof(AILocoBaseTaskData).GetProperty(nameof(IsScripted));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
