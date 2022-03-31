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
	public class ScoringData :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<ScoringTypeData> ScoringTypes { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<ScoringHandlerData> ScoringHandlers { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<ScoringBucketData> Buckets { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_ScoringTypes = p_EbxWriter.GetArrayWriter(ScoringTypes.GetType(), ScoringTypes.Count);
			p_Writer.Write(s_ScoringTypes.ArrayIndex);
			foreach (var s_Entry in ScoringTypes)
			{
				s_ScoringTypes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_ScoringHandlers = p_EbxWriter.GetArrayWriter(ScoringHandlers.GetType(), ScoringHandlers.Count);
			p_Writer.Write(s_ScoringHandlers.ArrayIndex);
			foreach (var s_Entry in ScoringHandlers)
			{
				s_ScoringHandlers.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Buckets = p_EbxWriter.GetArrayWriter(Buckets.GetType(), Buckets.Count);
			p_Writer.Write(s_Buckets.ArrayIndex);
			foreach (var s_Entry in Buckets)
			{
				s_Buckets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
