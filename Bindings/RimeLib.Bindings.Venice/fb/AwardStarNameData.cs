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
	public class AwardStarNameData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<AwardStarNameInstance> NameInstances { get; set; } = new();

		public static void Deserialize(AwardStarNameData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.NameInstances.Clear();
			(RimeReader Reader, uint Count) s_NameInstances = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_NameInstances.Count; ++i)
			{
				var s_Value = new AwardStarNameInstance();
				fb.AwardStarNameInstance.Deserialize(s_Value, s_NameInstances.Reader, p_Parser);
				p_Instance.NameInstances.Add(s_Value);
			}
			
			s_NameInstances.Reader.Dispose();
		}

	}
}
