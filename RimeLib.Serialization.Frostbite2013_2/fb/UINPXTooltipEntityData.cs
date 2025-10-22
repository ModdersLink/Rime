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
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 72)]
public class UINPXTooltipEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string TooltipTitle { get; set; } = string.Empty;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<UINPXLine> NPXLines { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float Timer { get; set; } = -1.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public uint LayoutIndex { get; set; } = 0;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string SharedID { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool RunOnce { get; set; } = false;
	
	[ContainerField(0x41), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
	public bool ShowCloseButton { get; set; } = false;
	
	[ContainerField(0x42), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
	public bool SaveWhenClosed { get; set; } = true;
	
	[ContainerField(0x43), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
	public bool UsePresetLayout { get; set; } = false;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public bool EatAllInput { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(TooltipTitle));
		(RimeWriter Writer, uint ArrayIndex) s_NPXLines = p_EbxWriter.GetArrayWriter(NPXLines.GetType(), NPXLines.Count);
		p_Writer.Write(s_NPXLines.ArrayIndex);
		foreach (var s_Entry in NPXLines)
		{
			s_NPXLines.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Timer);
		p_Writer.Write(LayoutIndex);
		p_Writer.Write(p_EbxWriter.WriteString(SharedID));
		p_Writer.Write(RunOnce);
		p_Writer.Write(ShowCloseButton);
		p_Writer.Write(SaveWhenClosed);
		p_Writer.Write(UsePresetLayout);
		p_Writer.Write(EatAllInput);
		p_Writer.WriteNullBytes(3);
	}
}

