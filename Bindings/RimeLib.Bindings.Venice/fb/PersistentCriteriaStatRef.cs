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
	[ContainerType(4, 24)]
	public class PersistentCriteriaStatRef : 
		AbstractPersistentStatRef
	{
		[ContainerField(8)]
		public CtrRef<CriteriaData> Criteria { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<StatsCategoryBaseData> ParamX { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<StatsCategoryBaseData> ParamY { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<AwardData> CriteriaOwner { get; set; } = new();

	}
}
