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
	public class VoiceOverEvent : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12)]
		public List<CtrRef<VoiceOverNamedValue>> Parameters { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<VoiceOverLogicAsset> Owner { get; set; } = new();

		public static void Deserialize(VoiceOverEvent p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Parameters.Clear();
			(RimeReader Reader, uint Count) s_Parameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Parameters.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverNamedValue>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Parameters.Reader.ReadUInt32()));
				p_Instance.Parameters.Add(s_CtrRef);
			}
			
			s_Parameters.Reader.Dispose();
			p_Instance.Owner.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
