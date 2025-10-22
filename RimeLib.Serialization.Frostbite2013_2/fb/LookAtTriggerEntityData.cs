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
using fb.GameShared;
using fb.Entity;

namespace fb.SoldierShared;

[ContainerType(16, 144)]
public class LookAtTriggerEntityData
	: fb.GameShared.CharacterLookAtTriggerEntityData
{
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public CtrRef<SoldierWeaponUnlockAsset> SoldierWeapon { get; set; } = new();
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public uint ZoomLevel { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(SoldierWeapon));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ZoomLevel);
		p_Writer.WriteNullBytes(4);
	}
}

