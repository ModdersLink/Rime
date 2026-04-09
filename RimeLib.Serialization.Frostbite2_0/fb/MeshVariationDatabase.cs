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
	[ContainerType(4, 20)]
	public partial class MeshVariationDatabase :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<MeshVariationDatabaseEntry> _Entries = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<MeshVariationDatabaseEntry> _RedirectEntries = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Entries = p_EbxWriter.GetArrayWriter(Entries.GetType(), Entries.Count);
			p_Writer.Write(s_Entries.ArrayIndex);
			foreach (var s_Entry in Entries)
			{
				s_Entries.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_RedirectEntries = p_EbxWriter.GetArrayWriter(RedirectEntries.GetType(), RedirectEntries.Count);
			p_Writer.Write(s_RedirectEntries.ArrayIndex);
			foreach (var s_Entry in RedirectEntries)
			{
				s_RedirectEntries.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
