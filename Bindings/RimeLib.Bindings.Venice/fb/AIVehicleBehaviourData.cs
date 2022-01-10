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
	public class AIVehicleBehaviourData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12)]
		public List<string> Controls { get; set; } = new();

		[ContainerField(16)]
		public List<string> Behaviours { get; set; } = new();

		[ContainerField(20)]
		public List<string> Goals { get; set; } = new();

		[ContainerField(24)]
		public List<IntentData> Intents { get; set; } = new();

		public static void Deserialize(AIVehicleBehaviourData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Controls.Clear();
			(RimeReader Reader, uint Count) s_Controls = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Controls.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Controls.Reader.ReadUInt32());
				p_Instance.Controls.Add(s_Value);
			}
			
			s_Controls.Reader.Dispose();
			p_Instance.Behaviours.Clear();
			(RimeReader Reader, uint Count) s_Behaviours = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Behaviours.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Behaviours.Reader.ReadUInt32());
				p_Instance.Behaviours.Add(s_Value);
			}
			
			s_Behaviours.Reader.Dispose();
			p_Instance.Goals.Clear();
			(RimeReader Reader, uint Count) s_Goals = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Goals.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Goals.Reader.ReadUInt32());
				p_Instance.Goals.Add(s_Value);
			}
			
			s_Goals.Reader.Dispose();
			p_Instance.Intents.Clear();
			(RimeReader Reader, uint Count) s_Intents = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Intents.Count; ++i)
			{
				var s_Value = new IntentData();
				fb.IntentData.Deserialize(s_Value, s_Intents.Reader, p_Parser);
				p_Instance.Intents.Add(s_Value);
			}
			
			s_Intents.Reader.Dispose();
		}

	}
}
