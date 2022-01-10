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
	public class StaticEnlightenData : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<TextureAsset> StaticIrradianceChromaTexture { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<TextureAsset> StaticIrradianceLumaTexture { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<TextureAsset> StaticDirectionTexture { get; set; } = new();

		public static void Deserialize(StaticEnlightenData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.StaticIrradianceChromaTexture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.StaticIrradianceLumaTexture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.StaticDirectionTexture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
