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

namespace fb.Render;

[ContainerType(8, 88)]
public class TessellationShaderFragmentAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string SourceFile { get; set; } = string.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string HSControlPointFunctionName { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string HSPatchConstantFunctionName { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string DSFunctionName { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string VSOutputStructName { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string HSControlPointOutputStructName { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string HSPatchConstantOutputStructName { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string DSOutputStructName { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(SourceFile));
		p_Writer.Write(p_EbxWriter.WriteString(HSControlPointFunctionName));
		p_Writer.Write(p_EbxWriter.WriteString(HSPatchConstantFunctionName));
		p_Writer.Write(p_EbxWriter.WriteString(DSFunctionName));
		p_Writer.Write(p_EbxWriter.WriteString(VSOutputStructName));
		p_Writer.Write(p_EbxWriter.WriteString(HSControlPointOutputStructName));
		p_Writer.Write(p_EbxWriter.WriteString(HSPatchConstantOutputStructName));
		p_Writer.Write(p_EbxWriter.WriteString(DSOutputStructName));
	}
}

