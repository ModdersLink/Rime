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
	[ContainerType(16, 64)]
	public class UIMinimapDistanceFieldParams
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ColorTint { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 OutlineColor { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float DistanceScale { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float AlphaThreshold { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float OutlineInner { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float OutlineOuter { get; set; }
		
		[ContainerField(48)]
		public CtrRef<UIDistanceFieldAsset> DistanceField { get; set; } = new();
		
	}
}
