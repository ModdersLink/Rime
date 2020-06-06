///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class AILocoCoverTaskData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WantedPos { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ThreatPosition { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32)]
		public AntPoseEnum CoverPose { get; set; } = new AntPoseEnum(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float WaitTime { get; set; } // 0x24 (36)
		
		[ContainerField(40)]
		public CoverPeekType PeekOut { get; set; } = new CoverPeekType(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float WorldAngle { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float OffsetLength { get; set; } // 0x30 (48)
		
		[ContainerField(52)]
		public AntPoseEnum ExitPose { get; set; } = new AntPoseEnum(); // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float ExitAngle { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float DistanceToNextWaypoint { get; set; } // 0x3C (60)
		
		[ContainerField(64)]
		public AntCoverEnum CoverType { get; set; } = new AntCoverEnum(); // 0x40 (64)
		
		[ContainerField(68)]
		public CoverEnterStrategy EnterStrategy { get; set; } = new CoverEnterStrategy(); // 0x44 (68)
		
		[ContainerField(72)]
		public CoverExitStyle ExitStyle { get; set; } = new CoverExitStyle(); // 0x48 (72)
		
		[ContainerField(76)]
		public CoverFireType PrepareFireType { get; set; } = new CoverFireType(); // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public bool ForceExitCover { get; set; } // 0x50 (80)
		
		[ContainerField(81), LayoutImmutable, Blittable]
		public bool UseClientPosition { get; set; } // 0x51 (81)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 82144004:
					WantedPos = (Vec3) p_Value;
					break;

				case 4029413858:
					ThreatPosition = (Vec3) p_Value;
					break;

				case 2741512545:
						CoverPose = (AntPoseEnum) Enum.ToObject(typeof(AntPoseEnum), p_Value);
					break;

				case 3637870203:
					WaitTime = (float) p_Value;
					break;

				case 3756039152:
						PeekOut = (CoverPeekType) Enum.ToObject(typeof(CoverPeekType), p_Value);
					break;

				case 612547046:
					WorldAngle = (float) p_Value;
					break;

				case 184511572:
					OffsetLength = (float) p_Value;
					break;

				case 506708652:
						ExitPose = (AntPoseEnum) Enum.ToObject(typeof(AntPoseEnum), p_Value);
					break;

				case 3818612484:
					ExitAngle = (float) p_Value;
					break;

				case 3374983833:
					DistanceToNextWaypoint = (float) p_Value;
					break;

				case 2741637520:
						CoverType = (AntCoverEnum) Enum.ToObject(typeof(AntCoverEnum), p_Value);
					break;

				case 2784850742:
						EnterStrategy = (CoverEnterStrategy) Enum.ToObject(typeof(CoverEnterStrategy), p_Value);
					break;

				case 3843788370:
						ExitStyle = (CoverExitStyle) Enum.ToObject(typeof(CoverExitStyle), p_Value);
					break;

				case 660661988:
						PrepareFireType = (CoverFireType) Enum.ToObject(typeof(CoverFireType), p_Value);
					break;

				case 397580885:
					ForceExitCover = (bool) p_Value;
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

				case 4029413858:
					return ThreatPosition;

				case 2741512545:
					return CoverPose;

				case 3637870203:
					return WaitTime;

				case 3756039152:
					return PeekOut;

				case 612547046:
					return WorldAngle;

				case 184511572:
					return OffsetLength;

				case 506708652:
					return ExitPose;

				case 3818612484:
					return ExitAngle;

				case 3374983833:
					return DistanceToNextWaypoint;

				case 2741637520:
					return CoverType;

				case 2784850742:
					return EnterStrategy;

				case 3843788370:
					return ExitStyle;

				case 660661988:
					return PrepareFireType;

				case 397580885:
					return ForceExitCover;

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
					return typeof(AILocoCoverTaskData).GetProperty(nameof(WantedPos));

				case 4029413858:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(ThreatPosition));

				case 2741512545:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(CoverPose));

				case 3637870203:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(WaitTime));

				case 3756039152:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(PeekOut));

				case 612547046:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(WorldAngle));

				case 184511572:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(OffsetLength));

				case 506708652:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(ExitPose));

				case 3818612484:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(ExitAngle));

				case 3374983833:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(DistanceToNextWaypoint));

				case 2741637520:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(CoverType));

				case 2784850742:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(EnterStrategy));

				case 3843788370:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(ExitStyle));

				case 660661988:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(PrepareFireType));

				case 397580885:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(ForceExitCover));

				case 430257222:
					return typeof(AILocoCoverTaskData).GetProperty(nameof(UseClientPosition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
