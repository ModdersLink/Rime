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
	[ContainerType(4)]
	public class EdgePointerData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float NegativeXLimit { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float PositiveXLimit { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float NegativeYLimit { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float PositiveYLimit { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3105779019:
					NegativeXLimit = (float) p_Value;
					break;

				case 1769243011:
					PositiveXLimit = (float) p_Value;
					break;

				case 3149374954:
					NegativeYLimit = (float) p_Value;
					break;

				case 1803639074:
					PositiveYLimit = (float) p_Value;
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
				case 3105779019:
					return NegativeXLimit;

				case 1769243011:
					return PositiveXLimit;

				case 3149374954:
					return NegativeYLimit;

				case 1803639074:
					return PositiveYLimit;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3105779019:
					return typeof(EdgePointerData).GetProperty(nameof(NegativeXLimit));

				case 1769243011:
					return typeof(EdgePointerData).GetProperty(nameof(PositiveXLimit));

				case 3149374954:
					return typeof(EdgePointerData).GetProperty(nameof(NegativeYLimit));

				case 1803639074:
					return typeof(EdgePointerData).GetProperty(nameof(PositiveYLimit));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
