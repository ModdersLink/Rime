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
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 48)]
	public class AntAnimationHandlerData
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntAnimatableData Animatable { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef RootController { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public LodBinding LodBinding { get; set; } = new();
		
		[ContainerField(36), JsonProperty(Order = 36)]
		public RefArray<AntPackageAsset> AntPackageData { get; set; } = new();
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public List<GameplayBone> BonesToMirror { get; set; } = new();
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool ReportBackFromAnt { get; set; }
		
		[ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		public bool EnableMasterSlaveCopy { get; set; }
		
		[ContainerField(46), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
		public bool IsProp { get; set; }
		
	}
}
