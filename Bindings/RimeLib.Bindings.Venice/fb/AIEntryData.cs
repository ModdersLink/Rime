///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class AIEntryData : 
		GameAIEntryData
	{
		[ContainerField(12)]
		public CtrRef<AIVehicleBehaviourData> EquipmentType { get; set; } = new CtrRef<AIVehicleBehaviourData>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<ArmamentData> Armament { get; set; } = new CtrRef<ArmamentData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<MobilityData> Mobility { get; set; } = new CtrRef<MobilityData>(); // 0x14 (20)
		
		[ContainerField(24)]
		public StrengthType StrengthType { get; set; } = new StrengthType(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ReuseTime { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool Forbidden { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool HasExposedSoldier { get; set; } // 0x21 (33)
		
		[ContainerField(34), LayoutImmutable, Blittable]
		public bool InterludeOnly { get; set; } // 0x22 (34)
		
		[ContainerField(35), LayoutImmutable, Blittable]
		public bool InvalidForAI { get; set; } // 0x23 (35)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2631564535:
					EquipmentType = (CtrRef<AIVehicleBehaviourData>) p_Value;
					break;

				case 4084490376:
					Armament = (CtrRef<ArmamentData>) p_Value;
					break;

				case 1143844292:
					Mobility = (CtrRef<MobilityData>) p_Value;
					break;

				case 4037075576:
					StrengthType = (StrengthType) Enum.ToObject(typeof(StrengthType), p_Value);
					break;

				case 888103652:
					ReuseTime = (float) p_Value;
					break;

				case 3410005054:
					Forbidden = (bool) p_Value;
					break;

				case 969684421:
					HasExposedSoldier = (bool) p_Value;
					break;

				case 1784294221:
					InterludeOnly = (bool) p_Value;
					break;

				case 1160734887:
					InvalidForAI = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2631564535:
					return EquipmentType;

				case 4084490376:
					return Armament;

				case 1143844292:
					return Mobility;

				case 4037075576:
					return StrengthType;

				case 888103652:
					return ReuseTime;

				case 3410005054:
					return Forbidden;

				case 969684421:
					return HasExposedSoldier;

				case 1784294221:
					return InterludeOnly;

				case 1160734887:
					return InvalidForAI;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2631564535:
					return typeof(AIEntryData).GetProperty(nameof(EquipmentType));

				case 4084490376:
					return typeof(AIEntryData).GetProperty(nameof(Armament));

				case 1143844292:
					return typeof(AIEntryData).GetProperty(nameof(Mobility));

				case 4037075576:
					return typeof(AIEntryData).GetProperty(nameof(StrengthType));

				case 888103652:
					return typeof(AIEntryData).GetProperty(nameof(ReuseTime));

				case 3410005054:
					return typeof(AIEntryData).GetProperty(nameof(Forbidden));

				case 969684421:
					return typeof(AIEntryData).GetProperty(nameof(HasExposedSoldier));

				case 1784294221:
					return typeof(AIEntryData).GetProperty(nameof(InterludeOnly));

				case 1160734887:
					return typeof(AIEntryData).GetProperty(nameof(InvalidForAI));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
