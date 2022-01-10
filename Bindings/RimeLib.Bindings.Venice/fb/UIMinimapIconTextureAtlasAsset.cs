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
	[ContainerType(4, 20)]
	public class UIMinimapIconTextureAtlasAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<UIMinimapIconTexture> Icons { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<TextureAsset> TextureAtlas { get; set; } = new();

		public static void Deserialize(UIMinimapIconTextureAtlasAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Icons.Clear();
			(RimeReader Reader, uint Count) s_Icons = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Icons.Count; ++i)
			{
				var s_Value = new UIMinimapIconTexture();
				fb.UIMinimapIconTexture.Deserialize(s_Value, s_Icons.Reader, p_Parser);
				p_Instance.Icons.Add(s_Value);
			}
			
			s_Icons.Reader.Dispose();
			p_Instance.TextureAtlas.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
