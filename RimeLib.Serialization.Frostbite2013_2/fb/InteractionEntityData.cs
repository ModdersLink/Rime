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

using fb.Audio;
using fb.Core;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 128)]
public class InteractionEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float UseWithinRadius { get; set; } = 0.300f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float UseWithinAngle { get; set; } = 360.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public uint MaxUses { get; set; } = 0;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float DisplayWithinRadius { get; set; } = 25.000f;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<SoundAsset> PreInteractionSoundEffect { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public bool TestIfOccluded { get; set; } = false;
	
	[ContainerField(0x79), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
	public bool AllowInteractionViaRemoteEntry { get; set; } = true;
	
	[ContainerField(0x7a), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
	public bool UseDisplayWithinRadius { get; set; } = false;
	
	[ContainerField(0x7b), LayoutImmutable, Blittable, JsonProperty(Order = 123)]
	public bool Enabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(UseWithinRadius);
		p_Writer.Write(UseWithinAngle);
		p_Writer.Write(MaxUses);
		p_Writer.Write(DisplayWithinRadius);
		p_Writer.Write(p_EbxWriter.WriteImport(PreInteractionSoundEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TestIfOccluded);
		p_Writer.Write(AllowInteractionViaRemoteEntry);
		p_Writer.Write(UseDisplayWithinRadius);
		p_Writer.Write(Enabled);
		p_Writer.WriteNullBytes(4);
	}
}

