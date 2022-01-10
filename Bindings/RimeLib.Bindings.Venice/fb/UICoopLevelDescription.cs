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
	public class UICoopLevelDescription : 
		LevelDescriptionComponent
	{
		[ContainerField(8), LayoutImmutable]
		public string Debriefing { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, Blittable]
		public int DevTime { get; set; }

		[ContainerField(16)]
		public List<string> UnlockedByLevels { get; set; } = new();

		public static void Deserialize(UICoopLevelDescription p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Debriefing = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.DevTime = p_Reader.ReadInt32();
			p_Instance.UnlockedByLevels.Clear();
			(RimeReader Reader, uint Count) s_UnlockedByLevels = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UnlockedByLevels.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_UnlockedByLevels.Reader.ReadUInt32());
				p_Instance.UnlockedByLevels.Add(s_Value);
			}
			
			s_UnlockedByLevels.Reader.Dispose();
		}

	}
}
