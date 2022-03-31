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

namespace fb
{
	[ContainerType(4, 48)]
	public class SpecialMovesBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef TriggerHighVault { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef TriggerUpVault { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef TriggerLowVault { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef TriggerSlideIntoProne { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef TriggerSpecialAnimation { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef SpecialAnimationIndex { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public AntRef ObjectHeight { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public AntRef ObjectDistance { get; set; } = new();
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public AntRef StartObjectDistanceTimer { get; set; } = new();
		
		[ContainerField(36), JsonProperty(Order = 36)]
		public AntRef VaultObjectPositionX { get; set; } = new();
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public AntRef VaultObjectPositionZ { get; set; } = new();
		
		[ContainerField(44), JsonProperty(Order = 44)]
		public AntRef CancelAnimation { get; set; } = new();
		
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
