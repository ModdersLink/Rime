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
	[ContainerType(4, 16)]
	public class UIMinimapIconTextureState
	{
		[ContainerField(0)]
		public UIIconState State { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float FrameRate { get; set; }
		
		[ContainerField(8)]
		public List<UIMinimapIconUv> TextureInfos { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool ShouldRotate { get; set; }
		
		public static void Deserialize(UIMinimapIconTextureState p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.State = (UIIconState) p_Reader.ReadInt32();
			p_Instance.FrameRate = p_Reader.ReadSingle();
			p_Instance.TextureInfos.Clear();
			(RimeReader Reader, uint Count) s_TextureInfos = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TextureInfos.Count; ++i)
			{
				var s_Value = new UIMinimapIconUv();
				fb.UIMinimapIconUv.Deserialize(s_Value, s_TextureInfos.Reader, p_Parser);
				p_Instance.TextureInfos.Add(s_Value);
			}
			
			s_TextureInfos.Reader.Dispose();
			p_Instance.ShouldRotate = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
