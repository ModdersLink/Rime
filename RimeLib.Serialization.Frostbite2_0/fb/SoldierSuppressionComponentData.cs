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
	[ContainerType(16, 144)]
	public class SoldierSuppressionComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public SuppressionReactionData ReactionToSuppression { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float SuppressionResistModifier { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float SuppressionBoostModifier { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float SuppressionDecay { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float SuppressionSphereRadius { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float FallOffDelay { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float FallOffMultiplier { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public bool SuppressionAbortsHealthRegeneration { get; set; }

		[ContainerField(133), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
		public bool CheckLineOfSight { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ReactionToSuppression.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SuppressionResistModifier);
			p_Writer.Write(SuppressionBoostModifier);
			p_Writer.Write(SuppressionDecay);
			p_Writer.Write(SuppressionSphereRadius);
			p_Writer.Write(FallOffDelay);
			p_Writer.Write(FallOffMultiplier);
			p_Writer.Write(SuppressionAbortsHealthRegeneration);
			p_Writer.Write(CheckLineOfSight);
			p_Writer.WriteNullBytes(10);
		}
	}
}
