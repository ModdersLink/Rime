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
	[ContainerType(4, 32)]
	public class ScreenshotInfo
	{
		[ContainerField(0), LayoutImmutable]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint CropImageY1 { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint CropImageX1 { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint CropImageX2 { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint CropImageY2 { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint ResizeOutputImageHeight { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint ResizeOutputImageWidth { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool ResizeOutputImage { get; set; }
		
		[ContainerField(29), LayoutImmutable, Blittable]
		public bool CropImage { get; set; }
		
		public static void Deserialize(ScreenshotInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.CropImageY1 = p_Reader.ReadUInt32();
			p_Instance.CropImageX1 = p_Reader.ReadUInt32();
			p_Instance.CropImageX2 = p_Reader.ReadUInt32();
			p_Instance.CropImageY2 = p_Reader.ReadUInt32();
			p_Instance.ResizeOutputImageHeight = p_Reader.ReadUInt32();
			p_Instance.ResizeOutputImageWidth = p_Reader.ReadUInt32();
			p_Instance.ResizeOutputImage = p_Reader.ReadBool();
			p_Instance.CropImage = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}
	}
}
