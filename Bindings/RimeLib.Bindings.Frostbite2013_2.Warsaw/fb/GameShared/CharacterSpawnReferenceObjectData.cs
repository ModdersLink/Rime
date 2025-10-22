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

namespace fb.GameShared;

[ContainerType(16, 400)]
public class CharacterSpawnReferenceObjectData
	: fb.GameShared.SpawnReferenceObjectData
{
	public CharacterSpawnReferenceObjectData()
	{
		//SpawnReferenceObjectData
		TryToSpawnOutOfSight = true;
	}
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public uint VehicleEntryIndex { get; set; } = 0;
	
	[ContainerField(0x178), JsonProperty(Order = 376)]
	public CtrRef<CharacterSpawnTemplateData> Template { get; set; } = new();
	
	[ContainerField(0x180), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
	public float HumanTargetPreference { get; set; } = -1.000f;
	
	[ContainerField(0x184), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
	public int MenuShowOrder { get; set; } = 0;
	
	[ContainerField(0x188), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
	public bool AllowFallbackOnNextAvailabeVehicleEntry { get; set; } = false;
	
	[ContainerField(0x189), LayoutImmutable, Blittable, JsonProperty(Order = 393)]
	public bool SpawnVisible { get; set; } = true;
	
	[ContainerField(0x18a), LayoutImmutable, Blittable, JsonProperty(Order = 394)]
	public bool IsTarget { get; set; } = true;
	
	[ContainerField(0x18b), LayoutImmutable, Blittable, JsonProperty(Order = 395)]
	public bool AffectMinimapPosition { get; set; } = true;
	
	[ContainerField(0x18c), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
	public bool ShowAsLabelOnly { get; set; } = false;
	
	[ContainerField(0x18d), LayoutImmutable, Blittable, JsonProperty(Order = 397)]
	public bool ShowInMenu { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(VehicleEntryIndex);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Template));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(HumanTargetPreference);
		p_Writer.Write(MenuShowOrder);
		p_Writer.Write(AllowFallbackOnNextAvailabeVehicleEntry);
		p_Writer.Write(SpawnVisible);
		p_Writer.Write(IsTarget);
		p_Writer.Write(AffectMinimapPosition);
		p_Writer.Write(ShowAsLabelOnly);
		p_Writer.Write(ShowInMenu);
		p_Writer.WriteNullBytes(2);
	}
}

