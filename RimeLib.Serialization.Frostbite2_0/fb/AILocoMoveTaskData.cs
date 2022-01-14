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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 48)]
	public class AILocoMoveTaskData :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 WantedPos { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float WorldAngle { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float WaitTime { get; set; }
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public AntPoseEnum EnterPose { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public AntPoseEnum ExitPose { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool OverrideAngle { get; set; }
		
		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool UseClientPosition { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			WantedPos.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(WorldAngle);
			p_Writer.Write(WaitTime);
			p_Writer.Write((int) EnterPose);
			p_Writer.Write((int) ExitPose);
			p_Writer.Write(OverrideAngle);
			p_Writer.Write(UseClientPosition);
			p_Writer.WriteNullBytes(14);
		}
	}
}
