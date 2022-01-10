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
	public class PathfindingSystemEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public List<uint> PathfindingTypesOnLevel { get; set; } = new();

		public static void Deserialize(PathfindingSystemEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PathfindingTypesOnLevel.Clear();
			(RimeReader Reader, uint Count) s_PathfindingTypesOnLevel = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PathfindingTypesOnLevel.Count; ++i)
			{
				var s_Value = s_PathfindingTypesOnLevel.Reader.ReadUInt32();
				p_Instance.PathfindingTypesOnLevel.Add(s_Value);
			}
			
			s_PathfindingTypesOnLevel.Reader.Dispose();
		}

	}
}
