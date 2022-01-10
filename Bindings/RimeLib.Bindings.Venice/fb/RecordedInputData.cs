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
	[ContainerType(4, 16)]
	public class RecordedInputData : 
		Asset
	{
		[ContainerField(12)]
		public List<InputRecorderTrackData> TrackData { get; set; } = new();

		public static void Deserialize(RecordedInputData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TrackData.Clear();
			(RimeReader Reader, uint Count) s_TrackData = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TrackData.Count; ++i)
			{
				var s_Value = new InputRecorderTrackData();
				fb.InputRecorderTrackData.Deserialize(s_Value, s_TrackData.Reader, p_Parser);
				p_Instance.TrackData.Add(s_Value);
			}
			
			s_TrackData.Reader.Dispose();
		}

	}
}
