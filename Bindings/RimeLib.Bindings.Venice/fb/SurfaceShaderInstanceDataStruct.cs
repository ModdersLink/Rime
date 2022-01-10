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
	public class SurfaceShaderInstanceDataStruct
	{
		[ContainerField(0)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();
		
		[ContainerField(4)]
		public List<BoolShaderParameter> BoolParameters { get; set; } = new();
		
		[ContainerField(8)]
		public List<VectorShaderParameter> VectorParameters { get; set; } = new();
		
		[ContainerField(12)]
		public List<VectorArrayShaderParameter> VectorArrayParameters { get; set; } = new();
		
		[ContainerField(16)]
		public List<TextureShaderParameter> TextureParameters { get; set; } = new();
		
		public static void Deserialize(SurfaceShaderInstanceDataStruct p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Shader.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BoolParameters.Clear();
			(RimeReader Reader, uint Count) s_BoolParameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BoolParameters.Count; ++i)
			{
				var s_Value = new BoolShaderParameter();
				fb.BoolShaderParameter.Deserialize(s_Value, s_BoolParameters.Reader, p_Parser);
				p_Instance.BoolParameters.Add(s_Value);
			}
			
			s_BoolParameters.Reader.Dispose();
			p_Instance.VectorParameters.Clear();
			(RimeReader Reader, uint Count) s_VectorParameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_VectorParameters.Count; ++i)
			{
				var s_Value = new VectorShaderParameter();
				fb.VectorShaderParameter.Deserialize(s_Value, s_VectorParameters.Reader, p_Parser);
				p_Instance.VectorParameters.Add(s_Value);
			}
			
			s_VectorParameters.Reader.Dispose();
			p_Instance.VectorArrayParameters.Clear();
			(RimeReader Reader, uint Count) s_VectorArrayParameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_VectorArrayParameters.Count; ++i)
			{
				var s_Value = new VectorArrayShaderParameter();
				fb.VectorArrayShaderParameter.Deserialize(s_Value, s_VectorArrayParameters.Reader, p_Parser);
				p_Instance.VectorArrayParameters.Add(s_Value);
			}
			
			s_VectorArrayParameters.Reader.Dispose();
			p_Instance.TextureParameters.Clear();
			(RimeReader Reader, uint Count) s_TextureParameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TextureParameters.Count; ++i)
			{
				var s_Value = new TextureShaderParameter();
				fb.TextureShaderParameter.Deserialize(s_Value, s_TextureParameters.Reader, p_Parser);
				p_Instance.TextureParameters.Add(s_Value);
			}
			
			s_TextureParameters.Reader.Dispose();
		}
	}
}
