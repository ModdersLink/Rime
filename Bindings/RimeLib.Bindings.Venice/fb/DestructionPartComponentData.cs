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
    [ContainerType(16)]
	public class DestructionPartComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public RefArray<GameObjectData> Objects { get; set; } = new RefArray<GameObjectData>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public uint PartIndex { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public DestructionConnectivityType ConnectivityType { get; set; } = new DestructionConnectivityType(); // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool Fixed { get; set; } // 0x6C (108)
		
		[ContainerField(109), LayoutImmutable, Blittable]
		public bool Fragile { get; set; } // 0x6D (109)
		
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
