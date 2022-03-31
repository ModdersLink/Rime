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
	public class VehicleVisualCustomizationAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<ShaderTextureUnlockPartCollection> TextureUnlockPartCollections { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<TextUnlockPartData> TextUnlockParts { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_TextureUnlockPartCollections = p_EbxWriter.GetArrayWriter(TextureUnlockPartCollections.GetType(), TextureUnlockPartCollections.Count);
			p_Writer.Write(s_TextureUnlockPartCollections.ArrayIndex);
			foreach (var s_Entry in TextureUnlockPartCollections)
			{
				s_TextureUnlockPartCollections.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_TextUnlockParts = p_EbxWriter.GetArrayWriter(TextUnlockParts.GetType(), TextUnlockParts.Count);
			p_Writer.Write(s_TextUnlockParts.ArrayIndex);
			foreach (var s_Entry in TextUnlockParts)
			{
				s_TextUnlockParts.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
