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
	public class VoiceOverObject : 
		VoiceOverNamedValue
	{
		[ContainerField(16)]
		public List<CtrRef<VoiceOverNamedValue>> Properties { get; set; } = new();

		public static void Deserialize(VoiceOverObject p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Properties.Clear();
			(RimeReader Reader, uint Count) s_Properties = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Properties.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverNamedValue>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Properties.Reader.ReadUInt32()));
				p_Instance.Properties.Add(s_CtrRef);
			}
			
			s_Properties.Reader.Dispose();
		}

	}
}
