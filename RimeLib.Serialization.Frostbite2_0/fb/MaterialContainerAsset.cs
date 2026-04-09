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
	public partial class MaterialContainerAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<MaterialContainerPair> _MaterialPairs = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<string> _MaterialNames = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_MaterialPairs = p_EbxWriter.GetArrayWriter(MaterialPairs.GetType(), MaterialPairs.Count);
			p_Writer.Write(s_MaterialPairs.ArrayIndex);
			foreach (var s_Entry in MaterialPairs)
			{
				s_MaterialPairs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_MaterialNames = p_EbxWriter.GetArrayWriter(MaterialNames.GetType(), MaterialNames.Count);
			p_Writer.Write(s_MaterialNames.ArrayIndex);
			foreach (var s_Entry in MaterialNames)
			{
				s_MaterialNames.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
		}
	}
}
