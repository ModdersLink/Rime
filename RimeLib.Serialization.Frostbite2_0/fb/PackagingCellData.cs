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
	[ContainerType(4, 24)]
	public class PackagingCellData :
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<PackagingRule> Rules { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<PackagingCellData> Targets { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public List<Vec2> Shape { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Rules = p_EbxWriter.GetArrayWriter(Rules.GetType(), Rules.Count);
			p_Writer.Write(s_Rules.ArrayIndex);
			foreach (var s_Entry in Rules)
			{
				s_Rules.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Targets = p_EbxWriter.GetArrayWriter(Targets.GetType(), Targets.Count);
			p_Writer.Write(s_Targets.ArrayIndex);
			foreach (var s_Entry in Targets)
			{
				s_Targets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Shape = p_EbxWriter.GetArrayWriter(Shape.GetType(), Shape.Count);
			p_Writer.Write(s_Shape.ArrayIndex);
			foreach (var s_Entry in Shape)
			{
				s_Entry.Serialize(s_Shape.Writer, p_EbxWriter);
			}
		}
	}
}
