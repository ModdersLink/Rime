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
	[ContainerType(16, 112)]
	public class ShaderParameterComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public List<ShaderParameterVector> ShaderParameterVectors { get; set; } = new();

		public static void Deserialize(ShaderParameterComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ShaderParameterVectors.Clear();
			(RimeReader Reader, uint Count) s_ShaderParameterVectors = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ShaderParameterVectors.Count; ++i)
			{
				var s_Value = new ShaderParameterVector();
				fb.ShaderParameterVector.Deserialize(s_Value, s_ShaderParameterVectors.Reader, p_Parser);
				p_Instance.ShaderParameterVectors.Add(s_Value);
			}
			
			s_ShaderParameterVectors.Reader.Dispose();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
