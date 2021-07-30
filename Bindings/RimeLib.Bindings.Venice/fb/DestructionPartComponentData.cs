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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class DestructionPartComponentData : 
		ComponentData
	{
		protected RefArray<GameObjectData> m_Objects = new RefArray<GameObjectData>();
		[ContainerField(Name: "Objects", Offset: 96, NameHash: 105488131, Flags: 65)]
		public RefArray<GameObjectData> Objects { get { return m_Objects; } set { if (OnPropertyChanging("DestructionPartComponentData." + nameof(Objects), this, m_Objects, value)) m_Objects = value; } } // 0x60 (96)
		
		protected uint m_PartIndex = new uint();
		[ContainerField(Name: "PartIndex", Offset: 100, NameHash: 3213901068, Flags: 49421), LayoutImmutable, Blittable]
		public uint PartIndex { get { return m_PartIndex; } set { if (OnPropertyChanging("DestructionPartComponentData." + nameof(PartIndex), this, m_PartIndex, value)) m_PartIndex = value; } } // 0x64 (100)
		
		protected DestructionConnectivityType m_ConnectivityType = new DestructionConnectivityType();
		[ContainerField(Name: "ConnectivityType", Offset: 104, NameHash: 135434200, Flags: 137)]
		public DestructionConnectivityType ConnectivityType { get { return m_ConnectivityType; } set { if (OnPropertyChanging("DestructionPartComponentData." + nameof(ConnectivityType), this, m_ConnectivityType, value)) m_ConnectivityType = value; } } // 0x68 (104)
		
		protected bool m_Fixed = new bool();
		[ContainerField(Name: "Fixed", Offset: 108, NameHash: 206684275, Flags: 49325), LayoutImmutable, Blittable]
		public bool Fixed { get { return m_Fixed; } set { if (OnPropertyChanging("DestructionPartComponentData." + nameof(Fixed), this, m_Fixed, value)) m_Fixed = value; } } // 0x6C (108)
		
		protected bool m_Fragile = new bool();
		[ContainerField(Name: "Fragile", Offset: 109, NameHash: 2082366423, Flags: 49325), LayoutImmutable, Blittable]
		public bool Fragile { get { return m_Fragile; } set { if (OnPropertyChanging("DestructionPartComponentData." + nameof(Fragile), this, m_Fragile, value)) m_Fragile = value; } } // 0x6D (109)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 105488131:
					Objects = (RefArray<GameObjectData>) p_Value;
					break;

				case 3213901068:
					PartIndex = (uint) p_Value;
					break;

				case 135434200:
					ConnectivityType = (DestructionConnectivityType) Enum.ToObject(typeof(DestructionConnectivityType), p_Value);
					break;

				case 206684275:
					Fixed = (bool) p_Value;
					break;

				case 2082366423:
					Fragile = (bool) p_Value;
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
				case 105488131:
					return Objects;

				case 3213901068:
					return PartIndex;

				case 135434200:
					return ConnectivityType;

				case 206684275:
					return Fixed;

				case 2082366423:
					return Fragile;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 105488131:
					return typeof(DestructionPartComponentData).GetProperty(nameof(Objects));

				case 3213901068:
					return typeof(DestructionPartComponentData).GetProperty(nameof(PartIndex));

				case 135434200:
					return typeof(DestructionPartComponentData).GetProperty(nameof(ConnectivityType));

				case 206684275:
					return typeof(DestructionPartComponentData).GetProperty(nameof(Fixed));

				case 2082366423:
					return typeof(DestructionPartComponentData).GetProperty(nameof(Fragile));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
