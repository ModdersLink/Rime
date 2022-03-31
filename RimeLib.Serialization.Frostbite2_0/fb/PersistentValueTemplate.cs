///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 48)]
	public class PersistentValueTemplate :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public PersistentValueTemplateData Data { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public RefArray<AbstractPersistentStatRef> DerivedFormulaRefs { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Data.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_DerivedFormulaRefs = p_EbxWriter.GetArrayWriter(DerivedFormulaRefs.GetType(), DerivedFormulaRefs.Count);
			p_Writer.Write(s_DerivedFormulaRefs.ArrayIndex);
			foreach (var s_Entry in DerivedFormulaRefs)
			{
				s_DerivedFormulaRefs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
