///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class AIVehicleTypes : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<AIVehicleBehaviourData> VehicleTypes { get; set; } = new RefArray<AIVehicleBehaviourData>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<BehaviourData> Goals { get; set; } = new RefArray<BehaviourData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<BehaviourData> Intents { get; set; } = new RefArray<BehaviourData>(); // 0x14 (20)
		
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
