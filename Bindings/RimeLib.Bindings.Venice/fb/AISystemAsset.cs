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
	public class AISystemAsset : 
		GameAISystem
	{
		[ContainerField(12)]
		public CtrRef<AIVehicleTypes> Behaviours { get; set; } = new CtrRef<AIVehicleTypes>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<OrderSettings> Orders { get; set; } = new CtrRef<OrderSettings>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<AISettingsData> Settings { get; set; } = new CtrRef<AISettingsData>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4049352655:
					Behaviours = (CtrRef<AIVehicleTypes>) p_Value;
					break;

				case 2885972376:
					Orders = (CtrRef<OrderSettings>) p_Value;
					break;

				case 649772672:
					Settings = (CtrRef<AISettingsData>) p_Value;
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
				case 4049352655:
					return Behaviours;

				case 2885972376:
					return Orders;

				case 649772672:
					return Settings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4049352655:
					return typeof(AISystemAsset).GetProperty(nameof(Behaviours));

				case 2885972376:
					return typeof(AISystemAsset).GetProperty(nameof(Orders));

				case 649772672:
					return typeof(AISystemAsset).GetProperty(nameof(Settings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
