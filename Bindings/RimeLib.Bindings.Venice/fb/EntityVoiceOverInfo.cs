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
	public class EntityVoiceOverInfo : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverObject> VoiceOverType { get; set; } = new();

		[ContainerField(12)]
		public List<CtrRef<VoiceOverLabel>> Labels { get; set; } = new();

		public static void Deserialize(EntityVoiceOverInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.VoiceOverType.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Labels.Clear();
			(RimeReader Reader, uint Count) s_Labels = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Labels.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverLabel>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Labels.Reader.ReadUInt32()));
				p_Instance.Labels.Add(s_CtrRef);
			}
			
			s_Labels.Reader.Dispose();
		}

	}
}
