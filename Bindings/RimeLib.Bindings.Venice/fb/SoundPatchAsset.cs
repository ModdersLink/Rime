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
	public class SoundPatchAsset : 
		SoundGraphAsset
	{
		[ContainerField(24)]
		public RefArray<AudioGraphNodeData> OutputNodes { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public float Loudness { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float AILoudness { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float Radius { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float DopplerFactor { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float MasterPitch { get; set; }

		[ContainerField(48)]
		public CtrRef<MixGroup> MixGroup { get; set; } = new();

		[ContainerField(52)]
		public CtrRef<AudioGraphEvent> DefaultStopEvent { get; set; } = new();

		[ContainerField(56)]
		public CtrRef<AudioGraphEvent> DefaultStartEvent { get; set; } = new();

		[ContainerField(60)]
		public CtrRef<AudioGraphEvent> DefaultForceInitEvent { get; set; } = new();

		[ContainerField(64)]
		public CtrRef<AudioGraphEvent> DefaultEnterScopeEvent { get; set; } = new();

		[ContainerField(68), LayoutImmutable, Blittable]
		public bool IsPersistent { get; set; }

		[ContainerField(69), LayoutImmutable, Blittable]
		public bool IsLooping { get; set; }

	}
}
