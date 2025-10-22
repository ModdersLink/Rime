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

namespace fb.VeniceShared;

[ContainerType(4, 320)]
public class SoldierEmoteBinding
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public AntRef Speak { get; set; } = new();
	
	[ContainerField(0x14), JsonProperty(Order = 20)]
	public AntRef IsSquadLeader { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AntRef EmoteSpot { get; set; } = new();
	
	[ContainerField(0x3c), JsonProperty(Order = 60)]
	public AntRef EmoteOk { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AntRef EmoteNeedARide { get; set; } = new();
	
	[ContainerField(0x64), JsonProperty(Order = 100)]
	public AntRef EmoteGoGoGo { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public AntRef EmoteNeedBackup { get; set; } = new();
	
	[ContainerField(0x8c), JsonProperty(Order = 140)]
	public AntRef EmoteThanks { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public AntRef EmoteNeedMedic { get; set; } = new();
	
	[ContainerField(0xb4), JsonProperty(Order = 180)]
	public AntRef EmoteFollowMe { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public AntRef EmoteNeedAmmo { get; set; } = new();
	
	[ContainerField(0xdc), JsonProperty(Order = 220)]
	public AntRef EmoteSorry { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public AntRef EmoteNo { get; set; } = new();
	
	[ContainerField(0x104), JsonProperty(Order = 260)]
	public AntRef EmoteDefendCapturePoint { get; set; } = new();
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public AntRef EmoteAttackCapturePoint { get; set; } = new();
	
	[ContainerField(0x12c), JsonProperty(Order = 300)]
	public AntRef EmoteMoveToPosition { get; set; } = new();
	
}

