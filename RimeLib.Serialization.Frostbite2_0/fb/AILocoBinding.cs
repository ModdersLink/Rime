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
	[ContainerType(4, 36)]
	public partial class AILocoBinding :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private AntRef _LocoTarget = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private AntRef _AttentionState = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AntRef _EndPoseEnum = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AntRef _CurrentPoseEnum = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AntRef _EnterExitPoseEnum = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AntRef _RunStyle = new();
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AntRef _TargetWaypointPosition = new();
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AntRef _TargetSpeedLevel = new();
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AntRef _EnableProceduralHeadAim = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			LocoTarget.Serialize(p_Writer, p_EbxWriter);
			AttentionState.Serialize(p_Writer, p_EbxWriter);
			EndPoseEnum.Serialize(p_Writer, p_EbxWriter);
			CurrentPoseEnum.Serialize(p_Writer, p_EbxWriter);
			EnterExitPoseEnum.Serialize(p_Writer, p_EbxWriter);
			RunStyle.Serialize(p_Writer, p_EbxWriter);
			TargetWaypointPosition.Serialize(p_Writer, p_EbxWriter);
			TargetSpeedLevel.Serialize(p_Writer, p_EbxWriter);
			EnableProceduralHeadAim.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
