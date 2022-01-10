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
	[ContainerType(4, 68)]
	public class SoundGraphData : 
		AudioGraphData
	{
		[ContainerField(28)]
		public SoundGraphInfo Info { get; set; } = new();

		[ContainerField(52)]
		public List<CtrRef<AudioGraphParameter>> InputParameters { get; set; } = new();

		[ContainerField(56)]
		public List<CtrRef<AudioGraphParameter>> OutputParameters { get; set; } = new();

		[ContainerField(60)]
		public List<CtrRef<AudioGraphEvent>> InputEvents { get; set; } = new();

		[ContainerField(64)]
		public List<CtrRef<AudioGraphEvent>> OutputEvents { get; set; } = new();

		public static void Deserialize(SoundGraphData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.SoundGraphInfo.Deserialize(p_Instance.Info, p_Reader, p_Parser);
			p_Instance.InputParameters.Clear();
			(RimeReader Reader, uint Count) s_InputParameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InputParameters.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AudioGraphParameter>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_InputParameters.Reader.ReadUInt32()));
				p_Instance.InputParameters.Add(s_CtrRef);
			}
			
			s_InputParameters.Reader.Dispose();
			p_Instance.OutputParameters.Clear();
			(RimeReader Reader, uint Count) s_OutputParameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_OutputParameters.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AudioGraphParameter>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_OutputParameters.Reader.ReadUInt32()));
				p_Instance.OutputParameters.Add(s_CtrRef);
			}
			
			s_OutputParameters.Reader.Dispose();
			p_Instance.InputEvents.Clear();
			(RimeReader Reader, uint Count) s_InputEvents = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InputEvents.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AudioGraphEvent>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_InputEvents.Reader.ReadUInt32()));
				p_Instance.InputEvents.Add(s_CtrRef);
			}
			
			s_InputEvents.Reader.Dispose();
			p_Instance.OutputEvents.Clear();
			(RimeReader Reader, uint Count) s_OutputEvents = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_OutputEvents.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AudioGraphEvent>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_OutputEvents.Reader.ReadUInt32()));
				p_Instance.OutputEvents.Add(s_CtrRef);
			}
			
			s_OutputEvents.Reader.Dispose();
		}

	}
}
