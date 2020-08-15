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
	[ContainerType(16)]
	public class AILocoMoveTaskData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WantedPos { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float WorldAngle { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float WaitTime { get; set; } // 0x14 (20)
		
		[ContainerField(24)]
		public AntPoseEnum EnterPose { get; set; } = new AntPoseEnum(); // 0x18 (24)
		
		[ContainerField(28)]
		public AntPoseEnum ExitPose { get; set; } = new AntPoseEnum(); // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool OverrideAngle { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool UseClientPosition { get; set; } // 0x21 (33)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 82144004:
					WantedPos = (Vec3) p_Value;
					break;

				case 612547046:
					WorldAngle = (float) p_Value;
					break;

				case 3637870203:
					WaitTime = (float) p_Value;
					break;

				case 1040225668:
						EnterPose = (AntPoseEnum) Enum.ToObject(typeof(AntPoseEnum), p_Value);
					break;

				case 506708652:
						ExitPose = (AntPoseEnum) Enum.ToObject(typeof(AntPoseEnum), p_Value);
					break;

				case 4140865680:
					OverrideAngle = (bool) p_Value;
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
				case 82144004:
					return WantedPos;

				case 612547046:
					return WorldAngle;

				case 3637870203:
					return WaitTime;

				case 1040225668:
					return EnterPose;

				case 506708652:
					return ExitPose;

				case 4140865680:
					return OverrideAngle;

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
				case 82144004:
					return typeof(AILocoMoveTaskData).GetProperty(nameof(WantedPos));

				case 612547046:
					return typeof(AILocoMoveTaskData).GetProperty(nameof(WorldAngle));

				case 3637870203:
					return typeof(AILocoMoveTaskData).GetProperty(nameof(WaitTime));

				case 1040225668:
					return typeof(AILocoMoveTaskData).GetProperty(nameof(EnterPose));

				case 506708652:
					return typeof(AILocoMoveTaskData).GetProperty(nameof(ExitPose));

				case 4140865680:
					return typeof(AILocoMoveTaskData).GetProperty(nameof(OverrideAngle));

				case 430257222:
					return typeof(AILocoMoveTaskData).GetProperty(nameof(UseClientPosition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
