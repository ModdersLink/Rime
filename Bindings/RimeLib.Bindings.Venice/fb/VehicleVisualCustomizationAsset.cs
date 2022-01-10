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
	public class VehicleVisualCustomizationAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<ShaderTextureUnlockPartCollection>> TextureUnlockPartCollections { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<TextUnlockPartData>> TextUnlockParts { get; set; } = new();

		public static void Deserialize(VehicleVisualCustomizationAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TextureUnlockPartCollections.Clear();
			(RimeReader Reader, uint Count) s_TextureUnlockPartCollections = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TextureUnlockPartCollections.Count; ++i)
			{
				var s_CtrRef = new CtrRef<ShaderTextureUnlockPartCollection>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_TextureUnlockPartCollections.Reader.ReadUInt32()));
				p_Instance.TextureUnlockPartCollections.Add(s_CtrRef);
			}
			
			s_TextureUnlockPartCollections.Reader.Dispose();
			p_Instance.TextUnlockParts.Clear();
			(RimeReader Reader, uint Count) s_TextUnlockParts = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TextUnlockParts.Count; ++i)
			{
				var s_CtrRef = new CtrRef<TextUnlockPartData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_TextUnlockParts.Reader.ReadUInt32()));
				p_Instance.TextUnlockParts.Add(s_CtrRef);
			}
			
			s_TextUnlockParts.Reader.Dispose();
		}

	}
}
