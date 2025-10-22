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

[ContainerType(8, 32)]
public class SoldierWeaponCustomizationAsset
	: fb.Entity.DataContainerPolicyAsset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<CustomizationTable> Customization { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Customization));
		p_Writer.WriteNullBytes(4);
	}
}

