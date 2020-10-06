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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class DestructionPartComponentData : 
		ComponentData
	{
		protected RefArray<GameObjectData> m_Objects = new RefArray<GameObjectData>();
		[ContainerField(96), MemberInfoFlag(65), ContainerFieldNameHash(105488131), ContainerRefArray]
		public RefArray<GameObjectData> Objects { get { return m_Objects; } set { if (OnPropertyChanging("DestructionPartComponentData." + nameof(Objects), this, m_Objects, value)) m_Objects = value; } } // 0x60 (96)
		
		protected uint m_PartIndex = new uint();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3213901068)]
		public uint PartIndex { get { return m_PartIndex; } set { if (OnPropertyChanging("DestructionPartComponentData." + nameof(PartIndex), this, m_PartIndex, value)) m_PartIndex = value; } } // 0x64 (100)
		
		protected DestructionConnectivityType m_ConnectivityType = new DestructionConnectivityType();
		[ContainerField(104), MemberInfoFlag(137), ContainerFieldNameHash(135434200)]
		public DestructionConnectivityType ConnectivityType { get { return m_ConnectivityType; } set { if (OnPropertyChanging("DestructionPartComponentData." + nameof(ConnectivityType), this, m_ConnectivityType, value)) m_ConnectivityType = value; } } // 0x68 (104)
		
		protected bool m_Fixed = new bool();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(206684275)]
		public bool Fixed { get { return m_Fixed; } set { if (OnPropertyChanging("DestructionPartComponentData." + nameof(Fixed), this, m_Fixed, value)) m_Fixed = value; } } // 0x6C (108)
		
		protected bool m_Fragile = new bool();
		[ContainerField(109), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2082366423)]
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
