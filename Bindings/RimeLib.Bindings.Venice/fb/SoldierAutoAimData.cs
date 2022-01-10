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
	public class SoldierAutoAimData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<AutoAimData> Poses { get; set; } = new();

		public static void Deserialize(SoldierAutoAimData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Poses.Clear();
			(RimeReader Reader, uint Count) s_Poses = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Poses.Count; ++i)
			{
				var s_Value = new AutoAimData();
				fb.AutoAimData.Deserialize(s_Value, s_Poses.Reader, p_Parser);
				p_Instance.Poses.Add(s_Value);
			}
			
			s_Poses.Reader.Dispose();
		}

	}
}
