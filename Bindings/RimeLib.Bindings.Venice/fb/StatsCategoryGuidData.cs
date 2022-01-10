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
	public class StatsCategoryGuidData : 
		StatsCategoryBaseData
	{
		[ContainerField(20)]
		public List<GUID> ObjectInstanceGuids { get; set; } = new();

		public static void Deserialize(StatsCategoryGuidData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ObjectInstanceGuids.Clear();
			(RimeReader Reader, uint Count) s_ObjectInstanceGuids = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ObjectInstanceGuids.Count; ++i)
			{
				var s_Value = new GUID(s_ObjectInstanceGuids.Reader);
				p_Instance.ObjectInstanceGuids.Add(s_Value);
			}
			
			s_ObjectInstanceGuids.Reader.Dispose();
		}

	}
}
