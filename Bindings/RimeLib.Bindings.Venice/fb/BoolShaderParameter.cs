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
	[ContainerType(4, 8)]
	public class BoolShaderParameter
	{
		[ContainerField(0), LayoutImmutable]
		public string ParameterName { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public bool Value { get; set; }
		
		public static void Deserialize(BoolShaderParameter p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ParameterName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Value = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
