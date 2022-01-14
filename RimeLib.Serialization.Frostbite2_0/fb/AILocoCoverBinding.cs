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
	[ContainerType(4, 72)]
	public class AILocoCoverBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef PrepareFire { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef ThrowGrenade { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef PeekOut { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef IdleBehindCover { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef PeekType { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef CoverTypeEnum { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public AntRef CoverFireStyle { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public AntRef EnterCover { get; set; } = new();
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public AntRef ExitCover { get; set; } = new();
		
		[ContainerField(36), JsonProperty(Order = 36)]
		public AntRef IsCloseCover { get; set; } = new();
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public AntRef DistanceScale { get; set; } = new();
		
		[ContainerField(44), JsonProperty(Order = 44)]
		public AntRef AbsoluteDistance { get; set; } = new();
		
		[ContainerField(48), JsonProperty(Order = 48)]
		public AntRef AngleToNormal { get; set; } = new();
		
		[ContainerField(52), JsonProperty(Order = 52)]
		public AntRef OutAngle { get; set; } = new();
		
		[ContainerField(56), JsonProperty(Order = 56)]
		public AntRef ThreatAngle { get; set; } = new();
		
		[ContainerField(60), JsonProperty(Order = 60)]
		public AntRef StopExitCoverOutAround { get; set; } = new();
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public AntRef EnterStrategy { get; set; } = new();
		
		[ContainerField(68), JsonProperty(Order = 68)]
		public AntRef ExitStyle { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			PrepareFire.Serialize(p_Writer, p_EbxWriter);
			ThrowGrenade.Serialize(p_Writer, p_EbxWriter);
			PeekOut.Serialize(p_Writer, p_EbxWriter);
			IdleBehindCover.Serialize(p_Writer, p_EbxWriter);
			PeekType.Serialize(p_Writer, p_EbxWriter);
			CoverTypeEnum.Serialize(p_Writer, p_EbxWriter);
			CoverFireStyle.Serialize(p_Writer, p_EbxWriter);
			EnterCover.Serialize(p_Writer, p_EbxWriter);
			ExitCover.Serialize(p_Writer, p_EbxWriter);
			IsCloseCover.Serialize(p_Writer, p_EbxWriter);
			DistanceScale.Serialize(p_Writer, p_EbxWriter);
			AbsoluteDistance.Serialize(p_Writer, p_EbxWriter);
			AngleToNormal.Serialize(p_Writer, p_EbxWriter);
			OutAngle.Serialize(p_Writer, p_EbxWriter);
			ThreatAngle.Serialize(p_Writer, p_EbxWriter);
			StopExitCoverOutAround.Serialize(p_Writer, p_EbxWriter);
			EnterStrategy.Serialize(p_Writer, p_EbxWriter);
			ExitStyle.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
