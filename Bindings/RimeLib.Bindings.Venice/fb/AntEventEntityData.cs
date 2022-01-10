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
	[ContainerType(16, 112)]
	public class AntEventEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public List<AntEventData> OnEnterEvents { get; set; } = new();

		[ContainerField(100)]
		public List<AntEventData> OnUpdateEvents { get; set; } = new();

		[ContainerField(104)]
		public List<AntEventData> OnLeaveEvents { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool SendAsPlayerEvent { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable]
		public bool AutoActivate { get; set; }

		public static void Deserialize(AntEventEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.OnEnterEvents.Clear();
			(RimeReader Reader, uint Count) s_OnEnterEvents = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_OnEnterEvents.Count; ++i)
			{
				var s_Value = new AntEventData();
				fb.AntEventData.Deserialize(s_Value, s_OnEnterEvents.Reader, p_Parser);
				p_Instance.OnEnterEvents.Add(s_Value);
			}
			
			s_OnEnterEvents.Reader.Dispose();
			p_Instance.OnUpdateEvents.Clear();
			(RimeReader Reader, uint Count) s_OnUpdateEvents = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_OnUpdateEvents.Count; ++i)
			{
				var s_Value = new AntEventData();
				fb.AntEventData.Deserialize(s_Value, s_OnUpdateEvents.Reader, p_Parser);
				p_Instance.OnUpdateEvents.Add(s_Value);
			}
			
			s_OnUpdateEvents.Reader.Dispose();
			p_Instance.OnLeaveEvents.Clear();
			(RimeReader Reader, uint Count) s_OnLeaveEvents = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_OnLeaveEvents.Count; ++i)
			{
				var s_Value = new AntEventData();
				fb.AntEventData.Deserialize(s_Value, s_OnLeaveEvents.Reader, p_Parser);
				p_Instance.OnLeaveEvents.Add(s_Value);
			}
			
			s_OnLeaveEvents.Reader.Dispose();
			p_Instance.SendAsPlayerEvent = p_Reader.ReadBool();
			p_Instance.AutoActivate = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
