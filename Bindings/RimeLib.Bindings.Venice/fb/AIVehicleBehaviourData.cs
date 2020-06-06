///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class AIVehicleBehaviourData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public List<string> Controls { get; set; } = new List<string>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<string> Behaviours { get; set; } = new List<string>(); // 0x10 (16)
		
		[ContainerField(20)]
		public List<string> Goals { get; set; } = new List<string>(); // 0x14 (20)
		
		[ContainerField(24)]
		public List<IntentData> Intents { get; set; } = new List<IntentData>(); // 0x18 (24)
		
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
