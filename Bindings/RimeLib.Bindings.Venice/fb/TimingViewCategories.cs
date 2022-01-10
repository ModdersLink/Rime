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
	public class TimingViewCategories : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<TimingViewCategory>> TimingCategories { get; set; } = new();

		public static void Deserialize(TimingViewCategories p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TimingCategories.Clear();
			(RimeReader Reader, uint Count) s_TimingCategories = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TimingCategories.Count; ++i)
			{
				var s_CtrRef = new CtrRef<TimingViewCategory>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_TimingCategories.Reader.ReadUInt32()));
				p_Instance.TimingCategories.Add(s_CtrRef);
			}
			
			s_TimingCategories.Reader.Dispose();
		}

	}
}
