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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 96)]
	public partial class AILocoCoverTaskData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private Vec3 _WantedPos = new();
		
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _ThreatPosition = new();
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AntPoseEnum _CoverPose = new();
		
		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _WaitTime;
		
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private CoverPeekType _PeekOut = new();
		
		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _WorldAngle;
		
		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _OffsetLength;
		
		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private AntPoseEnum _ExitPose = new();
		
		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _ExitAngle;
		
		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _DistanceToNextWaypoint;
		
		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private AntCoverEnum _CoverType = new();
		
		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private CoverEnterStrategy _EnterStrategy = new();
		
		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private CoverExitStyle _ExitStyle = new();
		
		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private CoverFireType _PrepareFireType = new();
		
		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private bool _ForceExitCover;
		
		[ObservableProperty]
		[property: ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		private bool _UseClientPosition;
		
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
