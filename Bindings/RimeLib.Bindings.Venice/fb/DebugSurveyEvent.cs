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
	[ContainerType(8, 40)]
	public class DebugSurveyEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable]
		public string PlayerName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, Blittable]
		public GUID SurveyMetricLink { get; set; }

		public static void Deserialize(DebugSurveyEvent p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PlayerName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SurveyMetricLink = new GUID(p_Reader);
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
