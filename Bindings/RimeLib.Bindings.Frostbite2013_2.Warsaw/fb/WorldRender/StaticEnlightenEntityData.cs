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

using fb.Entity;
using fb.Render;
using fb.Core;

namespace fb.WorldRender;

[ContainerType(8, 64)]
public class StaticEnlightenEntityData
	: fb.WorldRender.EnlightenEntityData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<StaticEnlightenData> EnlightenData { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<EnlightenDataAsset> DynamicEnlightenData { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<ObjectBlueprint> VisualEnvironment { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(EnlightenData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DynamicEnlightenData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(VisualEnvironment));
		p_Writer.WriteNullBytes(4);
	}
}

