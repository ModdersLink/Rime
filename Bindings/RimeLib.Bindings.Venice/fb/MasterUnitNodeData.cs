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
	[ContainerType(4, 172)]
	public class MasterUnitNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort SettingsIndex { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Amplitude { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort MasterGain { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort MasterLfeGain { get; set; } = new();

		[ContainerField(40)]
		public AudioGraphNodePort MasterDialogGain { get; set; } = new();

		[ContainerField(48)]
		public AudioGraphNodePort MainMixGain { get; set; } = new();

		[ContainerField(56)]
		public AudioGraphNodePort PostEffectsGain { get; set; } = new();

		[ContainerField(64)]
		public AudioGraphNodePort ReverbGain { get; set; } = new();

		[ContainerField(72)]
		public AudioGraphNodePort FadeTime { get; set; } = new();

		[ContainerField(80)]
		public AudioGraphNodePort HighPassFreq { get; set; } = new();

		[ContainerField(88)]
		public AudioGraphNodePort LowShelfFreq { get; set; } = new();

		[ContainerField(96)]
		public AudioGraphNodePort LowShelfGain { get; set; } = new();

		[ContainerField(104)]
		public AudioGraphNodePort HighShelfFreq { get; set; } = new();

		[ContainerField(112)]
		public AudioGraphNodePort HighShelfGain { get; set; } = new();

		[ContainerField(120)]
		public AudioGraphNodePort CompThreshold { get; set; } = new();

		[ContainerField(128)]
		public AudioGraphNodePort CompRatio { get; set; } = new();

		[ContainerField(136)]
		public AudioGraphNodePort CompAttack { get; set; } = new();

		[ContainerField(144)]
		public AudioGraphNodePort CompRelease { get; set; } = new();

		[ContainerField(152)]
		public AudioGraphNodePort DistClipLevel { get; set; } = new();

		[ContainerField(160)]
		public AudioGraphNodePort ParallelDistortionGain { get; set; } = new();

		[ContainerField(168)]
		public RefArray<MasterUnitSettings> Settings { get; set; } = new();

	}
}
