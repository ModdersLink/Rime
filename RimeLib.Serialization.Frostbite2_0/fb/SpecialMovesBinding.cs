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
	[ContainerType(4, 48)]
	public partial class SpecialMovesBinding :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private AntRef _TriggerHighVault = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private AntRef _TriggerUpVault = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AntRef _TriggerLowVault = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AntRef _TriggerSlideIntoProne = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AntRef _TriggerSpecialAnimation = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AntRef _SpecialAnimationIndex = new();
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AntRef _ObjectHeight = new();
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AntRef _ObjectDistance = new();
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AntRef _StartObjectDistanceTimer = new();
		
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private AntRef _VaultObjectPositionX = new();
		
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AntRef _VaultObjectPositionZ = new();
		
		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private AntRef _CancelAnimation = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			TriggerHighVault.Serialize(p_Writer, p_EbxWriter);
			TriggerUpVault.Serialize(p_Writer, p_EbxWriter);
			TriggerLowVault.Serialize(p_Writer, p_EbxWriter);
			TriggerSlideIntoProne.Serialize(p_Writer, p_EbxWriter);
			TriggerSpecialAnimation.Serialize(p_Writer, p_EbxWriter);
			SpecialAnimationIndex.Serialize(p_Writer, p_EbxWriter);
			ObjectHeight.Serialize(p_Writer, p_EbxWriter);
			ObjectDistance.Serialize(p_Writer, p_EbxWriter);
			StartObjectDistanceTimer.Serialize(p_Writer, p_EbxWriter);
			VaultObjectPositionX.Serialize(p_Writer, p_EbxWriter);
			VaultObjectPositionZ.Serialize(p_Writer, p_EbxWriter);
			CancelAnimation.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
