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
	[ContainerType(4, 32)]
	public class RichPresenceData : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<RichPresencePresenceString>> PresenceModes { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<RichPresencePresenceString> DefaultMode { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<RichPresencePresenceString> InactiveMode { get; set; } = new();

		[ContainerField(24)]
		public List<CtrRef<RichPresenceContext>> Contexts { get; set; } = new();

		[ContainerField(28)]
		public List<RichPresenceProperty> Properties { get; set; } = new();

		public static void Deserialize(RichPresenceData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PresenceModes.Clear();
			(RimeReader Reader, uint Count) s_PresenceModes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PresenceModes.Count; ++i)
			{
				var s_CtrRef = new CtrRef<RichPresencePresenceString>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_PresenceModes.Reader.ReadUInt32()));
				p_Instance.PresenceModes.Add(s_CtrRef);
			}
			
			s_PresenceModes.Reader.Dispose();
			p_Instance.DefaultMode.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.InactiveMode.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Contexts.Clear();
			(RimeReader Reader, uint Count) s_Contexts = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Contexts.Count; ++i)
			{
				var s_CtrRef = new CtrRef<RichPresenceContext>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Contexts.Reader.ReadUInt32()));
				p_Instance.Contexts.Add(s_CtrRef);
			}
			
			s_Contexts.Reader.Dispose();
			p_Instance.Properties.Clear();
			(RimeReader Reader, uint Count) s_Properties = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Properties.Count; ++i)
			{
				var s_Value = new RichPresenceProperty();
				fb.RichPresenceProperty.Deserialize(s_Value, s_Properties.Reader, p_Parser);
				p_Instance.Properties.Add(s_Value);
			}
			
			s_Properties.Reader.Dispose();
		}

	}
}
