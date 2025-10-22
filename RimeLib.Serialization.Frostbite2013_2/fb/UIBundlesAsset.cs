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

namespace fb.UI;

[ContainerType(8, 48)]
public class UIBundlesAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<UIBundleAssetState> UIBundleAssetStateList { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<FontCollectionLookupEntry> FontCollectionLookups { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string RootMovieClipPath { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_UIBundleAssetStateList = p_EbxWriter.GetArrayWriter(UIBundleAssetStateList.GetType(), UIBundleAssetStateList.Count);
		p_Writer.Write(s_UIBundleAssetStateList.ArrayIndex);
		foreach (var s_Entry in UIBundleAssetStateList)
		{
			s_Entry.Serialize(s_UIBundleAssetStateList.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_FontCollectionLookups = p_EbxWriter.GetArrayWriter(FontCollectionLookups.GetType(), FontCollectionLookups.Count);
		p_Writer.Write(s_FontCollectionLookups.ArrayIndex);
		foreach (var s_Entry in FontCollectionLookups)
		{
			s_Entry.Serialize(s_FontCollectionLookups.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(RootMovieClipPath));
	}
}

