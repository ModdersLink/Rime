///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 96)]
	public class AILocoCoverTaskData :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 WantedPos { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 ThreatPosition { get; set; } = new();
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public AntPoseEnum CoverPose { get; set; } = new();
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float WaitTime { get; set; }
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public CoverPeekType PeekOut { get; set; } = new();
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float WorldAngle { get; set; }
		
		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float OffsetLength { get; set; }
		
		[ContainerField(52), JsonProperty(Order = 52)]
		public AntPoseEnum ExitPose { get; set; } = new();
		
		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float ExitAngle { get; set; }
		
		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float DistanceToNextWaypoint { get; set; }
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public AntCoverEnum CoverType { get; set; } = new();
		
		[ContainerField(68), JsonProperty(Order = 68)]
		public CoverEnterStrategy EnterStrategy { get; set; } = new();
		
		[ContainerField(72), JsonProperty(Order = 72)]
		public CoverExitStyle ExitStyle { get; set; } = new();
		
		[ContainerField(76), JsonProperty(Order = 76)]
		public CoverFireType PrepareFireType { get; set; } = new();
		
		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public bool ForceExitCover { get; set; }
		
		[ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		public bool UseClientPosition { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			WantedPos.Serialize(p_Writer, p_EbxWriter);
			ThreatPosition.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) CoverPose);
			p_Writer.Write(WaitTime);
			p_Writer.Write((int) PeekOut);
			p_Writer.Write(WorldAngle);
			p_Writer.Write(OffsetLength);
			p_Writer.Write((int) ExitPose);
			p_Writer.Write(ExitAngle);
			p_Writer.Write(DistanceToNextWaypoint);
			p_Writer.Write((int) CoverType);
			p_Writer.Write((int) EnterStrategy);
			p_Writer.Write((int) ExitStyle);
			p_Writer.Write((int) PrepareFireType);
			p_Writer.Write(ForceExitCover);
			p_Writer.Write(UseClientPosition);
			p_Writer.WriteNullBytes(14);
		}
	}
}
