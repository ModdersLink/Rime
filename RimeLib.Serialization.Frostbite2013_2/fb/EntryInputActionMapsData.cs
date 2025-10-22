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

using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 40)]
public class EntryInputActionMapsData
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public int ActionMapSettingsScheme { get; set; } = 0;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public InputActionMapSlot DefaultInputActionMap { get; set; } = InputActionMapSlot.InputActionMapSlot_Undefined;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
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
		p_Writer.WriteNullBytes(4);
	}
}

