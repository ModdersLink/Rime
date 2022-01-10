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
	public class MeshVariationDatabase : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<MeshVariationDatabaseEntry>> Entries { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<MeshVariationDatabaseEntry>> RedirectEntries { get; set; } = new();

		public static void Deserialize(MeshVariationDatabase p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Entries.Clear();
			(RimeReader Reader, uint Count) s_Entries = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Entries.Count; ++i)
			{
				var s_CtrRef = new CtrRef<MeshVariationDatabaseEntry>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Entries.Reader.ReadUInt32()));
				p_Instance.Entries.Add(s_CtrRef);
			}
			
			s_Entries.Reader.Dispose();
			p_Instance.RedirectEntries.Clear();
			(RimeReader Reader, uint Count) s_RedirectEntries = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_RedirectEntries.Count; ++i)
			{
				var s_CtrRef = new CtrRef<MeshVariationDatabaseEntry>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_RedirectEntries.Reader.ReadUInt32()));
				p_Instance.RedirectEntries.Add(s_CtrRef);
			}
			
			s_RedirectEntries.Reader.Dispose();
		}

	}
}
