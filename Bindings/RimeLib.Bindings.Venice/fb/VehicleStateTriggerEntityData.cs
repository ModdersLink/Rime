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
	[ContainerType(16, 160)]
	public class VehicleStateTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float LockAmount { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public uint BulletCount { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public uint HealthToSet { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public uint SeatSpecificIndexForHuman { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public uint SeatSpecificIndexForAi { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float DestructionRadius { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public uint HealthToCheck { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public bool AllowHumanToEnterAllSeats { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable]
		public bool AllowAiToEnterAllSeats { get; set; }

		[ContainerField(142), LayoutImmutable, Blittable]
		public bool BanAiFromSpecificSeat { get; set; }

		[ContainerField(143), LayoutImmutable, Blittable]
		public bool TriggerCriticalOnHealthSet { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public bool CheckHealthGreaterOrEqual { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable]
		public bool RestrictHumanToSpecificSeat { get; set; }

		[ContainerField(146), LayoutImmutable, Blittable]
		public bool ShouldDestroyVehicles { get; set; }

		[ContainerField(147), LayoutImmutable, Blittable]
		public bool ShouldDestroyBangers { get; set; }

		public static void Deserialize(VehicleStateTriggerEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.LockAmount = p_Reader.ReadSingle();
			p_Instance.BulletCount = p_Reader.ReadUInt32();
			p_Instance.HealthToSet = p_Reader.ReadUInt32();
			p_Instance.SeatSpecificIndexForHuman = p_Reader.ReadUInt32();
			p_Instance.SeatSpecificIndexForAi = p_Reader.ReadUInt32();
			p_Instance.DestructionRadius = p_Reader.ReadSingle();
			p_Instance.HealthToCheck = p_Reader.ReadUInt32();
			p_Instance.AllowHumanToEnterAllSeats = p_Reader.ReadBool();
			p_Instance.AllowAiToEnterAllSeats = p_Reader.ReadBool();
			p_Instance.BanAiFromSpecificSeat = p_Reader.ReadBool();
			p_Instance.TriggerCriticalOnHealthSet = p_Reader.ReadBool();
			p_Instance.CheckHealthGreaterOrEqual = p_Reader.ReadBool();
			p_Instance.RestrictHumanToSpecificSeat = p_Reader.ReadBool();
			p_Instance.ShouldDestroyVehicles = p_Reader.ReadBool();
			p_Instance.ShouldDestroyBangers = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
