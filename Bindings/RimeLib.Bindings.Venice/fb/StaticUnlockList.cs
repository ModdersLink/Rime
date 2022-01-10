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
	public class StaticUnlockList : 
		Asset
	{
		[ContainerField(12)]
		public List<BasicUnlockInfo> UnlockInfos { get; set; } = new();

		public static void Deserialize(StaticUnlockList p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UnlockInfos.Clear();
			(RimeReader Reader, uint Count) s_UnlockInfos = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UnlockInfos.Count; ++i)
			{
				var s_Value = new BasicUnlockInfo();
				fb.BasicUnlockInfo.Deserialize(s_Value, s_UnlockInfos.Reader, p_Parser);
				p_Instance.UnlockInfos.Add(s_Value);
			}
			
			s_UnlockInfos.Reader.Dispose();
		}

	}
}
