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
	[ContainerType(8, 64)]
	public class SurveyEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable]
		public string SurveyName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, Blittable]
		public int AnswerQuestion1 { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public int AnswerQuestion2 { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public int AnswerQuestion3 { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public int AnswerQuestion4 { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public int AnswerQuestion5 { get; set; }

		[ContainerField(40), LayoutImmutable]
		public string FreeTextField { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable, Blittable]
		public GUID SurveyMetricLink { get; set; }

		public static void Deserialize(SurveyEvent p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SurveyName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.AnswerQuestion1 = p_Reader.ReadInt32();
			p_Instance.AnswerQuestion2 = p_Reader.ReadInt32();
			p_Instance.AnswerQuestion3 = p_Reader.ReadInt32();
			p_Instance.AnswerQuestion4 = p_Reader.ReadInt32();
			p_Instance.AnswerQuestion5 = p_Reader.ReadInt32();
			p_Instance.FreeTextField = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SurveyMetricLink = new GUID(p_Reader);
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
