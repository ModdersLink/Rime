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
	[ContainerType(4, 36)]
	public class AILocoBinding
	{
		[ContainerField(0)]
		public AntRef LocoTarget { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef AttentionState { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef EndPoseEnum { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef CurrentPoseEnum { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef EnterExitPoseEnum { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef RunStyle { get; set; } = new();
		
		[ContainerField(24)]
		public AntRef TargetWaypointPosition { get; set; } = new();
		
		[ContainerField(28)]
		public AntRef TargetSpeedLevel { get; set; } = new();
		
		[ContainerField(32)]
		public AntRef EnableProceduralHeadAim { get; set; } = new();
		
		public static void Deserialize(AILocoBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.LocoTarget, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.AttentionState, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EndPoseEnum, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.CurrentPoseEnum, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EnterExitPoseEnum, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.RunStyle, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.TargetWaypointPosition, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.TargetSpeedLevel, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EnableProceduralHeadAim, p_Reader, p_Parser);
		}
	}
}
