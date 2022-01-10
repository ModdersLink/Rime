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
	[ContainerType(4, 48)]
	public class DamageScoringHandlerData : 
		ScoringHandlerData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float RepairVehicleLimit { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float DamageTeamVehicleLimit { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float TeamHealingLimit { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float TeamDamageLimit { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float KillAssistLimit { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float KillAssistTimeout { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float VehicleDestroyAssistLimit { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float SaviorKillTimeout { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float SaviorDamageLimit { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float HotVehicleTimeout { get; set; }

		public static void Deserialize(DamageScoringHandlerData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RepairVehicleLimit = p_Reader.ReadSingle();
			p_Instance.DamageTeamVehicleLimit = p_Reader.ReadSingle();
			p_Instance.TeamHealingLimit = p_Reader.ReadSingle();
			p_Instance.TeamDamageLimit = p_Reader.ReadSingle();
			p_Instance.KillAssistLimit = p_Reader.ReadSingle();
			p_Instance.KillAssistTimeout = p_Reader.ReadSingle();
			p_Instance.VehicleDestroyAssistLimit = p_Reader.ReadSingle();
			p_Instance.SaviorKillTimeout = p_Reader.ReadSingle();
			p_Instance.SaviorDamageLimit = p_Reader.ReadSingle();
			p_Instance.HotVehicleTimeout = p_Reader.ReadSingle();
		}

	}
}
