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
	[ContainerType(4, 28)]
	public class ShaderTextureUnlockPartCollection :
		ShaderCustomizationUnlockPartCollection
	{
		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<TextureReference> DefaultTextureReference { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public RefArray<TextureUnlockPartData> UnlockParts { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultTextureReference));
			(RimeWriter Writer, uint ArrayIndex) s_UnlockParts = p_EbxWriter.GetArrayWriter(UnlockParts.GetType(), UnlockParts.Count);
			p_Writer.Write(s_UnlockParts.ArrayIndex);
			foreach (var s_Entry in UnlockParts)
			{
				s_UnlockParts.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
