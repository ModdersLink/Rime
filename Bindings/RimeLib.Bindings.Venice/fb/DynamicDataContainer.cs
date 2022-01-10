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
	public class DynamicDataContainer : 
		DataContainer
	{
		[ContainerField(8)]
		public List<DataField> Fields { get; set; } = new();

		public static void Deserialize(DynamicDataContainer p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Fields.Clear();
			(RimeReader Reader, uint Count) s_Fields = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Fields.Count; ++i)
			{
				var s_Value = new DataField();
				fb.DataField.Deserialize(s_Value, s_Fields.Reader, p_Parser);
				p_Instance.Fields.Add(s_Value);
			}
			
			s_Fields.Reader.Dispose();
		}

	}
}
