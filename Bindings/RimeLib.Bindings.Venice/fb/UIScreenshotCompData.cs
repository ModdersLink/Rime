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
	[ContainerType(4, 44)]
	public class UIScreenshotCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint ResizeImageWidth { get; set; }

		[ContainerField(32)]
		public List<ScreenshotInfo> ScreenshotInfos { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint ResizeImageHeight { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool AutoResizeImage { get; set; }

		public static void Deserialize(UIScreenshotCompData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ResizeImageWidth = p_Reader.ReadUInt32();
			p_Instance.ScreenshotInfos.Clear();
			(RimeReader Reader, uint Count) s_ScreenshotInfos = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ScreenshotInfos.Count; ++i)
			{
				var s_Value = new ScreenshotInfo();
				fb.ScreenshotInfo.Deserialize(s_Value, s_ScreenshotInfos.Reader, p_Parser);
				p_Instance.ScreenshotInfos.Add(s_Value);
			}
			
			s_ScreenshotInfos.Reader.Dispose();
			p_Instance.ResizeImageHeight = p_Reader.ReadUInt32();
			p_Instance.AutoResizeImage = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
