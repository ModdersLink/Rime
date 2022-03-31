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
	[ContainerType(16, 208)]
	public class GrenadeEntityData :
		MeshProjectileEntityData
	{
		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float CollisionSpeedMultiplier { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public float Gravity { get; set; }

		[ContainerField(200), JsonProperty(Order = 200)]
		public GrenadeType GrenadeType { get; set; } = new();

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public float MinBounceSpeed { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(CollisionSpeedMultiplier);
			p_Writer.Write(Gravity);
			p_Writer.Write((int) GrenadeType);
			p_Writer.Write(MinBounceSpeed);
		}
	}
}
