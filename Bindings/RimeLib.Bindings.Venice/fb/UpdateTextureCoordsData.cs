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
	[ContainerType(16, 80)]
	public class UpdateTextureCoordsData : 
		ProcessorData
	{
		[ContainerField(48)]
		public EmitterTextureInfo TextureInfo1 { get; set; } = new();

		[ContainerField(68), LayoutImmutable, Blittable]
		public float TextureBlendValue { get; set; }

		public static void Deserialize(UpdateTextureCoordsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.EmitterTextureInfo.Deserialize(p_Instance.TextureInfo1, p_Reader, p_Parser);
			p_Instance.TextureBlendValue = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
