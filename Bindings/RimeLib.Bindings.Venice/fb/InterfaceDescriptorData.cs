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
	[ContainerType(4, 28)]
	public class InterfaceDescriptorData : 
		DynamicDataContainer
	{
		[ContainerField(12)]
		public List<DynamicEvent> InputEvents { get; set; } = new();

		[ContainerField(16)]
		public List<DynamicEvent> OutputEvents { get; set; } = new();

		[ContainerField(20)]
		public List<DynamicLink> InputLinks { get; set; } = new();

		[ContainerField(24)]
		public List<DynamicLink> OutputLinks { get; set; } = new();

		public static void Deserialize(InterfaceDescriptorData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.InputEvents.Clear();
			(RimeReader Reader, uint Count) s_InputEvents = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InputEvents.Count; ++i)
			{
				var s_Value = new DynamicEvent();
				fb.DynamicEvent.Deserialize(s_Value, s_InputEvents.Reader, p_Parser);
				p_Instance.InputEvents.Add(s_Value);
			}
			
			s_InputEvents.Reader.Dispose();
			p_Instance.OutputEvents.Clear();
			(RimeReader Reader, uint Count) s_OutputEvents = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_OutputEvents.Count; ++i)
			{
				var s_Value = new DynamicEvent();
				fb.DynamicEvent.Deserialize(s_Value, s_OutputEvents.Reader, p_Parser);
				p_Instance.OutputEvents.Add(s_Value);
			}
			
			s_OutputEvents.Reader.Dispose();
			p_Instance.InputLinks.Clear();
			(RimeReader Reader, uint Count) s_InputLinks = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InputLinks.Count; ++i)
			{
				var s_Value = new DynamicLink();
				fb.DynamicLink.Deserialize(s_Value, s_InputLinks.Reader, p_Parser);
				p_Instance.InputLinks.Add(s_Value);
			}
			
			s_InputLinks.Reader.Dispose();
			p_Instance.OutputLinks.Clear();
			(RimeReader Reader, uint Count) s_OutputLinks = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_OutputLinks.Count; ++i)
			{
				var s_Value = new DynamicLink();
				fb.DynamicLink.Deserialize(s_Value, s_OutputLinks.Reader, p_Parser);
				p_Instance.OutputLinks.Add(s_Value);
			}
			
			s_OutputLinks.Reader.Dispose();
		}

	}
}
