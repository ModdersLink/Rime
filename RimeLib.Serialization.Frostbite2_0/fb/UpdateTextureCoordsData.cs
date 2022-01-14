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
	[ContainerType(16, 80)]
	public class UpdateTextureCoordsData :
		ProcessorData
	{
		[ContainerField(48), JsonProperty(Order = 48)]
		public EmitterTextureInfo TextureInfo1 { get; set; } = new();

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float TextureBlendValue { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			TextureInfo1.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TextureBlendValue);
			p_Writer.WriteNullBytes(8);
		}
	}
}
