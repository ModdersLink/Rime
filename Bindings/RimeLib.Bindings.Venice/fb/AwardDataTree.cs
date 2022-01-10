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
	[ContainerType(4, 28)]
	public class AwardDataTree : 
		AwardableTreeBase
	{
		[ContainerField(24)]
		public List<CtrRef<AwardData>> FilteredAwards { get; set; } = new();

		public static void Deserialize(AwardDataTree p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FilteredAwards.Clear();
			(RimeReader Reader, uint Count) s_FilteredAwards = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_FilteredAwards.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AwardData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_FilteredAwards.Reader.ReadUInt32()));
				p_Instance.FilteredAwards.Add(s_CtrRef);
			}
			
			s_FilteredAwards.Reader.Dispose();
		}

	}
}
