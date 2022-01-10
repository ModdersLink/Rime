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
	public class BFServerConfiguration : 
		DataContainer
	{
		[ContainerField(8)]
		public List<BFServerConfigurationSchedule> Schedules { get; set; } = new();

		public static void Deserialize(BFServerConfiguration p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Schedules.Clear();
			(RimeReader Reader, uint Count) s_Schedules = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Schedules.Count; ++i)
			{
				var s_Value = new BFServerConfigurationSchedule();
				fb.BFServerConfigurationSchedule.Deserialize(s_Value, s_Schedules.Reader, p_Parser);
				p_Instance.Schedules.Add(s_Value);
			}
			
			s_Schedules.Reader.Dispose();
		}

	}
}
