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

namespace fb
{
	[ContainerType(4, 32)]
	public class SoldierSpawnTemplateData : 
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<CustomizeSoldierData> CustomizeSoldierData { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<GameSensingTemplateData> Sensing { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<GameBehaviourTemplateData> Behaviour { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<AnimationSpawnTemplate> AnimationTemplate { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public RefArray<VoiceOverLabel> VoiceOverLabels { get; set; } = new();

	}
}
