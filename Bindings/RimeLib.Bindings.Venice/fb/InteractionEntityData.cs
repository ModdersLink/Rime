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
	[ContainerType(16, 128)]
	public class InteractionEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float UseWithinRadius { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float UseWithinAngle { get; set; }

		[ContainerField(104), JsonProperty(Order = 104)]
		public CtrRef<SoundAsset> PreInteractionSoundEffect { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public uint MaxUses { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public bool AllowInteractionViaRemoteEntry { get; set; }

		[ContainerField(113), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
		public bool TestIfOccluded { get; set; }

	}
}
