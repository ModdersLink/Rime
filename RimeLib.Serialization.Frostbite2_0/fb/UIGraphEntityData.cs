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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class UIGraphEntityData :
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<EventSpec> Events { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<UIGraphAsset> GraphAsset { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public UIGraphPriority GraphPriority { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public UIState State { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool PopPreviousGraph { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Events = p_EbxWriter.GetArrayWriter(Events.GetType(), Events.Count);
			p_Writer.Write(s_Events.ArrayIndex);
			foreach (var s_Entry in Events)
			{
				s_Entry.Serialize(s_Events.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(GraphAsset));
			p_Writer.Write((int) GraphPriority);
			p_Writer.Write((int) State);
			p_Writer.Write(PopPreviousGraph);
			p_Writer.WriteNullBytes(3);
		}
	}
}
