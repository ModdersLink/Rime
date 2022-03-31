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
	public class EloParameters :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public List<EloFunctionPoint> KWinner { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<EloFunctionPoint> KLoser { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<EloFunctionPoint> KNewbie { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<EloFunctionPoint> KCompetitor { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public List<EloExpectedFunctionPoint> Expected { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_KWinner = p_EbxWriter.GetArrayWriter(KWinner.GetType(), KWinner.Count);
			p_Writer.Write(s_KWinner.ArrayIndex);
			foreach (var s_Entry in KWinner)
			{
				s_Entry.Serialize(s_KWinner.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_KLoser = p_EbxWriter.GetArrayWriter(KLoser.GetType(), KLoser.Count);
			p_Writer.Write(s_KLoser.ArrayIndex);
			foreach (var s_Entry in KLoser)
			{
				s_Entry.Serialize(s_KLoser.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_KNewbie = p_EbxWriter.GetArrayWriter(KNewbie.GetType(), KNewbie.Count);
			p_Writer.Write(s_KNewbie.ArrayIndex);
			foreach (var s_Entry in KNewbie)
			{
				s_Entry.Serialize(s_KNewbie.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_KCompetitor = p_EbxWriter.GetArrayWriter(KCompetitor.GetType(), KCompetitor.Count);
			p_Writer.Write(s_KCompetitor.ArrayIndex);
			foreach (var s_Entry in KCompetitor)
			{
				s_Entry.Serialize(s_KCompetitor.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_Expected = p_EbxWriter.GetArrayWriter(Expected.GetType(), Expected.Count);
			p_Writer.Write(s_Expected.ArrayIndex);
			foreach (var s_Entry in Expected)
			{
				s_Entry.Serialize(s_Expected.Writer, p_EbxWriter);
			}
		}
	}
}
