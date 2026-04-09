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
	[ContainerType(4, 56)]
	public partial class ShootOrderEntityData :
		BFOrderEntityData
	{
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private StrengthType _StrengthType = new();

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private PoseType _Pose = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private ShootType _ShootType = new();

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private bool _PreferAlternativeWeapon;

		[ObservableProperty]
		[property: ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		private bool _CompleteWhenHumanIsSensed;

		[ObservableProperty]
		[property: ContainerField(54), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
		private bool _CycleTargets;

		[ObservableProperty]
		[property: ContainerField(55), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
		private bool _RandomTargetOrder;

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
