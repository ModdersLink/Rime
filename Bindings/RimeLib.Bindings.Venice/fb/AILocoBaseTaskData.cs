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
	[ContainerType(4, 32)]
	public class AILocoBaseTaskData
	{
		[ContainerField(0)]
		public AntPoseEnum PoseChangeMovingTowards { get; set; } = new();
		
		[ContainerField(4)]
		public AntAttentionStateEnum AttentionChangeMovingTowards { get; set; } = new();
		
		[ContainerField(8)]
		public AntSpeedLevel SpeedChangeMovingTowards { get; set; } = new();
		
		[ContainerField(12)]
		public AntPoseEnum PoseChange { get; set; } = new();
		
		[ContainerField(16)]
		public AntAttentionStateEnum AttentionStateChange { get; set; } = new();
		
		[ContainerField(20)]
		public AntSpeedLevel SpeedLevelChange { get; set; } = new();
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Radius { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool IsScripted { get; set; }
		
		public static void Deserialize(AILocoBaseTaskData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PoseChangeMovingTowards = (AntPoseEnum) p_Reader.ReadInt32();
			p_Instance.AttentionChangeMovingTowards = (AntAttentionStateEnum) p_Reader.ReadInt32();
			p_Instance.SpeedChangeMovingTowards = (AntSpeedLevel) p_Reader.ReadInt32();
			p_Instance.PoseChange = (AntPoseEnum) p_Reader.ReadInt32();
			p_Instance.AttentionStateChange = (AntAttentionStateEnum) p_Reader.ReadInt32();
			p_Instance.SpeedLevelChange = (AntSpeedLevel) p_Reader.ReadInt32();
			p_Instance.Radius = p_Reader.ReadSingle();
			p_Instance.IsScripted = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
