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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 48)]
	public partial class PersistentValueTemplate :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private PersistentValueTemplateData _Data = new();

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private RefArray<AbstractPersistentStatRef> _DerivedFormulaRefs = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
