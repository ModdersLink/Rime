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
	public class LevelReportingAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<LevelDescriptionAsset>> BuiltLevels { get; set; } = new();

		public static void Deserialize(LevelReportingAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.BuiltLevels.Clear();
			(RimeReader Reader, uint Count) s_BuiltLevels = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BuiltLevels.Count; ++i)
			{
				var s_CtrRef = new CtrRef<LevelDescriptionAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_BuiltLevels.Reader.ReadUInt32()));
				p_Instance.BuiltLevels.Add(s_CtrRef);
			}
			
			s_BuiltLevels.Reader.Dispose();
		}

	}
}
