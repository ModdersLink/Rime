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
	[ContainerType(4, 12)]
	public class PackagingDetailInfo
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int MipsToSkip { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public int LodsToSkip { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool IncludeAnimation { get; set; }
		
		[ContainerField(9), LayoutImmutable, Blittable]
		public bool IncludeMeshes { get; set; }
		
		[ContainerField(10), LayoutImmutable, Blittable]
		public bool IncludeSounds { get; set; }
		
		[ContainerField(11), LayoutImmutable, Blittable]
		public bool IncludeTextures { get; set; }
		
		public static void Deserialize(PackagingDetailInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MipsToSkip = p_Reader.ReadInt32();
			p_Instance.LodsToSkip = p_Reader.ReadInt32();
			p_Instance.IncludeAnimation = p_Reader.ReadBool();
			p_Instance.IncludeMeshes = p_Reader.ReadBool();
			p_Instance.IncludeSounds = p_Reader.ReadBool();
			p_Instance.IncludeTextures = p_Reader.ReadBool();
		}
	}
}
