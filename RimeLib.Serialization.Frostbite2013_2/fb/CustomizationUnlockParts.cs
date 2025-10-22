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
public class CustomizationUnlockParts
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string UICategorySid { get; set; } = string.Empty;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public uint DefaultSelectionIndex { get; set; } = 0;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<UnlockAssetBase> SelectableUnlocks { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(UICategorySid));
		p_Writer.Write(DefaultSelectionIndex);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_SelectableUnlocks = p_EbxWriter.GetArrayWriter(SelectableUnlocks.GetType(), SelectableUnlocks.Count);
		p_Writer.Write(s_SelectableUnlocks.ArrayIndex);
		foreach (var s_Entry in SelectableUnlocks)
		{
			s_SelectableUnlocks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

