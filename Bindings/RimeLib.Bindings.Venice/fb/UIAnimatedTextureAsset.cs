///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class UIAnimatedTextureAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float FrameRate { get; set; }

		[ContainerField(16)]
		public CtrRef<TextureAsset> TextureAtlas { get; set; } = new();

		[ContainerField(20)]
		public List<UITextureAtlasInfo> TextureInfos { get; set; } = new();

		public static void Deserialize(UIAnimatedTextureAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FrameRate = p_Reader.ReadSingle();
			p_Instance.TextureAtlas.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.TextureInfos.Clear();
			(RimeReader Reader, uint Count) s_TextureInfos = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TextureInfos.Count; ++i)
			{
				var s_Value = new UITextureAtlasInfo();
				fb.UITextureAtlasInfo.Deserialize(s_Value, s_TextureInfos.Reader, p_Parser);
				p_Instance.TextureInfos.Add(s_Value);
			}
			
			s_TextureInfos.Reader.Dispose();
		}

	}
}
