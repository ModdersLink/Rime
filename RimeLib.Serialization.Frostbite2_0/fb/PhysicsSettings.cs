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
	[ContainerType(4, 44)]
	public partial class PhysicsSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private uint _IntegrateJobCount;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _ClientEffectWorldThreadCount;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _ClientWorldThreadCount;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _ServerWorldThreadCount;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _CollideJobCount;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		private bool _EnableAIRigidBody;

		[ObservableProperty]
		[property: ContainerField(30), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
		private bool _ForestEnable;

		[ObservableProperty]
		[property: ContainerField(31), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
		private bool _EnableJobs;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private bool _RemoveRagdollWhenWoken;

		[ObservableProperty]
		[property: ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		private bool _RemoveFromWorldOnCollisionOverflow;

		[ObservableProperty]
		[property: ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		private bool _SingleStepCharacter;

		[ObservableProperty]
		[property: ContainerField(35), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
		private bool _ForceSingleStepCharacterInSP;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private bool _EnableFollowWheelRaycasts;

		[ObservableProperty]
		[property: ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		private bool _EnableClientWheelRaycasts;

		[ObservableProperty]
		[property: ContainerField(38), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
		private bool _EnableASyncWheelRaycasts;

		[ObservableProperty]
		[property: ContainerField(39), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
		private bool _UseDelayedWakeUpClient;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private bool _UseDelayedWakeUpServer;

		[ObservableProperty]
		[property: ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		private bool _SuppressDebrisSpawnUntilReady;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
