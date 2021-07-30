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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class AIVehicleTypes : 
		Asset
	{
		protected RefArray<AIVehicleBehaviourData> m_VehicleTypes = new RefArray<AIVehicleBehaviourData>();
		[ContainerField(Name: "VehicleTypes", Offset: 12, NameHash: 489934422, Flags: 65)]
		public RefArray<AIVehicleBehaviourData> VehicleTypes { get { return m_VehicleTypes; } set { if (OnPropertyChanging("AIVehicleTypes." + nameof(VehicleTypes), this, m_VehicleTypes, value)) m_VehicleTypes = value; } } // 0xC (12)
		
		protected RefArray<BehaviourData> m_Goals = new RefArray<BehaviourData>();
		[ContainerField(Name: "Goals", Offset: 16, NameHash: 207935763, Flags: 65)]
		public RefArray<BehaviourData> Goals { get { return m_Goals; } set { if (OnPropertyChanging("AIVehicleTypes." + nameof(Goals), this, m_Goals, value)) m_Goals = value; } } // 0x10 (16)
		
		protected RefArray<BehaviourData> m_Intents = new RefArray<BehaviourData>();
		[ContainerField(Name: "Intents", Offset: 20, NameHash: 1691535386, Flags: 65)]
		public RefArray<BehaviourData> Intents { get { return m_Intents; } set { if (OnPropertyChanging("AIVehicleTypes." + nameof(Intents), this, m_Intents, value)) m_Intents = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 489934422:
					VehicleTypes = (RefArray<AIVehicleBehaviourData>) p_Value;
					break;

				case 207935763:
					Goals = (RefArray<BehaviourData>) p_Value;
					break;

				case 1691535386:
					Intents = (RefArray<BehaviourData>) p_Value;
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
				case 489934422:
					return VehicleTypes;

				case 207935763:
					return Goals;

				case 1691535386:
					return Intents;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 489934422:
					return typeof(AIVehicleTypes).GetProperty(nameof(VehicleTypes));

				case 207935763:
					return typeof(AIVehicleTypes).GetProperty(nameof(Goals));

				case 1691535386:
					return typeof(AIVehicleTypes).GetProperty(nameof(Intents));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
