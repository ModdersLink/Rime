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
	[ContainerType(4, 72)]
	public class AILocoCoverBinding
	{
		[ContainerField(0)]
		public AntRef PrepareFire { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef ThrowGrenade { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef PeekOut { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef IdleBehindCover { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef PeekType { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef CoverTypeEnum { get; set; } = new();
		
		[ContainerField(24)]
		public AntRef CoverFireStyle { get; set; } = new();
		
		[ContainerField(28)]
		public AntRef EnterCover { get; set; } = new();
		
		[ContainerField(32)]
		public AntRef ExitCover { get; set; } = new();
		
		[ContainerField(36)]
		public AntRef IsCloseCover { get; set; } = new();
		
		[ContainerField(40)]
		public AntRef DistanceScale { get; set; } = new();
		
		[ContainerField(44)]
		public AntRef AbsoluteDistance { get; set; } = new();
		
		[ContainerField(48)]
		public AntRef AngleToNormal { get; set; } = new();
		
		[ContainerField(52)]
		public AntRef OutAngle { get; set; } = new();
		
		[ContainerField(56)]
		public AntRef ThreatAngle { get; set; } = new();
		
		[ContainerField(60)]
		public AntRef StopExitCoverOutAround { get; set; } = new();
		
		[ContainerField(64)]
		public AntRef EnterStrategy { get; set; } = new();
		
		[ContainerField(68)]
		public AntRef ExitStyle { get; set; } = new();
		
		public static void Deserialize(AILocoCoverBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.PrepareFire, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.ThrowGrenade, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.PeekOut, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.IdleBehindCover, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.PeekType, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.CoverTypeEnum, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.CoverFireStyle, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EnterCover, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.ExitCover, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.IsCloseCover, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.DistanceScale, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.AbsoluteDistance, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.AngleToNormal, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.OutAngle, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.ThreatAngle, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.StopExitCoverOutAround, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EnterStrategy, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.ExitStyle, p_Reader, p_Parser);
		}
	}
}
