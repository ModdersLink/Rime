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
	public class ManualDataEntry
	{
		[ContainerField(0)]
		public GamePlatform Platform { get; set; } = new();
		
		[ContainerField(4)]
		public LanguageFormat Language { get; set; } = new();
		
		[ContainerField(8)]
		public List<CtrRef<TextureAsset>> Textures { get; set; } = new();
		
		public static void Deserialize(ManualDataEntry p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Platform = (GamePlatform) p_Reader.ReadInt32();
			p_Instance.Language = (LanguageFormat) p_Reader.ReadInt32();
			p_Instance.Textures.Clear();
			(RimeReader Reader, uint Count) s_Textures = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Textures.Count; ++i)
			{
				var s_CtrRef = new CtrRef<TextureAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Textures.Reader.ReadUInt32()));
				p_Instance.Textures.Add(s_CtrRef);
			}
			
			s_Textures.Reader.Dispose();
		}
	}
}
