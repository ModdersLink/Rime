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
	public partial class EmitterSystemAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<EmitterTextureAtlasInfo> _TextureInfos = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<TextureAsset> _BaseAtlasTexture = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<TextureAsset> _NormalAtlasTexture = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_TextureInfos = p_EbxWriter.GetArrayWriter(TextureInfos.GetType(), TextureInfos.Count);
			p_Writer.Write(s_TextureInfos.ArrayIndex);
			foreach (var s_Entry in TextureInfos)
			{
				s_Entry.Serialize(s_TextureInfos.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(BaseAtlasTexture));
			p_Writer.Write(p_EbxWriter.WriteImport(NormalAtlasTexture));
		}
	}
}
