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

namespace fb.Entity;

[ContainerType(8, 24)]
public class SubSkeleton
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public CtrRef<SkeletonAsset> Skeleton { get; set; } = new();
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public List<int> BoneMap { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<LinearTransform> TransformMap { get; set; } = new();
	
}

