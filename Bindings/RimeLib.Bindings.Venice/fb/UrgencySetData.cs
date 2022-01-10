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
	public class UrgencySetData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12)]
		public List<UrgencyModifierData> UrgencyModifiers { get; set; } = new();

		public static void Deserialize(UrgencySetData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.UrgencyModifiers.Clear();
			(RimeReader Reader, uint Count) s_UrgencyModifiers = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UrgencyModifiers.Count; ++i)
			{
				var s_Value = new UrgencyModifierData();
				fb.UrgencyModifierData.Deserialize(s_Value, s_UrgencyModifiers.Reader, p_Parser);
				p_Instance.UrgencyModifiers.Add(s_Value);
			}
			
			s_UrgencyModifiers.Reader.Dispose();
		}

	}
}
