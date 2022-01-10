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
	[ContainerType(16, 48)]
	public class AILocoMoveTaskData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WantedPos { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float WorldAngle { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float WaitTime { get; set; }
		
		[ContainerField(24)]
		public AntPoseEnum EnterPose { get; set; } = new();
		
		[ContainerField(28)]
		public AntPoseEnum ExitPose { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool OverrideAngle { get; set; }
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool UseClientPosition { get; set; }
		
		public static void Deserialize(AILocoMoveTaskData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.WantedPos, p_Reader, p_Parser);
			p_Instance.WorldAngle = p_Reader.ReadSingle();
			p_Instance.WaitTime = p_Reader.ReadSingle();
			p_Instance.EnterPose = (AntPoseEnum) p_Reader.ReadInt32();
			p_Instance.ExitPose = (AntPoseEnum) p_Reader.ReadInt32();
			p_Instance.OverrideAngle = p_Reader.ReadBool();
			p_Instance.UseClientPosition = p_Reader.ReadBool();
			p_Reader.Seek(14, SeekOrigin.Current);
		}
	}
}
