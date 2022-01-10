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
	[ContainerType(4, 16)]
	public class SubWorldInclusionCriterion : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12)]
		public List<string> Options { get; set; } = new();

		public static void Deserialize(SubWorldInclusionCriterion p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Options.Clear();
			(RimeReader Reader, uint Count) s_Options = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Options.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Options.Reader.ReadUInt32());
				p_Instance.Options.Add(s_Value);
			}
			
			s_Options.Reader.Dispose();
		}

	}
}
