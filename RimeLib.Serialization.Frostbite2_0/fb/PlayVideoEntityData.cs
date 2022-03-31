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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class PlayVideoEntityData :
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<MovieTextureAsset> Movie { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool KeepBlackScreen { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		public bool AllowSkip { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Movie));
			p_Writer.Write(KeepBlackScreen);
			p_Writer.Write(AllowSkip);
			p_Writer.WriteNullBytes(2);
		}
	}
}
