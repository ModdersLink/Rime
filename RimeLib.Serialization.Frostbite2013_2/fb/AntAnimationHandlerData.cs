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
using fb.Ant;

namespace fb.GameShared;

[ContainerType(8, 240)]
public class AntAnimationHandlerData
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public AntAnimatableData Animatable { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public AntRef RootController { get; set; } = new();
	
	[ContainerField(0x74), JsonProperty(Order = 116)]
	public LodBinding LodBinding { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public List<int> JointOutputFieldHashes { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public List<int> JointEnabledFieldHashes { get; set; } = new();
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public AntControllerComplexity ControllerComplexity { get; set; } = AntControllerComplexity.AntControllerComplexity_High;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public bool ReportBackFromAnt { get; set; } = true;
	
	[ContainerField(0xed), LayoutImmutable, Blittable, JsonProperty(Order = 237)]
	public bool EnableMasterSlaveCopy { get; set; } = true;
	
	[ContainerField(0xee), LayoutImmutable, Blittable, JsonProperty(Order = 238)]
	public bool IsProp { get; set; } = true;
	
}

