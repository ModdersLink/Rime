///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 96)]
	public class AILocoCoverTaskData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WantedPos { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ThreatPosition { get; set; } = new();
		
		[ContainerField(32)]
		public AntPoseEnum CoverPose { get; set; } = new();
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float WaitTime { get; set; }
		
		[ContainerField(40)]
		public CoverPeekType PeekOut { get; set; } = new();
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float WorldAngle { get; set; }
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float OffsetLength { get; set; }
		
		[ContainerField(52)]
		public AntPoseEnum ExitPose { get; set; } = new();
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float ExitAngle { get; set; }
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float DistanceToNextWaypoint { get; set; }
		
		[ContainerField(64)]
		public AntCoverEnum CoverType { get; set; } = new();
		
		[ContainerField(68)]
		public CoverEnterStrategy EnterStrategy { get; set; } = new();
		
		[ContainerField(72)]
		public CoverExitStyle ExitStyle { get; set; } = new();
		
		[ContainerField(76)]
		public CoverFireType PrepareFireType { get; set; } = new();
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public bool ForceExitCover { get; set; }
		
		[ContainerField(81), LayoutImmutable, Blittable]
		public bool UseClientPosition { get; set; }
		
		public static void Deserialize(AILocoCoverTaskData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.WantedPos, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.ThreatPosition, p_Reader, p_Parser);
			p_Instance.CoverPose = (AntPoseEnum) p_Reader.ReadInt32();
			p_Instance.WaitTime = p_Reader.ReadSingle();
			p_Instance.PeekOut = (CoverPeekType) p_Reader.ReadInt32();
			p_Instance.WorldAngle = p_Reader.ReadSingle();
			p_Instance.OffsetLength = p_Reader.ReadSingle();
			p_Instance.ExitPose = (AntPoseEnum) p_Reader.ReadInt32();
			p_Instance.ExitAngle = p_Reader.ReadSingle();
			p_Instance.DistanceToNextWaypoint = p_Reader.ReadSingle();
			p_Instance.CoverType = (AntCoverEnum) p_Reader.ReadInt32();
			p_Instance.EnterStrategy = (CoverEnterStrategy) p_Reader.ReadInt32();
			p_Instance.ExitStyle = (CoverExitStyle) p_Reader.ReadInt32();
			p_Instance.PrepareFireType = (CoverFireType) p_Reader.ReadInt32();
			p_Instance.ForceExitCover = p_Reader.ReadBool();
			p_Instance.UseClientPosition = p_Reader.ReadBool();
			p_Reader.Seek(14, SeekOrigin.Current);
		}
	}
}
