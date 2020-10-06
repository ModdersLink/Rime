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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class AISystemAsset : 
		GameAISystem
	{
		protected CtrRef<AIVehicleTypes> m_Behaviours = new CtrRef<AIVehicleTypes>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(4049352655), ContainerCtrRef]
		public CtrRef<AIVehicleTypes> Behaviours { get { return m_Behaviours; } set { if (OnPropertyChanging("AISystemAsset." + nameof(Behaviours), this, m_Behaviours, value)) m_Behaviours = value; } } // 0xC (12)
		
		protected CtrRef<OrderSettings> m_Orders = new CtrRef<OrderSettings>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(2885972376), ContainerCtrRef]
		public CtrRef<OrderSettings> Orders { get { return m_Orders; } set { if (OnPropertyChanging("AISystemAsset." + nameof(Orders), this, m_Orders, value)) m_Orders = value; } } // 0x10 (16)
		
		protected CtrRef<AISettingsData> m_Settings = new CtrRef<AISettingsData>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(649772672), ContainerCtrRef]
		public CtrRef<AISettingsData> Settings { get { return m_Settings; } set { if (OnPropertyChanging("AISystemAsset." + nameof(Settings), this, m_Settings, value)) m_Settings = value; } } // 0x14 (20)
		
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
