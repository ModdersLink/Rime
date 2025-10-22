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

using fb.Ant;
using fb.GameShared;
using fb.Core;
using fb.Entity;

namespace fb.SoldierShared;

[ContainerType(8, 48)]
public class SoldierWeaponBlueprintBundle
	: fb.GameShared.BlueprintBundle
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<AntStateAsset> AntStateAssets { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_AntStateAssets = p_EbxWriter.GetArrayWriter(AntStateAssets.GetType(), AntStateAssets.Count);
		p_Writer.Write(s_AntStateAssets.ArrayIndex);
		foreach (var s_Entry in AntStateAssets)
		{
			s_AntStateAssets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

