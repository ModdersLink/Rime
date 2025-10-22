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
using fb.Ant;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 192)]
public class FaceposerComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public AntRef FacePoserEnabled { get; set; } = new();
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float LodDistance { get; set; } = 10.000f;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public AntRef FacePoseLibraryReference { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public List<AntRef> FacePoseLibrary { get; set; } = new();
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public string FacePoserDofSetName { get; set; } = string.Empty;
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public List<string> ShaderExposedValues { get; set; } = new();
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public int FacePoseLibraryIndex { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		FacePoserEnabled.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LodDistance);
		FacePoseLibraryReference.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_FacePoseLibrary = p_EbxWriter.GetArrayWriter(FacePoseLibrary.GetType(), FacePoseLibrary.Count);
		p_Writer.Write(s_FacePoseLibrary.ArrayIndex);
		foreach (var s_Entry in FacePoseLibrary)
		{
			s_Entry.Serialize(s_FacePoseLibrary.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(FacePoserDofSetName));
		(RimeWriter Writer, uint ArrayIndex) s_ShaderExposedValues = p_EbxWriter.GetArrayWriter(ShaderExposedValues.GetType(), ShaderExposedValues.Count);
		p_Writer.Write(s_ShaderExposedValues.ArrayIndex);
		foreach (var s_Entry in ShaderExposedValues)
		{
			s_ShaderExposedValues.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(FacePoseLibraryIndex);
		p_Writer.WriteNullBytes(4);
	}
}

