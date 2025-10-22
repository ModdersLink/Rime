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

using fb.Entity;

namespace fb.Ant;

[ContainerType(8, 96)]
public class AntAnimatableData
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public AntRef Actor { get; set; } = new();
	
	[ContainerField(0x14), JsonProperty(Order = 20)]
	public AntRef SceneOpMatrix { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<ProceduralAwarenessAntRefs> ProceduralAwareness { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AntRef RightHandEffectorDisableOverride { get; set; } = new();
	
	[ContainerField(0x44), JsonProperty(Order = 68)]
	public AntRef LeftHandEffectorDisableOverride { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<MasterSkeletonAsset> MasterSkeletonAsset { get; set; } = new();
	
}

