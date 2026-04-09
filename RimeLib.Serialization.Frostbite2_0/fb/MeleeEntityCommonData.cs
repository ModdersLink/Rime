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
	[ContainerType(4, 100)]
	public partial class MeleeEntityCommonData :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CharacterMeleeBinding _MeleeBinding = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CharacterMeleeCommonBinding _MeleeCommonBinding = new();

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _TriggerDelay;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _DefendWindow;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _KillDelay;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _MeleeEndDelay;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _InvalidMeleeAttackZone;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _MeleeAttackDistance;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _MaxAttackHeightDifference;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _KillDamage;

		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private CtrRef<AntEnumeration> _ProneAttackType = new();

		[ObservableProperty]
		[property: ContainerField(92), JsonProperty(Order = 92)]
		private CtrRef<AntEnumeration> _CrouchAttackType = new();

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private bool _EnableAbortPossibility;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			MeleeBinding.Serialize(p_Writer, p_EbxWriter);
			MeleeCommonBinding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TriggerDelay);
			p_Writer.Write(DefendWindow);
			p_Writer.Write(KillDelay);
			p_Writer.Write(MeleeEndDelay);
			p_Writer.Write(InvalidMeleeAttackZone);
			p_Writer.Write(MeleeAttackDistance);
			p_Writer.Write(MaxAttackHeightDifference);
			p_Writer.Write(KillDamage);
			p_Writer.Write(p_EbxWriter.WriteImport(ProneAttackType));
			p_Writer.Write(p_EbxWriter.WriteImport(CrouchAttackType));
			p_Writer.Write(EnableAbortPossibility);
			p_Writer.WriteNullBytes(3);
		}
	}
}
