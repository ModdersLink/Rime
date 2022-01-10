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
	public class UIGraphEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public List<EventSpec> Events { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<UIGraphAsset> GraphAsset { get; set; } = new();

		[ContainerField(20)]
		public UIGraphPriority GraphPriority { get; set; } = new();

		[ContainerField(24)]
		public UIState State { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool PopPreviousGraph { get; set; }

		public static void Deserialize(UIGraphEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Events.Clear();
			(RimeReader Reader, uint Count) s_Events = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Events.Count; ++i)
			{
				var s_Value = new EventSpec();
				fb.EventSpec.Deserialize(s_Value, s_Events.Reader, p_Parser);
				p_Instance.Events.Add(s_Value);
			}
			
			s_Events.Reader.Dispose();
			p_Instance.GraphAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.GraphPriority = (UIGraphPriority) p_Reader.ReadInt32();
			p_Instance.State = (UIState) p_Reader.ReadInt32();
			p_Instance.PopPreviousGraph = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
