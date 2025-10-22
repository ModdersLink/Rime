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
public class WeaponProjectileModifier
	: fb.GameShared.WeaponModifierBase
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<ProjectileEntityData> ProjectileData { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int MaxCount { get; set; } = -1;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(ProjectileData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MaxCount);
		p_Writer.WriteNullBytes(4);
	}
}

