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
using fb.Entity;
using fb.Physics;

namespace fb.GameShared;

[ContainerType(16, 224)]
public class CharacterEntityData
	: fb.GameShared.ControllableEntityData
{
	public CharacterEntityData()
	{
		//ControllableEntityData
		ResetTeamOnLastPlayerExits = false;
	}
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float MaxHealth { get; set; } = 100.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public PersonViewMode DefaultViewMode { get; set; } = PersonViewMode.PersonViewMode_ThirdPerson;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public PlayerSpawnType PlayerSpawnType { get; set; } = fb.GameShared.PlayerSpawnType.PlayerSpawnType_HumanPlayer;
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public CtrRef<CharacterSoundData> Sound { get; set; } = new();
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public bool CharacterLightingEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxHealth);
		p_Writer.Write((int) DefaultViewMode);
		p_Writer.Write((int) PlayerSpawnType);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(VoiceOverInfo));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Sound));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CharacterLightingEnable);
		p_Writer.WriteNullBytes(15);
	}
}

