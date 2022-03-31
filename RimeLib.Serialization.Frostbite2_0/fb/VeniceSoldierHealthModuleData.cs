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
	[ContainerType(4, 164)]
	public class VeniceSoldierHealthModuleData :
		SoldierHealthModuleData
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float TimeForCorpse { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float PostReviveResponseTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float InteractiveManDownThreshold { get; set; }

		[ContainerField(20), JsonProperty(Order = 20)]
		public PoseConstraintsData InteractiveManDownPoseConstraints { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float ManDownStateTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float ManDownStateHealthPoints { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float ImmortalTimeAfterSpawn { get; set; }

		[ContainerField(36), JsonProperty(Order = 36)]
		public List<EntryInputActionEnum> AbortSpawnImmortalityInputs { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float PostReviveHealth { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float CriticalFakeImmortalTime { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float RegenerationDelay { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float RegenerationRate { get; set; }

		[ContainerField(56), JsonProperty(Order = 56)]
		public SoldierHealthModuleBinding Binding { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float SprintDisabledWhenDamagedTime { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float SprintDisabledDamageThreshold { get; set; }

		[ContainerField(156), JsonProperty(Order = 156)]
		public RotateToHitData ManDownRotate { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public bool InteractiveManDown { get; set; }

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
