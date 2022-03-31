///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class InputActionMapData :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public RefArray<InputActionsData> Actions { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public InputActionMapPlatform PlatformSpecific { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public InputActionMapSlot Slot { get; set; } = new();

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string CopyKeyBindingsFrom { get; set; } = string.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Actions = p_EbxWriter.GetArrayWriter(Actions.GetType(), Actions.Count);
			p_Writer.Write(s_Actions.ArrayIndex);
			foreach (var s_Entry in Actions)
			{
				s_Actions.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) PlatformSpecific);
			p_Writer.Write((int) Slot);
			p_Writer.Write(p_EbxWriter.WriteString(CopyKeyBindingsFrom));
		}
	}
}
