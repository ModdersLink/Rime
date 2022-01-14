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
	[ContainerType(4, 44)]
	public class PhysicsSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint IntegrateJobCount { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint ClientEffectWorldThreadCount { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint ClientWorldThreadCount { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint ServerWorldThreadCount { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint CollideJobCount { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool Enable { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		public bool EnableAIRigidBody { get; set; }

		[ContainerField(30), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
		public bool ForestEnable { get; set; }

		[ContainerField(31), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
		public bool EnableJobs { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool RemoveRagdollWhenWoken { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool RemoveFromWorldOnCollisionOverflow { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		public bool SingleStepCharacter { get; set; }

		[ContainerField(35), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
		public bool ForceSingleStepCharacterInSP { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool EnableFollowWheelRaycasts { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		public bool EnableClientWheelRaycasts { get; set; }

		[ContainerField(38), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
		public bool EnableASyncWheelRaycasts { get; set; }

		[ContainerField(39), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
		public bool UseDelayedWakeUpClient { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool UseDelayedWakeUpServer { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		public bool SuppressDebrisSpawnUntilReady { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(IntegrateJobCount);
			p_Writer.Write(ClientEffectWorldThreadCount);
			p_Writer.Write(ClientWorldThreadCount);
			p_Writer.Write(ServerWorldThreadCount);
			p_Writer.Write(CollideJobCount);
			p_Writer.Write(Enable);
			p_Writer.Write(EnableAIRigidBody);
			p_Writer.Write(ForestEnable);
			p_Writer.Write(EnableJobs);
			p_Writer.Write(RemoveRagdollWhenWoken);
			p_Writer.Write(RemoveFromWorldOnCollisionOverflow);
			p_Writer.Write(SingleStepCharacter);
			p_Writer.Write(ForceSingleStepCharacterInSP);
			p_Writer.Write(EnableFollowWheelRaycasts);
			p_Writer.Write(EnableClientWheelRaycasts);
			p_Writer.Write(EnableASyncWheelRaycasts);
			p_Writer.Write(UseDelayedWakeUpClient);
			p_Writer.Write(UseDelayedWakeUpServer);
			p_Writer.Write(SuppressDebrisSpawnUntilReady);
			p_Writer.WriteNullBytes(2);
		}
	}
}
