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
    [ContainerType(4)]
	public class RadioAltitudeData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Range { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float UpdateFrequency { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public CollisionMethodEnum CollisionMethod { get; set; } = new CollisionMethodEnum(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230112826:
					Range = (float) p_Value;
					break;

				case 219717232:
					UpdateFrequency = (float) p_Value;
					break;

				case 2308963620:
					CollisionMethod = (CollisionMethodEnum) Enum.ToObject(typeof(CollisionMethodEnum), p_Value);
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
				case 230112826:
					return Range;

				case 219717232:
					return UpdateFrequency;

				case 2308963620:
					return CollisionMethod;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230112826:
					return typeof(RadioAltitudeData).GetProperty(nameof(Range));

				case 219717232:
					return typeof(RadioAltitudeData).GetProperty(nameof(UpdateFrequency));

				case 2308963620:
					return typeof(RadioAltitudeData).GetProperty(nameof(CollisionMethod));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
