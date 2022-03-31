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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 56)]
	public class ShootOrderEntityData :
		BFOrderEntityData
	{
		[ContainerField(40), JsonProperty(Order = 40)]
		public StrengthType StrengthType { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public PoseType Pose { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public ShootType ShootType { get; set; } = new();

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public bool PreferAlternativeWeapon { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		public bool CompleteWhenHumanIsSensed { get; set; }

		[ContainerField(54), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
		public bool CycleTargets { get; set; }

		[ContainerField(55), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
		public bool RandomTargetOrder { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) StrengthType);
			p_Writer.Write((int) Pose);
			p_Writer.Write((int) ShootType);
			p_Writer.Write(PreferAlternativeWeapon);
			p_Writer.Write(CompleteWhenHumanIsSensed);
			p_Writer.Write(CycleTargets);
			p_Writer.Write(RandomTargetOrder);
		}
	}
}
