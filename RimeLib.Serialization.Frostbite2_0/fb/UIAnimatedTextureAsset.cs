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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class UIAnimatedTextureAsset :
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float FrameRate { get; set; }

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<TextureAsset> TextureAtlas { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public List<UITextureAtlasInfo> TextureInfos { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FrameRate);
			p_Writer.Write(p_EbxWriter.WriteImport(TextureAtlas));
			(RimeWriter Writer, uint ArrayIndex) s_TextureInfos = p_EbxWriter.GetArrayWriter(TextureInfos.GetType(), TextureInfos.Count);
			p_Writer.Write(s_TextureInfos.ArrayIndex);
			foreach (var s_Entry in TextureInfos)
			{
				s_Entry.Serialize(s_TextureInfos.Writer, p_EbxWriter);
			}
		}
	}
}
