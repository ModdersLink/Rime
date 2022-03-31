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
	[ContainerType(4, 20)]
	public class UrgencyUserData :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<UrgencyUserData> Base { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public List<UrgencyModifierData> UrgencyModifiers { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<UrgencySetData> ModifierSets { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Base));
			(RimeWriter Writer, uint ArrayIndex) s_UrgencyModifiers = p_EbxWriter.GetArrayWriter(UrgencyModifiers.GetType(), UrgencyModifiers.Count);
			p_Writer.Write(s_UrgencyModifiers.ArrayIndex);
			foreach (var s_Entry in UrgencyModifiers)
			{
				s_Entry.Serialize(s_UrgencyModifiers.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ModifierSets = p_EbxWriter.GetArrayWriter(ModifierSets.GetType(), ModifierSets.Count);
			p_Writer.Write(s_ModifierSets.ArrayIndex);
			foreach (var s_Entry in ModifierSets)
			{
				s_ModifierSets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
