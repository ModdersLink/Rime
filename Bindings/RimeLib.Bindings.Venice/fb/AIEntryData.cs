///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class AIEntryData : 
		GameAIEntryData
	{
		protected CtrRef<AIVehicleBehaviourData> m_EquipmentType = new CtrRef<AIVehicleBehaviourData>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(2631564535), ContainerCtrRef]
		public CtrRef<AIVehicleBehaviourData> EquipmentType { get { return m_EquipmentType; } set { if (OnPropertyChanging("AIEntryData." + nameof(EquipmentType), this, m_EquipmentType, value)) m_EquipmentType = value; } } // 0xC (12)
		
		protected CtrRef<ArmamentData> m_Armament = new CtrRef<ArmamentData>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(4084490376), ContainerCtrRef]
		public CtrRef<ArmamentData> Armament { get { return m_Armament; } set { if (OnPropertyChanging("AIEntryData." + nameof(Armament), this, m_Armament, value)) m_Armament = value; } } // 0x10 (16)
		
		protected CtrRef<MobilityData> m_Mobility = new CtrRef<MobilityData>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(1143844292), ContainerCtrRef]
		public CtrRef<MobilityData> Mobility { get { return m_Mobility; } set { if (OnPropertyChanging("AIEntryData." + nameof(Mobility), this, m_Mobility, value)) m_Mobility = value; } } // 0x14 (20)
		
		protected StrengthType m_StrengthType = new StrengthType();
		[ContainerField(24), MemberInfoFlag(137), ContainerFieldNameHash(4037075576)]
		public StrengthType StrengthType { get { return m_StrengthType; } set { if (OnPropertyChanging("AIEntryData." + nameof(StrengthType), this, m_StrengthType, value)) m_StrengthType = value; } } // 0x18 (24)
		
		protected float m_ReuseTime = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(888103652)]
		public float ReuseTime { get { return m_ReuseTime; } set { if (OnPropertyChanging("AIEntryData." + nameof(ReuseTime), this, m_ReuseTime, value)) m_ReuseTime = value; } } // 0x1C (28)
		
		protected bool m_Forbidden = new bool();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3410005054)]
		public bool Forbidden { get { return m_Forbidden; } set { if (OnPropertyChanging("AIEntryData." + nameof(Forbidden), this, m_Forbidden, value)) m_Forbidden = value; } } // 0x20 (32)
		
		protected bool m_HasExposedSoldier = new bool();
		[ContainerField(33), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(969684421)]
		public bool HasExposedSoldier { get { return m_HasExposedSoldier; } set { if (OnPropertyChanging("AIEntryData." + nameof(HasExposedSoldier), this, m_HasExposedSoldier, value)) m_HasExposedSoldier = value; } } // 0x21 (33)
		
		protected bool m_InterludeOnly = new bool();
		[ContainerField(34), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1784294221)]
		public bool InterludeOnly { get { return m_InterludeOnly; } set { if (OnPropertyChanging("AIEntryData." + nameof(InterludeOnly), this, m_InterludeOnly, value)) m_InterludeOnly = value; } } // 0x22 (34)
		
		protected bool m_InvalidForAI = new bool();
		[ContainerField(35), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1160734887)]
		public bool InvalidForAI { get { return m_InvalidForAI; } set { if (OnPropertyChanging("AIEntryData." + nameof(InvalidForAI), this, m_InvalidForAI, value)) m_InvalidForAI = value; } } // 0x23 (35)
		
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
