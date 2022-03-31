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
	[ContainerType(4, 16)]
	public class BlueprintBundleMetadataContainer :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<BlueprintContainerItem> Items { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Items = p_EbxWriter.GetArrayWriter(Items.GetType(), Items.Count);
			p_Writer.Write(s_Items.ArrayIndex);
			foreach (var s_Entry in Items)
			{
				s_Items.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
