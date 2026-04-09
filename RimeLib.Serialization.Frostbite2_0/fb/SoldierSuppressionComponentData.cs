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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 144)]
	public partial class SoldierSuppressionComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private SuppressionReactionData _ReactionToSuppression = new();

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _SuppressionResistModifier;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _SuppressionBoostModifier;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _SuppressionDecay;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _SuppressionSphereRadius;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _FallOffDelay;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _FallOffMultiplier;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private bool _SuppressionAbortsHealthRegeneration;

		[ObservableProperty]
		[property: ContainerField(133), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
		private bool _CheckLineOfSight;

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
