///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class EloParameters
	{
		[ContainerField(0)]
		public List<EloFunctionPoint> KWinner { get; set; } = new();
		
		[ContainerField(4)]
		public List<EloFunctionPoint> KLoser { get; set; } = new();
		
		[ContainerField(8)]
		public List<EloFunctionPoint> KNewbie { get; set; } = new();
		
		[ContainerField(12)]
		public List<EloFunctionPoint> KCompetitor { get; set; } = new();
		
		[ContainerField(16)]
		public List<EloExpectedFunctionPoint> Expected { get; set; } = new();
		
		public static void Deserialize(EloParameters p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.KWinner.Clear();
			(RimeReader Reader, uint Count) s_KWinner = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_KWinner.Count; ++i)
			{
				var s_Value = new EloFunctionPoint();
				fb.EloFunctionPoint.Deserialize(s_Value, s_KWinner.Reader, p_Parser);
				p_Instance.KWinner.Add(s_Value);
			}
			
			s_KWinner.Reader.Dispose();
			p_Instance.KLoser.Clear();
			(RimeReader Reader, uint Count) s_KLoser = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_KLoser.Count; ++i)
			{
				var s_Value = new EloFunctionPoint();
				fb.EloFunctionPoint.Deserialize(s_Value, s_KLoser.Reader, p_Parser);
				p_Instance.KLoser.Add(s_Value);
			}
			
			s_KLoser.Reader.Dispose();
			p_Instance.KNewbie.Clear();
			(RimeReader Reader, uint Count) s_KNewbie = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_KNewbie.Count; ++i)
			{
				var s_Value = new EloFunctionPoint();
				fb.EloFunctionPoint.Deserialize(s_Value, s_KNewbie.Reader, p_Parser);
				p_Instance.KNewbie.Add(s_Value);
			}
			
			s_KNewbie.Reader.Dispose();
			p_Instance.KCompetitor.Clear();
			(RimeReader Reader, uint Count) s_KCompetitor = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_KCompetitor.Count; ++i)
			{
				var s_Value = new EloFunctionPoint();
				fb.EloFunctionPoint.Deserialize(s_Value, s_KCompetitor.Reader, p_Parser);
				p_Instance.KCompetitor.Add(s_Value);
			}
			
			s_KCompetitor.Reader.Dispose();
			p_Instance.Expected.Clear();
			(RimeReader Reader, uint Count) s_Expected = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Expected.Count; ++i)
			{
				var s_Value = new EloExpectedFunctionPoint();
				fb.EloExpectedFunctionPoint.Deserialize(s_Value, s_Expected.Reader, p_Parser);
				p_Instance.Expected.Add(s_Value);
			}
			
			s_Expected.Reader.Dispose();
		}
	}
}
