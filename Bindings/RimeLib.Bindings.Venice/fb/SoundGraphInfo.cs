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
	public class SoundGraphInfo
	{
		[ContainerField(0)]
		public List<SoundGraphVoiceInfo> Voices { get; set; } = new();
		
		[ContainerField(4)]
		public List<SoundGraphLinkedPluginAttribute> LinkedPluginAttributes { get; set; } = new();
		
		[ContainerField(8)]
		public List<SoundGraphPluginConnection> Connections { get; set; } = new();
		
		[ContainerField(12)]
		public List<SoundGraphPluginConstructParam> ConstructParams { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint PluginsParamCount { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint PluginCount { get; set; }
		
		public static void Deserialize(SoundGraphInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Voices.Clear();
			(RimeReader Reader, uint Count) s_Voices = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Voices.Count; ++i)
			{
				var s_Value = new SoundGraphVoiceInfo();
				fb.SoundGraphVoiceInfo.Deserialize(s_Value, s_Voices.Reader, p_Parser);
				p_Instance.Voices.Add(s_Value);
			}
			
			s_Voices.Reader.Dispose();
			p_Instance.LinkedPluginAttributes.Clear();
			(RimeReader Reader, uint Count) s_LinkedPluginAttributes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LinkedPluginAttributes.Count; ++i)
			{
				var s_Value = new SoundGraphLinkedPluginAttribute();
				fb.SoundGraphLinkedPluginAttribute.Deserialize(s_Value, s_LinkedPluginAttributes.Reader, p_Parser);
				p_Instance.LinkedPluginAttributes.Add(s_Value);
			}
			
			s_LinkedPluginAttributes.Reader.Dispose();
			p_Instance.Connections.Clear();
			(RimeReader Reader, uint Count) s_Connections = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Connections.Count; ++i)
			{
				var s_Value = new SoundGraphPluginConnection();
				fb.SoundGraphPluginConnection.Deserialize(s_Value, s_Connections.Reader, p_Parser);
				p_Instance.Connections.Add(s_Value);
			}
			
			s_Connections.Reader.Dispose();
			p_Instance.ConstructParams.Clear();
			(RimeReader Reader, uint Count) s_ConstructParams = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ConstructParams.Count; ++i)
			{
				var s_Value = new SoundGraphPluginConstructParam();
				fb.SoundGraphPluginConstructParam.Deserialize(s_Value, s_ConstructParams.Reader, p_Parser);
				p_Instance.ConstructParams.Add(s_Value);
			}
			
			s_ConstructParams.Reader.Dispose();
			p_Instance.PluginsParamCount = p_Reader.ReadUInt32();
			p_Instance.PluginCount = p_Reader.ReadUInt32();
		}
	}
}
