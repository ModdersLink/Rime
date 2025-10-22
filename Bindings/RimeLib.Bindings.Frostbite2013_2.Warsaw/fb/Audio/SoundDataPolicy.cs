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

using fb.Core;

namespace fb.Audio;

[ContainerType(8, 40)]
public class SoundDataPolicy
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string Name { get; set; } = string.Empty;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public SoundDataRequestBehavior RequestBehavior { get; set; } = SoundDataRequestBehavior.SoundDataRequestBehavior_Explicit;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public SoundDataReleaseBehavior ReleaseBehavior { get; set; } = SoundDataReleaseBehavior.SoundDataReleaseBehavior_Explicit;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public SoundDataReadTarget PrimeTarget { get; set; } = SoundDataReadTarget.SoundDataReadTarget_Secondary;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public SoundDataReadTarget RequestTarget { get; set; } = SoundDataReadTarget.SoundDataReadTarget_Secondary;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Name));
		p_Writer.Write((int) RequestBehavior);
		p_Writer.Write((int) ReleaseBehavior);
		p_Writer.Write((int) PrimeTarget);
		p_Writer.Write((int) RequestTarget);
	}
}

