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
	[ContainerType(4, 36)]
	public class AIEntryData :
		GameAIEntryData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<AIVehicleBehaviourData> EquipmentType { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<ArmamentData> Armament { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<MobilityData> Mobility { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public StrengthType StrengthType { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float ReuseTime { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool Forbidden { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool HasExposedSoldier { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		public bool InterludeOnly { get; set; }

		[ContainerField(35), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
		public bool InvalidForAI { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(EquipmentType));
			p_Writer.Write(p_EbxWriter.WriteImport(Armament));
			p_Writer.Write(p_EbxWriter.WriteImport(Mobility));
			p_Writer.Write((int) StrengthType);
			p_Writer.Write(ReuseTime);
			p_Writer.Write(Forbidden);
			p_Writer.Write(HasExposedSoldier);
			p_Writer.Write(InterludeOnly);
			p_Writer.Write(InvalidForAI);
		}
	}
}
