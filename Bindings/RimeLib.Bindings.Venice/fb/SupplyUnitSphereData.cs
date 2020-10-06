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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(20), ContainerStruct]
	public class SupplyUnitSphereData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Radius { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float SupplyIncSpeed { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float SupplyPointsCapacity { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float SupplyPointsRefillSpeed { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool InfiniteCapacity { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3298407133:
					Radius = (float) p_Value;
					break;

				case 2900469877:
					SupplyIncSpeed = (float) p_Value;
					break;

				case 1551302013:
					SupplyPointsCapacity = (float) p_Value;
					break;

				case 790209782:
					SupplyPointsRefillSpeed = (float) p_Value;
					break;

				case 2129724911:
					InfiniteCapacity = (bool) p_Value;
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
				case 3298407133:
					return Radius;

				case 2900469877:
					return SupplyIncSpeed;

				case 1551302013:
					return SupplyPointsCapacity;

				case 790209782:
					return SupplyPointsRefillSpeed;

				case 2129724911:
					return InfiniteCapacity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3298407133:
					return typeof(SupplyUnitSphereData).GetProperty(nameof(Radius));

				case 2900469877:
					return typeof(SupplyUnitSphereData).GetProperty(nameof(SupplyIncSpeed));

				case 1551302013:
					return typeof(SupplyUnitSphereData).GetProperty(nameof(SupplyPointsCapacity));

				case 790209782:
					return typeof(SupplyUnitSphereData).GetProperty(nameof(SupplyPointsRefillSpeed));

				case 2129724911:
					return typeof(SupplyUnitSphereData).GetProperty(nameof(InfiniteCapacity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
