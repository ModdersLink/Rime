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
	public class EntryInputActionMapsData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public int ActionMapSettingsScheme { get; set; }

		[ContainerField(16)]
		public InputActionMapSlot DefaultInputActionMap { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<EntryInputActionMapData>> InputActionMaps { get; set; } = new();

		public static void Deserialize(EntryInputActionMapsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ActionMapSettingsScheme = p_Reader.ReadInt32();
			p_Instance.DefaultInputActionMap = (InputActionMapSlot) p_Reader.ReadInt32();
			p_Instance.InputActionMaps.Clear();
			(RimeReader Reader, uint Count) s_InputActionMaps = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InputActionMaps.Count; ++i)
			{
				var s_CtrRef = new CtrRef<EntryInputActionMapData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_InputActionMaps.Reader.ReadUInt32()));
				p_Instance.InputActionMaps.Add(s_CtrRef);
			}
			
			s_InputActionMaps.Reader.Dispose();
		}

	}
}
