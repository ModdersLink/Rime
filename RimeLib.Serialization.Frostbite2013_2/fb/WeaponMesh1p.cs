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

using fb.Render;

namespace fb.SoldierShared;

[ContainerType(8, 16)]
public class WeaponMesh1p
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public CtrRef<SkinnedMeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public CtrRef<SkinnedMeshAsset> MeshZoom { get; set; } = new();
	
}

