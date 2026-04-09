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
	[ContainerType(16, 128)]
	public partial class DifficultyData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _StickyBoxModifier = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _SnapBoxModifier = new();

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _HumanHealthModifier;

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private PersistenceGameType _GameType = new();

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _FriendsHealthModifier;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _FriendlyDamageModifier;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _VehicleDamageModifier;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _HumanInCriticalHealth;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _EnemiesHealthModifier;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _HumanRegenerationRateModifier;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _HumanInCriticalHealthDamageModifier;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _InteractiveManDownDamageModifier;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _InteractiveManDownTimeMultiplier;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _InteractiveManDownReviveTime;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private int _AdrenalineKillLimit;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _CriticalHealthJesusModeTimeModifier;

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private Difficulty _Difficulty = new();

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _CriticalFakeImmortalModifier;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _SuckZoomModifier;

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private CtrRef<GameAIDifficultyData> _AIData = new();

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _AiBulletDamageHumanCooldown;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private bool _UsePitchZoomSnap;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
			StickyBoxModifier.Serialize(p_Writer, p_EbxWriter);
			SnapBoxModifier.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(HumanHealthModifier);
			p_Writer.Write((int) GameType);
			p_Writer.Write(FriendsHealthModifier);
			p_Writer.Write(FriendlyDamageModifier);
			p_Writer.Write(VehicleDamageModifier);
			p_Writer.Write(HumanInCriticalHealth);
			p_Writer.Write(EnemiesHealthModifier);
			p_Writer.Write(HumanRegenerationRateModifier);
			p_Writer.Write(HumanInCriticalHealthDamageModifier);
			p_Writer.Write(InteractiveManDownDamageModifier);
			p_Writer.Write(InteractiveManDownTimeMultiplier);
			p_Writer.Write(InteractiveManDownReviveTime);
			p_Writer.Write(AdrenalineKillLimit);
			p_Writer.Write(CriticalHealthJesusModeTimeModifier);
			p_Writer.Write((int) Difficulty);
			p_Writer.Write(CriticalFakeImmortalModifier);
			p_Writer.Write(SuckZoomModifier);
			p_Writer.Write(p_EbxWriter.WriteImport(AIData));
			p_Writer.Write(AiBulletDamageHumanCooldown);
			p_Writer.Write(UsePitchZoomSnap);
			p_Writer.WriteNullBytes(3);
		}
	}
}
