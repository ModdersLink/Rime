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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class ShootAtFromCoverData :
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public StrengthType StrengthType { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public ShootType ShootType { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool CycleTargets { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		public bool RandomTargetOrder { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
		public bool PreferAlternativeWeapon { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) StrengthType);
			p_Writer.Write((int) ShootType);
			p_Writer.Write(CycleTargets);
			p_Writer.Write(RandomTargetOrder);
			p_Writer.Write(PreferAlternativeWeapon);
			p_Writer.WriteNullBytes(1);
		}
	}
}
