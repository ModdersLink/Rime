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
	public class EntryInputActionMapsData :
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public int ActionMapSettingsScheme { get; set; }

		[ContainerField(16), JsonProperty(Order = 16)]
		public InputActionMapSlot DefaultInputActionMap { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<EntryInputActionMapData> InputActionMaps { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ActionMapSettingsScheme);
			p_Writer.Write((int) DefaultInputActionMap);
			(RimeWriter Writer, uint ArrayIndex) s_InputActionMaps = p_EbxWriter.GetArrayWriter(InputActionMaps.GetType(), InputActionMaps.Count);
			p_Writer.Write(s_InputActionMaps.ArrayIndex);
			foreach (var s_Entry in InputActionMaps)
			{
				s_InputActionMaps.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
