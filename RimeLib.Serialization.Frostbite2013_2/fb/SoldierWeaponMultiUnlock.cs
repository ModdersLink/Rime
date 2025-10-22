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

using fb.GameShared;
using fb.Entity;
using fb.Core;

namespace fb.SoldierShared;

[ContainerType(8, 40)]
public class SoldierWeaponMultiUnlock
	: fb.GameShared.UnlockUserDataBase
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<UnlockAssetBase> First { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<UnlockAssetPair> UnlockAssetPairs { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(First));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_UnlockAssetPairs = p_EbxWriter.GetArrayWriter(UnlockAssetPairs.GetType(), UnlockAssetPairs.Count);
		p_Writer.Write(s_UnlockAssetPairs.ArrayIndex);
		foreach (var s_Entry in UnlockAssetPairs)
		{
			s_Entry.Serialize(s_UnlockAssetPairs.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

