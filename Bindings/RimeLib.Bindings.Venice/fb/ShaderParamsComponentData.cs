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
	[ContainerType(16, 128)]
	public class ShaderParamsComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Value { get; set; } = new();

		[ContainerField(112), LayoutImmutable]
		public string ParameterName { get; set; } = string.Empty;

		public static void Deserialize(ShaderParamsComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.Value, p_Reader, p_Parser);
			p_Instance.ParameterName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
