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
	[ContainerType(4, 32)]
	public class WaypointsShapeData : 
		VectorShapeData
	{
		[ContainerField(28)]
		public List<CtrRef<WaypointData>> Waypoints { get; set; } = new();

		public static void Deserialize(WaypointsShapeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Waypoints.Clear();
			(RimeReader Reader, uint Count) s_Waypoints = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Waypoints.Count; ++i)
			{
				var s_CtrRef = new CtrRef<WaypointData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Waypoints.Reader.ReadUInt32()));
				p_Instance.Waypoints.Add(s_CtrRef);
			}
			
			s_Waypoints.Reader.Dispose();
		}

	}
}
