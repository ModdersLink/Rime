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
	[ContainerType(4, 24)]
	public partial class CustomizedMaterialData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private List<string> _MaterialNames = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<UnlockableColorCollection> _ColorParameters = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<UnlockableTextureCollection> _TextureParameters = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<UnlockableTextureSliceCollection> _TextureSliceParameters = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			(RimeWriter Writer, uint ArrayIndex) s_MaterialNames = p_EbxWriter.GetArrayWriter(MaterialNames.GetType(), MaterialNames.Count);
			p_Writer.Write(s_MaterialNames.ArrayIndex);
			foreach (var s_Entry in MaterialNames)
			{
				s_MaterialNames.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_ColorParameters = p_EbxWriter.GetArrayWriter(ColorParameters.GetType(), ColorParameters.Count);
			p_Writer.Write(s_ColorParameters.ArrayIndex);
			foreach (var s_Entry in ColorParameters)
			{
				s_ColorParameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_TextureParameters = p_EbxWriter.GetArrayWriter(TextureParameters.GetType(), TextureParameters.Count);
			p_Writer.Write(s_TextureParameters.ArrayIndex);
			foreach (var s_Entry in TextureParameters)
			{
				s_TextureParameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_TextureSliceParameters = p_EbxWriter.GetArrayWriter(TextureSliceParameters.GetType(), TextureSliceParameters.Count);
			p_Writer.Write(s_TextureSliceParameters.ArrayIndex);
			foreach (var s_Entry in TextureSliceParameters)
			{
				s_TextureSliceParameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
