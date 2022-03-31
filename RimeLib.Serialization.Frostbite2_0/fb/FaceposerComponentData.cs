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
	public class FaceposerComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public AntRef FacePoserEnabled { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float LodDistance { get; set; }

		[ContainerField(104), JsonProperty(Order = 104)]
		public AntRef FacePoseLibraryReference { get; set; } = new();

		[ContainerField(108), JsonProperty(Order = 108)]
		public List<AntRef> FacePoseLibrary { get; set; } = new();

		[ContainerField(112), LayoutImmutable, JsonProperty(Order = 112)]
		public string FacePoserDofSetName { get; set; } = string.Empty;

		[ContainerField(116), JsonProperty(Order = 116)]
		public List<string> ShaderExposedValues { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public int FacePoseLibraryIndex { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			FacePoserEnabled.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(LodDistance);
			FacePoseLibraryReference.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_FacePoseLibrary = p_EbxWriter.GetArrayWriter(FacePoseLibrary.GetType(), FacePoseLibrary.Count);
			p_Writer.Write(s_FacePoseLibrary.ArrayIndex);
			foreach (var s_Entry in FacePoseLibrary)
			{
				s_Entry.Serialize(s_FacePoseLibrary.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteString(FacePoserDofSetName));
			(RimeWriter Writer, uint ArrayIndex) s_ShaderExposedValues = p_EbxWriter.GetArrayWriter(ShaderExposedValues.GetType(), ShaderExposedValues.Count);
			p_Writer.Write(s_ShaderExposedValues.ArrayIndex);
			foreach (var s_Entry in ShaderExposedValues)
			{
				s_ShaderExposedValues.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write(FacePoseLibraryIndex);
			p_Writer.WriteNullBytes(4);
		}
	}
}
