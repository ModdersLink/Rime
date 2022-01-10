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
	public class EmitterTextureAtlasInfo
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 MinUv { get; set; } = new();
		
		[ContainerField(8), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 MaxUv { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable]
		public string TextureName { get; set; } = string.Empty;
		
		public static void Deserialize(EmitterTextureAtlasInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec2.Deserialize(p_Instance.MinUv, p_Reader, p_Parser);
			fb.Vec2.Deserialize(p_Instance.MaxUv, p_Reader, p_Parser);
			p_Instance.TextureName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}
	}
}
