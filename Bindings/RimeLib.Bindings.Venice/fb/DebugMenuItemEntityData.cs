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
	[ContainerType(16, 112)]
	public class DebugMenuItemEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public DebugMenuItemType ItemType { get; set; } = new();

		[ContainerField(100), LayoutImmutable]
		public string Text { get; set; } = string.Empty;

		public static void Deserialize(DebugMenuItemEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ItemType = (DebugMenuItemType) p_Reader.ReadInt32();
			p_Instance.Text = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
