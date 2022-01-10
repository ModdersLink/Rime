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
	[ContainerType(16, 64)]
	public class UpdateClipScaleData : 
		ProcessorData
	{
		[ContainerField(48)]
		public List<short> Lookup { get; set; } = new();

		public static void Deserialize(UpdateClipScaleData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Lookup.Clear();
			(RimeReader Reader, uint Count) s_Lookup = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Lookup.Count; ++i)
			{
				var s_Value = s_Lookup.Reader.ReadInt16();
				p_Instance.Lookup.Add(s_Value);
			}
			
			s_Lookup.Reader.Dispose();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
