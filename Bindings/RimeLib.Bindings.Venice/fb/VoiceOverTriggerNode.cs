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
	[ContainerType(4, 24)]
	public class VoiceOverTriggerNode : 
		VoiceOverStructureNode
	{
		[ContainerField(12)]
		public List<CtrRef<VoiceOverTriggerParameter>> Parameters { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float Delay { get; set; }

		[ContainerField(20)]
		public CtrRef<VoiceOverEvent> Event { get; set; } = new();

		public static void Deserialize(VoiceOverTriggerNode p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Parameters.Clear();
			(RimeReader Reader, uint Count) s_Parameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Parameters.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverTriggerParameter>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Parameters.Reader.ReadUInt32()));
				p_Instance.Parameters.Add(s_CtrRef);
			}
			
			s_Parameters.Reader.Dispose();
			p_Instance.Delay = p_Reader.ReadSingle();
			p_Instance.Event.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
