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
	[ContainerType(4, 24)]
	public class DestructionVolumeAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<TextureAsset> DiffuseAtlas { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<TextureAsset> NormalmapAtlas { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float AtlasTextureScale { get; set; }

		public static void Deserialize(DestructionVolumeAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DiffuseAtlas.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.NormalmapAtlas.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AtlasTextureScale = p_Reader.ReadSingle();
		}

	}
}
