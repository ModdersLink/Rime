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
	public class UINodePort : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable]
		public string InstanceName { get; set; } = string.Empty;

		[ContainerField(16)]
		public UIWidgetEventID Query { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool AllowManualRemove { get; set; }

		public static void Deserialize(UINodePort p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.InstanceName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Query = (UIWidgetEventID) p_Reader.ReadInt32();
			p_Instance.AllowManualRemove = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
