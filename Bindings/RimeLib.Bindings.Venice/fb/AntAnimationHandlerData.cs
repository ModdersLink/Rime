///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
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
		[ContainerField(0)]
		public AntAnimatableData Animatable { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef RootController { get; set; } = new();
		
		[ContainerField(24)]
		public LodBinding LodBinding { get; set; } = new();
		
		[ContainerField(36)]
		public RefArray<AntPackageAsset> AntPackageData { get; set; } = new();
		
		[ContainerField(40)]
		public List<GameplayBone> BonesToMirror { get; set; } = new();
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool ReportBackFromAnt { get; set; }
		
		[ContainerField(45), LayoutImmutable, Blittable]
		public bool EnableMasterSlaveCopy { get; set; }
		
		[ContainerField(46), LayoutImmutable, Blittable]
		public bool IsProp { get; set; }
		
	}
}
