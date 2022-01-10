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
	[ContainerType(4, 28)]
	public class ShaderTextureUnlockPartCollection : 
		ShaderCustomizationUnlockPartCollection
	{
		[ContainerField(20)]
		public CtrRef<TextureReference> DefaultTextureReference { get; set; } = new();

		[ContainerField(24)]
		public List<CtrRef<TextureUnlockPartData>> UnlockParts { get; set; } = new();

		public static void Deserialize(ShaderTextureUnlockPartCollection p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DefaultTextureReference.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.UnlockParts.Clear();
			(RimeReader Reader, uint Count) s_UnlockParts = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UnlockParts.Count; ++i)
			{
				var s_CtrRef = new CtrRef<TextureUnlockPartData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_UnlockParts.Reader.ReadUInt32()));
				p_Instance.UnlockParts.Add(s_CtrRef);
			}
			
			s_UnlockParts.Reader.Dispose();
		}

	}
}
