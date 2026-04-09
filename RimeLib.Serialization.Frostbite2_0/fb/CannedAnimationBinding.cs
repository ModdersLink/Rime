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
	[ContainerType(4, 40)]
	public partial class CannedAnimationBinding :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private AntRef _LevelIndex = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private AntRef _ScenarioIndex = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AntRef _ActorIndex = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AntRef _PartIndex = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AntRef _TriggerCannedAnimation = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AntRef _ExitCannedAnimation = new();
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AntRef _ExternalTime = new();
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AntRef _BlendValue = new();
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AntRef _AdvanceScenario = new();
		
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private AntRef _EnteredLoop = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			LevelIndex.Serialize(p_Writer, p_EbxWriter);
			ScenarioIndex.Serialize(p_Writer, p_EbxWriter);
			ActorIndex.Serialize(p_Writer, p_EbxWriter);
			PartIndex.Serialize(p_Writer, p_EbxWriter);
			TriggerCannedAnimation.Serialize(p_Writer, p_EbxWriter);
			ExitCannedAnimation.Serialize(p_Writer, p_EbxWriter);
			ExternalTime.Serialize(p_Writer, p_EbxWriter);
			BlendValue.Serialize(p_Writer, p_EbxWriter);
			AdvanceScenario.Serialize(p_Writer, p_EbxWriter);
			EnteredLoop.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
