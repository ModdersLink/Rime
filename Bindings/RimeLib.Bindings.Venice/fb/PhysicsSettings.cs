///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 44)]
	public class PhysicsSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint IntegrateJobCount { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint ClientEffectWorldThreadCount { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint ClientWorldThreadCount { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint ServerWorldThreadCount { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint CollideJobCount { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable]
		public bool EnableAIRigidBody { get; set; }

		[ContainerField(30), LayoutImmutable, Blittable]
		public bool ForestEnable { get; set; }

		[ContainerField(31), LayoutImmutable, Blittable]
		public bool EnableJobs { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool RemoveRagdollWhenWoken { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool RemoveFromWorldOnCollisionOverflow { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable]
		public bool SingleStepCharacter { get; set; }

		[ContainerField(35), LayoutImmutable, Blittable]
		public bool ForceSingleStepCharacterInSP { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool EnableFollowWheelRaycasts { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable]
		public bool EnableClientWheelRaycasts { get; set; }

		[ContainerField(38), LayoutImmutable, Blittable]
		public bool EnableASyncWheelRaycasts { get; set; }

		[ContainerField(39), LayoutImmutable, Blittable]
		public bool UseDelayedWakeUpClient { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool UseDelayedWakeUpServer { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable]
		public bool SuppressDebrisSpawnUntilReady { get; set; }

		public static void Deserialize(PhysicsSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.IntegrateJobCount = p_Reader.ReadUInt32();
			p_Instance.ClientEffectWorldThreadCount = p_Reader.ReadUInt32();
			p_Instance.ClientWorldThreadCount = p_Reader.ReadUInt32();
			p_Instance.ServerWorldThreadCount = p_Reader.ReadUInt32();
			p_Instance.CollideJobCount = p_Reader.ReadUInt32();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Instance.EnableAIRigidBody = p_Reader.ReadBool();
			p_Instance.ForestEnable = p_Reader.ReadBool();
			p_Instance.EnableJobs = p_Reader.ReadBool();
			p_Instance.RemoveRagdollWhenWoken = p_Reader.ReadBool();
			p_Instance.RemoveFromWorldOnCollisionOverflow = p_Reader.ReadBool();
			p_Instance.SingleStepCharacter = p_Reader.ReadBool();
			p_Instance.ForceSingleStepCharacterInSP = p_Reader.ReadBool();
			p_Instance.EnableFollowWheelRaycasts = p_Reader.ReadBool();
			p_Instance.EnableClientWheelRaycasts = p_Reader.ReadBool();
			p_Instance.EnableASyncWheelRaycasts = p_Reader.ReadBool();
			p_Instance.UseDelayedWakeUpClient = p_Reader.ReadBool();
			p_Instance.UseDelayedWakeUpServer = p_Reader.ReadBool();
			p_Instance.SuppressDebrisSpawnUntilReady = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
