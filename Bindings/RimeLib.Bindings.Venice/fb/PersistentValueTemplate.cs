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
	[ContainerType(4, 48)]
	public class PersistentValueTemplate : 
		DataContainer
	{
		[ContainerField(8)]
		public PersistentValueTemplateData Data { get; set; } = new();

		[ContainerField(44)]
		public List<CtrRef<AbstractPersistentStatRef>> DerivedFormulaRefs { get; set; } = new();

		public static void Deserialize(PersistentValueTemplate p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.PersistentValueTemplateData.Deserialize(p_Instance.Data, p_Reader, p_Parser);
			p_Instance.DerivedFormulaRefs.Clear();
			(RimeReader Reader, uint Count) s_DerivedFormulaRefs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_DerivedFormulaRefs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AbstractPersistentStatRef>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_DerivedFormulaRefs.Reader.ReadUInt32()));
				p_Instance.DerivedFormulaRefs.Add(s_CtrRef);
			}
			
			s_DerivedFormulaRefs.Reader.Dispose();
		}

	}
}
