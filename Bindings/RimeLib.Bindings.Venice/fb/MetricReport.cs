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
	public class MetricReport : 
		DataContainer
	{
		[ContainerField(8)]
		public List<CtrRef<MetricEvent>> Events { get; set; } = new();

		public static void Deserialize(MetricReport p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Events.Clear();
			(RimeReader Reader, uint Count) s_Events = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Events.Count; ++i)
			{
				var s_CtrRef = new CtrRef<MetricEvent>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Events.Reader.ReadUInt32()));
				p_Instance.Events.Add(s_CtrRef);
			}
			
			s_Events.Reader.Dispose();
		}

	}
}
