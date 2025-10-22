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

namespace fb.Entity;

[ContainerType(8, 56)]
public class TransformLayerData
	: fb.Entity.TimelineTrackData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<FloatTrackData> Weight { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public LayeredTransform_BlendType Blendtype { get; set; } = LayeredTransform_BlendType.LayeredTransform_BlendType_Special;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Weight));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Blendtype);
		p_Writer.WriteNullBytes(4);
	}
}

