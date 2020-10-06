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
	[ContainerType(1), MemberInfoFlag(41), ContainerSize(6), ContainerStruct]
	public class InteractionTypesData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool InteractionEntity { get; set; } // 0x0 (0)
		
		[ContainerField(1), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool PickupEntity { get; set; } // 0x1 (1)
		
		[ContainerField(2), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool AmmoCrateEntity { get; set; } // 0x2 (2)
		
		[ContainerField(3), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool VehicleEntity { get; set; } // 0x3 (3)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool ExplosionPackEntity { get; set; } // 0x4 (4)
		
		[ContainerField(5), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool SoldierEntity { get; set; } // 0x5 (5)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1225422660:
					InteractionEntity = (bool) p_Value;
					break;

				case 2090982314:
					PickupEntity = (bool) p_Value;
					break;

				case 128996113:
					AmmoCrateEntity = (bool) p_Value;
					break;

				case 3928223142:
					VehicleEntity = (bool) p_Value;
					break;

				case 3822215602:
					ExplosionPackEntity = (bool) p_Value;
					break;

				case 1335195956:
					SoldierEntity = (bool) p_Value;
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
				case 1225422660:
					return InteractionEntity;

				case 2090982314:
					return PickupEntity;

				case 128996113:
					return AmmoCrateEntity;

				case 3928223142:
					return VehicleEntity;

				case 3822215602:
					return ExplosionPackEntity;

				case 1335195956:
					return SoldierEntity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1225422660:
					return typeof(InteractionTypesData).GetProperty(nameof(InteractionEntity));

				case 2090982314:
					return typeof(InteractionTypesData).GetProperty(nameof(PickupEntity));

				case 128996113:
					return typeof(InteractionTypesData).GetProperty(nameof(AmmoCrateEntity));

				case 3928223142:
					return typeof(InteractionTypesData).GetProperty(nameof(VehicleEntity));

				case 3822215602:
					return typeof(InteractionTypesData).GetProperty(nameof(ExplosionPackEntity));

				case 1335195956:
					return typeof(InteractionTypesData).GetProperty(nameof(SoldierEntity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
