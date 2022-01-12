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
	[ContainerType(16, 144)]
	public class StaticModelGroupEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112)]
		public List<StaticModelGroupMemberData> MemberDatas { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public GUID HackToSolveRealTimeTweakingIssue { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public uint NetworkIdCount { get; set; }

	}
}
