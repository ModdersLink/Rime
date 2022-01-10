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
	public class CharacterStateData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<CtrRef<CharacterStatePoseInfo>> PoseInfo { get; set; } = new();

		public static void Deserialize(CharacterStateData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PoseInfo.Clear();
			(RimeReader Reader, uint Count) s_PoseInfo = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PoseInfo.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CharacterStatePoseInfo>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_PoseInfo.Reader.ReadUInt32()));
				p_Instance.PoseInfo.Add(s_CtrRef);
			}
			
			s_PoseInfo.Reader.Dispose();
		}

	}
}
