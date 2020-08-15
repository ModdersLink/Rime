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
	[ContainerType(4)]
	public class AIVehicleBehaviourData : 
		DataContainer
	{
		protected string m_Name = new string();
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("AIVehicleBehaviourData." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected List<string> m_Controls = new List<string>();
		[ContainerField(12), ContainerFieldNameHash(333010129)]
		public List<string> Controls { get { return m_Controls; } set { if (OnPropertyChanging("AIVehicleBehaviourData." + nameof(Controls), this, m_Controls, value)) m_Controls = value; } } // 0xC (12)
		
		protected List<string> m_Behaviours = new List<string>();
		[ContainerField(16), ContainerFieldNameHash(4049352655)]
		public List<string> Behaviours { get { return m_Behaviours; } set { if (OnPropertyChanging("AIVehicleBehaviourData." + nameof(Behaviours), this, m_Behaviours, value)) m_Behaviours = value; } } // 0x10 (16)
		
		protected List<string> m_Goals = new List<string>();
		[ContainerField(20), ContainerFieldNameHash(207935763)]
		public List<string> Goals { get { return m_Goals; } set { if (OnPropertyChanging("AIVehicleBehaviourData." + nameof(Goals), this, m_Goals, value)) m_Goals = value; } } // 0x14 (20)
		
		protected List<IntentData> m_Intents = new List<IntentData>();
		[ContainerField(24), ContainerFieldNameHash(1691535386)]
		public List<IntentData> Intents { get { return m_Intents; } set { if (OnPropertyChanging("AIVehicleBehaviourData." + nameof(Intents), this, m_Intents, value)) m_Intents = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 333010129:
					Controls = (List<string>) p_Value;
					break;

				case 4049352655:
					Behaviours = (List<string>) p_Value;
					break;

				case 207935763:
					Goals = (List<string>) p_Value;
					break;

				case 1691535386:
					Intents = (List<IntentData>) p_Value;
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
				case 2088949890:
					return Name;

				case 333010129:
					return Controls;

				case 4049352655:
					return Behaviours;

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
				case 2088949890:
					return typeof(AIVehicleBehaviourData).GetProperty(nameof(Name));

				case 333010129:
					return typeof(AIVehicleBehaviourData).GetProperty(nameof(Controls));

				case 4049352655:
					return typeof(AIVehicleBehaviourData).GetProperty(nameof(Behaviours));

				case 207935763:
					return typeof(AIVehicleBehaviourData).GetProperty(nameof(Goals));

				case 1691535386:
					return typeof(AIVehicleBehaviourData).GetProperty(nameof(Intents));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
