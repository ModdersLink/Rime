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
	[ContainerType(4, 16)]
	public class UIMinimapIconTextureState :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public UIIconState State { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public float FrameRate { get; set; }
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<UIMinimapIconUv> TextureInfos { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public bool ShouldRotate { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) State);
			p_Writer.Write(FrameRate);
			(RimeWriter Writer, uint ArrayIndex) s_TextureInfos = p_EbxWriter.GetArrayWriter(TextureInfos.GetType(), TextureInfos.Count);
			p_Writer.Write(s_TextureInfos.ArrayIndex);
			foreach (var s_Entry in TextureInfos)
			{
				s_Entry.Serialize(s_TextureInfos.Writer, p_EbxWriter);
			}
			p_Writer.Write(ShouldRotate);
			p_Writer.WriteNullBytes(3);
		}
	}
}
