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
	public class CustomizedMaterialData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<string> MaterialNames { get; set; } = new();

		[ContainerField(12)]
		public List<CtrRef<UnlockableColorCollection>> ColorParameters { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<UnlockableTextureCollection>> TextureParameters { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<UnlockableTextureSliceCollection>> TextureSliceParameters { get; set; } = new();

		public static void Deserialize(CustomizedMaterialData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaterialNames.Clear();
			(RimeReader Reader, uint Count) s_MaterialNames = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_MaterialNames.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_MaterialNames.Reader.ReadUInt32());
				p_Instance.MaterialNames.Add(s_Value);
			}
			
			s_MaterialNames.Reader.Dispose();
			p_Instance.ColorParameters.Clear();
			(RimeReader Reader, uint Count) s_ColorParameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ColorParameters.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UnlockableColorCollection>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ColorParameters.Reader.ReadUInt32()));
				p_Instance.ColorParameters.Add(s_CtrRef);
			}
			
			s_ColorParameters.Reader.Dispose();
			p_Instance.TextureParameters.Clear();
			(RimeReader Reader, uint Count) s_TextureParameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TextureParameters.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UnlockableTextureCollection>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_TextureParameters.Reader.ReadUInt32()));
				p_Instance.TextureParameters.Add(s_CtrRef);
			}
			
			s_TextureParameters.Reader.Dispose();
			p_Instance.TextureSliceParameters.Clear();
			(RimeReader Reader, uint Count) s_TextureSliceParameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TextureSliceParameters.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UnlockableTextureSliceCollection>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_TextureSliceParameters.Reader.ReadUInt32()));
				p_Instance.TextureSliceParameters.Add(s_CtrRef);
			}
			
			s_TextureSliceParameters.Reader.Dispose();
		}

	}
}
