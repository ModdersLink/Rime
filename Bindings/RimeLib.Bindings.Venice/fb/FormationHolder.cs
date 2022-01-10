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
	public class FormationHolder : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<FormationData>> Formations { get; set; } = new();

		public static void Deserialize(FormationHolder p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Formations.Clear();
			(RimeReader Reader, uint Count) s_Formations = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Formations.Count; ++i)
			{
				var s_CtrRef = new CtrRef<FormationData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Formations.Reader.ReadUInt32()));
				p_Instance.Formations.Add(s_CtrRef);
			}
			
			s_Formations.Reader.Dispose();
		}

	}
}
