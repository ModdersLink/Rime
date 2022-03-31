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
	[ContainerType(4, 28)]
	public class UIComponentData :
		Asset
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string ShortName { get; set; } = string.Empty;

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<string> DataSources { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public UIUpdateType UpdateType { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int UpdatesPerSecond { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(ShortName));
			(RimeWriter Writer, uint ArrayIndex) s_DataSources = p_EbxWriter.GetArrayWriter(DataSources.GetType(), DataSources.Count);
			p_Writer.Write(s_DataSources.ArrayIndex);
			foreach (var s_Entry in DataSources)
			{
				s_DataSources.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write((int) UpdateType);
			p_Writer.Write(UpdatesPerSecond);
		}
	}
}
