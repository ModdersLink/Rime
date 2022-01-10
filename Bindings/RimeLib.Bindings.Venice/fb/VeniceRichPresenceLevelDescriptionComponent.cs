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
	public class VeniceRichPresenceLevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		[ContainerField(8)]
		public CtrRef<RichPresencePresenceString> PresenceMode { get; set; } = new();

		[ContainerField(12)]
		public List<RichPresenceContextSetting> ContextValues { get; set; } = new();

		public static void Deserialize(VeniceRichPresenceLevelDescriptionComponent p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PresenceMode.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ContextValues.Clear();
			(RimeReader Reader, uint Count) s_ContextValues = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ContextValues.Count; ++i)
			{
				var s_Value = new RichPresenceContextSetting();
				fb.RichPresenceContextSetting.Deserialize(s_Value, s_ContextValues.Reader, p_Parser);
				p_Instance.ContextValues.Add(s_Value);
			}
			
			s_ContextValues.Reader.Dispose();
		}

	}
}
