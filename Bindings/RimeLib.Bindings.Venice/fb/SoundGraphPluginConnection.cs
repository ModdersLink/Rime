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
	public class SoundGraphPluginConnection
	{
		[ContainerField(0)]
		public SoundGraphPluginConnectionType ConnectionType { get; set; } = new();
		
		[ContainerField(4)]
		public List<SoundGraphPluginConnectionParam> Parameters { get; set; } = new();
		
		[ContainerField(8)]
		public CtrRef<SoundBusData> Bus { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public sbyte VoiceIndex { get; set; }
		
		public static void Deserialize(SoundGraphPluginConnection p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ConnectionType = (SoundGraphPluginConnectionType) p_Reader.ReadInt32();
			p_Instance.Parameters.Clear();
			(RimeReader Reader, uint Count) s_Parameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Parameters.Count; ++i)
			{
				var s_Value = new SoundGraphPluginConnectionParam();
				fb.SoundGraphPluginConnectionParam.Deserialize(s_Value, s_Parameters.Reader, p_Parser);
				p_Instance.Parameters.Add(s_Value);
			}
			
			s_Parameters.Reader.Dispose();
			p_Instance.Bus.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.VoiceIndex = p_Reader.ReadSByte();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
