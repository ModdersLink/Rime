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
	public class UIItemDescription : 
		DataContainer
	{
		[ContainerField(8)]
		public List<uint> ItemIds { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public bool IgnoreBuild { get; set; }

		public static void Deserialize(UIItemDescription p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ItemIds.Clear();
			(RimeReader Reader, uint Count) s_ItemIds = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ItemIds.Count; ++i)
			{
				var s_Value = s_ItemIds.Reader.ReadUInt32();
				p_Instance.ItemIds.Add(s_Value);
			}
			
			s_ItemIds.Reader.Dispose();
			p_Instance.IgnoreBuild = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
