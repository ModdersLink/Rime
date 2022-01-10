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
	[ContainerType(4, 8)]
	public class DestructionVolumeAtlasTextureData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float AtlasAlphaInfluence { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MaskEdgeThickness { get; set; }
		
		public static void Deserialize(DestructionVolumeAtlasTextureData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.AtlasAlphaInfluence = p_Reader.ReadSingle();
			p_Instance.MaskEdgeThickness = p_Reader.ReadSingle();
		}
	}
}
