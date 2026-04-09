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
	[ContainerType(4, 164)]
	public partial class VeniceSoldierHealthModuleData :
		SoldierHealthModuleData
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _TimeForCorpse;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _PostReviveResponseTime;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _InteractiveManDownThreshold;

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private PoseConstraintsData _InteractiveManDownPoseConstraints = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _ManDownStateTime;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _ManDownStateHealthPoints;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _ImmortalTimeAfterSpawn;

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private List<EntryInputActionEnum> _AbortSpawnImmortalityInputs = new();

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _PostReviveHealth;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _CriticalFakeImmortalTime;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _RegenerationDelay;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _RegenerationRate;

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private SoldierHealthModuleBinding _Binding = new();

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _SprintDisabledWhenDamagedTime;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _SprintDisabledDamageThreshold;

		[ObservableProperty]
		[property: ContainerField(156), JsonProperty(Order = 156)]
		private RotateToHitData _ManDownRotate = new();

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private bool _InteractiveManDown;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TimeForCorpse);
			p_Writer.Write(PostReviveResponseTime);
			p_Writer.Write(InteractiveManDownThreshold);
			InteractiveManDownPoseConstraints.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(1);
			p_Writer.Write(ManDownStateTime);
			p_Writer.Write(ManDownStateHealthPoints);
			p_Writer.Write(ImmortalTimeAfterSpawn);
			(RimeWriter Writer, uint ArrayIndex) s_AbortSpawnImmortalityInputs = p_EbxWriter.GetArrayWriter(AbortSpawnImmortalityInputs.GetType(), AbortSpawnImmortalityInputs.Count);
			p_Writer.Write(s_AbortSpawnImmortalityInputs.ArrayIndex);
			foreach (var s_Entry in AbortSpawnImmortalityInputs)
			{
				s_AbortSpawnImmortalityInputs.Writer.Write((int) s_Entry);
			}
			p_Writer.Write(PostReviveHealth);
			p_Writer.Write(CriticalFakeImmortalTime);
			p_Writer.Write(RegenerationDelay);
			p_Writer.Write(RegenerationRate);
			Binding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SprintDisabledWhenDamagedTime);
			p_Writer.Write(SprintDisabledDamageThreshold);
			ManDownRotate.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(InteractiveManDown);
			p_Writer.WriteNullBytes(3);
		}
	}
}
