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
	public class EmitterTextureInfo
	{
		[ContainerField(0), LayoutImmutable]
		public string TextureName { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string NormalmapName { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float AnimationFrameCount { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float AnimationFrameColumnCount { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool EnableAnimation { get; set; }
		
		public static void Deserialize(EmitterTextureInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TextureName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.NormalmapName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.AnimationFrameCount = p_Reader.ReadSingle();
			p_Instance.AnimationFrameColumnCount = p_Reader.ReadSingle();
			p_Instance.EnableAnimation = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
