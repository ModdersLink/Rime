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
	[ContainerType(4, 52)]
	public class CriteriaData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float CompletionValue { get; set; }

		[ContainerField(12)]
		public CtrRef<CriteriaGateList> GateList { get; set; } = new();

		[ContainerField(16)]
		public StatEvent Measuring { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<StatsCategoryBaseData> ParamX { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<StatsCategoryBaseData> ParamY { get; set; } = new();

		[ContainerField(28)]
		public RefArray<StatsCategoryBaseData> OrParamsX { get; set; } = new();

		[ContainerField(32)]
		public CriteriaType CriteriaType { get; set; } = new();

		[ContainerField(36), LayoutImmutable]
		public string DescriptionSid { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, Blittable]
		public float ScaleFactor { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float Scale { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool ShouldSummarize { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable]
		public bool ShouldHide { get; set; }

		[ContainerField(50), LayoutImmutable, Blittable]
		public bool CountEvents { get; set; }

	}
}
