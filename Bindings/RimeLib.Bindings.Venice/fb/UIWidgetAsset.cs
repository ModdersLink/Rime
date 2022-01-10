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
	public class UIWidgetAsset : 
		UIAsset
	{
		[ContainerField(12)]
		public List<WidgetEventQueryPair> WidgetEvents { get; set; } = new();

		public static void Deserialize(UIWidgetAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.WidgetEvents.Clear();
			(RimeReader Reader, uint Count) s_WidgetEvents = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_WidgetEvents.Count; ++i)
			{
				var s_Value = new WidgetEventQueryPair();
				fb.WidgetEventQueryPair.Deserialize(s_Value, s_WidgetEvents.Reader, p_Parser);
				p_Instance.WidgetEvents.Add(s_Value);
			}
			
			s_WidgetEvents.Reader.Dispose();
		}

	}
}
