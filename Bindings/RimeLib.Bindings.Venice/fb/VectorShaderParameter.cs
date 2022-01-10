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
	[ContainerType(16, 32)]
	public class VectorShaderParameter
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Value { get; set; } = new();
		
		[ContainerField(16)]
		public ShaderParameterType ParameterType { get; set; } = new();
		
		[ContainerField(20), LayoutImmutable]
		public string ParameterName { get; set; } = string.Empty;
		
		public static void Deserialize(VectorShaderParameter p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.Value, p_Reader, p_Parser);
			p_Instance.ParameterType = (ShaderParameterType) p_Reader.ReadInt32();
			p_Instance.ParameterName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(8, SeekOrigin.Current);
		}
	}
}
