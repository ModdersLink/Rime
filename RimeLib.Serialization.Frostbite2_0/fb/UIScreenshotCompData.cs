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
	[ContainerType(4, 44)]
	public class UIScreenshotCompData :
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint ResizeImageWidth { get; set; }

		[ContainerField(32), JsonProperty(Order = 32)]
		public List<ScreenshotInfo> ScreenshotInfos { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public uint ResizeImageHeight { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool AutoResizeImage { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ResizeImageWidth);
			(RimeWriter Writer, uint ArrayIndex) s_ScreenshotInfos = p_EbxWriter.GetArrayWriter(ScreenshotInfos.GetType(), ScreenshotInfos.Count);
			p_Writer.Write(s_ScreenshotInfos.ArrayIndex);
			foreach (var s_Entry in ScreenshotInfos)
			{
				s_Entry.Serialize(s_ScreenshotInfos.Writer, p_EbxWriter);
			}
			p_Writer.Write(ResizeImageHeight);
			p_Writer.Write(AutoResizeImage);
			p_Writer.WriteNullBytes(3);
		}
	}
}
