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
	[ContainerType(4, 20)]
	public class RouteNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<RouteEntry>> Routes { get; set; } = new();

		public static void Deserialize(RouteNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.In, p_Reader, p_Parser);
			p_Instance.Routes.Clear();
			(RimeReader Reader, uint Count) s_Routes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Routes.Count; ++i)
			{
				var s_CtrRef = new CtrRef<RouteEntry>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Routes.Reader.ReadUInt32()));
				p_Instance.Routes.Add(s_CtrRef);
			}
			
			s_Routes.Reader.Dispose();
		}

	}
}
