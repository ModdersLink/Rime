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
	[ContainerType(4, 72)]
	public partial class AILocoCoverBinding :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private AntRef _PrepareFire = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private AntRef _ThrowGrenade = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AntRef _PeekOut = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AntRef _IdleBehindCover = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AntRef _PeekType = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AntRef _CoverTypeEnum = new();
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AntRef _CoverFireStyle = new();
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AntRef _EnterCover = new();
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AntRef _ExitCover = new();
		
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private AntRef _IsCloseCover = new();
		
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AntRef _DistanceScale = new();
		
		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private AntRef _AbsoluteDistance = new();
		
		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private AntRef _AngleToNormal = new();
		
		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private AntRef _OutAngle = new();
		
		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private AntRef _ThreatAngle = new();
		
		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private AntRef _StopExitCoverOutAround = new();
		
		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private AntRef _EnterStrategy = new();
		
		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private AntRef _ExitStyle = new();
		
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
