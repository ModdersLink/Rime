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

using fb.Audio;
using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 88)]
public class LaserDesignatorData
	: fb.GameShared.LockingWeaponData
{
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float PostLockTime { get; set; } = 1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float BomberTime { get; set; } = 3.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float BombWarnTime { get; set; } = 7.000f;
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<SoundAsset> BomberSound { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(PostLockTime);
		p_Writer.Write(BomberTime);
		p_Writer.Write(BombWarnTime);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(BomberSound));
		p_Writer.WriteNullBytes(4);
	}
}

