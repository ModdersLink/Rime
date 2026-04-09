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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 128)]
	public partial class FaceposerComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private AntRef _FacePoserEnabled = new();

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _LodDistance;

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private AntRef _FacePoseLibraryReference = new();

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private List<AntRef> _FacePoseLibrary = new();

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, JsonProperty(Order = 112)]
		private string _FacePoserDofSetName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private List<string> _ShaderExposedValues = new();

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private int _FacePoseLibraryIndex;

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
