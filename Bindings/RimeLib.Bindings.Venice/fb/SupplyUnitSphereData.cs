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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 20)]
	public class SupplyUnitSphereData : FrostbiteContainer
	{
		[ContainerField(Name: "Radius", Offset: 0, NameHash: 3298407133, Flags: 49469), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "SupplyIncSpeed", Offset: 4, NameHash: 2900469877, Flags: 49469), LayoutImmutable, Blittable]
		public float SupplyIncSpeed { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "SupplyPointsCapacity", Offset: 8, NameHash: 1551302013, Flags: 49469), LayoutImmutable, Blittable]
		public float SupplyPointsCapacity { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "SupplyPointsRefillSpeed", Offset: 12, NameHash: 790209782, Flags: 49469), LayoutImmutable, Blittable]
		public float SupplyPointsRefillSpeed { get; set; } // 0xC (12)
		
		[ContainerField(Name: "InfiniteCapacity", Offset: 16, NameHash: 2129724911, Flags: 49325), LayoutImmutable, Blittable]
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
