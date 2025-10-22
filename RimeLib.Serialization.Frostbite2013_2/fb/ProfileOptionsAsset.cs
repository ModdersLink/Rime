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

[ContainerType(8, 104)]
public class ProfileOptionsAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string FileName { get; set; } = @"ProfileOptions";
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string ContentName { get; set; } = @"SaveData";
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint FileSize { get; set; } = 16000;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<ProfileOptionData> Options { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RefArray<ProfileOptionData> OptionsPs3 { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public RefArray<ProfileOptionData> OptionsXenon { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public RefArray<ProfileOptionData> OptionsGen4a { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public RefArray<ProfileOptionData> OptionsGen4b { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public RefArray<ProfileOptionData> OptionsWin { get; set; } = new();
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public bool AutoSaveOnQuit { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(FileName));
		p_Writer.Write(p_EbxWriter.WriteString(ContentName));
		p_Writer.Write(FileSize);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Options = p_EbxWriter.GetArrayWriter(Options.GetType(), Options.Count);
		p_Writer.Write(s_Options.ArrayIndex);
		foreach (var s_Entry in Options)
		{
			s_Options.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OptionsPs3 = p_EbxWriter.GetArrayWriter(OptionsPs3.GetType(), OptionsPs3.Count);
		p_Writer.Write(s_OptionsPs3.ArrayIndex);
		foreach (var s_Entry in OptionsPs3)
		{
			s_OptionsPs3.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OptionsXenon = p_EbxWriter.GetArrayWriter(OptionsXenon.GetType(), OptionsXenon.Count);
		p_Writer.Write(s_OptionsXenon.ArrayIndex);
		foreach (var s_Entry in OptionsXenon)
		{
			s_OptionsXenon.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OptionsGen4a = p_EbxWriter.GetArrayWriter(OptionsGen4a.GetType(), OptionsGen4a.Count);
		p_Writer.Write(s_OptionsGen4a.ArrayIndex);
		foreach (var s_Entry in OptionsGen4a)
		{
			s_OptionsGen4a.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OptionsGen4b = p_EbxWriter.GetArrayWriter(OptionsGen4b.GetType(), OptionsGen4b.Count);
		p_Writer.Write(s_OptionsGen4b.ArrayIndex);
		foreach (var s_Entry in OptionsGen4b)
		{
			s_OptionsGen4b.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OptionsWin = p_EbxWriter.GetArrayWriter(OptionsWin.GetType(), OptionsWin.Count);
		p_Writer.Write(s_OptionsWin.ArrayIndex);
		foreach (var s_Entry in OptionsWin)
		{
			s_OptionsWin.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AutoSaveOnQuit);
		p_Writer.WriteNullBytes(7);
	}
}

