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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 8,  Flags: 41, Size: 24)]
	public class UIGPSPosition : FrostbiteContainer
	{
		[ContainerField(Name: "Latitude", Offset: 0, NameHash: 591028213, Flags: 49485), LayoutImmutable, Blittable]
		public double Latitude { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Longitude", Offset: 8, NameHash: 3158300774, Flags: 49485), LayoutImmutable, Blittable]
		public double Longitude { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "SeaLevelOffset", Offset: 16, NameHash: 2454050473, Flags: 49485), LayoutImmutable, Blittable]
		public double SeaLevelOffset { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 591028213:
					Latitude = (double) p_Value;
					break;

				case 3158300774:
					Longitude = (double) p_Value;
					break;

				case 2454050473:
					SeaLevelOffset = (double) p_Value;
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
				case 591028213:
					return Latitude;

				case 3158300774:
					return Longitude;

				case 2454050473:
					return SeaLevelOffset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 591028213:
					return typeof(UIGPSPosition).GetProperty(nameof(Latitude));

				case 3158300774:
					return typeof(UIGPSPosition).GetProperty(nameof(Longitude));

				case 2454050473:
					return typeof(UIGPSPosition).GetProperty(nameof(SeaLevelOffset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
