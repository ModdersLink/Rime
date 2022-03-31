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

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(UseWithinRadius);
			p_Writer.Write(UseWithinAngle);
			p_Writer.Write(p_EbxWriter.WriteImport(PreInteractionSoundEffect));
			p_Writer.Write(MaxUses);
			p_Writer.Write(AllowInteractionViaRemoteEntry);
			p_Writer.Write(TestIfOccluded);
			p_Writer.WriteNullBytes(14);
		}
	}
}
