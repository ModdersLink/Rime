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
	public class ScoringTypeData : 
		DataContainer
	{
		[ContainerField(8)]
		public StatEvent Measuring { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<StatsCategoryBaseData> ParamX { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<StatsCategoryBaseData> ParamY { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Limit { get; set; }

		[ContainerField(24), LayoutImmutable]
		public string DescriptionSid { get; set; } = string.Empty;

		[ContainerField(28)]
		public ScoringVisibilityType VisibilityType { get; set; } = new();

		[ContainerField(32)]
		public ScoringBucket Bucket { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public float Score { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float AdditionalValueMultiplier { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool ShowForTeam { get; set; }

	}
}
