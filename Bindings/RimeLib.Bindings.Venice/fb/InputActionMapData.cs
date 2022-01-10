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
	public class InputActionMapData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<CtrRef<InputActionsData>> Actions { get; set; } = new();

		[ContainerField(12)]
		public InputActionMapPlatform PlatformSpecific { get; set; } = new();

		[ContainerField(16)]
		public InputActionMapSlot Slot { get; set; } = new();

		[ContainerField(20), LayoutImmutable]
		public string CopyKeyBindingsFrom { get; set; } = string.Empty;

		public static void Deserialize(InputActionMapData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Actions.Clear();
			(RimeReader Reader, uint Count) s_Actions = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Actions.Count; ++i)
			{
				var s_CtrRef = new CtrRef<InputActionsData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Actions.Reader.ReadUInt32()));
				p_Instance.Actions.Add(s_CtrRef);
			}
			
			s_Actions.Reader.Dispose();
			p_Instance.PlatformSpecific = (InputActionMapPlatform) p_Reader.ReadInt32();
			p_Instance.Slot = (InputActionMapSlot) p_Reader.ReadInt32();
			p_Instance.CopyKeyBindingsFrom = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}

	}
}
