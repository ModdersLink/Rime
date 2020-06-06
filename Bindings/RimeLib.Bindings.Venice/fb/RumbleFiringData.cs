///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class RumbleFiringData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float LowRumble { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float HighRumble { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float RumbleDuration { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4150294224:
					LowRumble = (float) p_Value;
					break;

				case 2083796746:
					HighRumble = (float) p_Value;
					break;

				case 1471546714:
					RumbleDuration = (float) p_Value;
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
				case 4150294224:
					return LowRumble;

				case 2083796746:
					return HighRumble;

				case 1471546714:
					return RumbleDuration;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4150294224:
					return typeof(RumbleFiringData).GetProperty(nameof(LowRumble));

				case 2083796746:
					return typeof(RumbleFiringData).GetProperty(nameof(HighRumble));

				case 1471546714:
					return typeof(RumbleFiringData).GetProperty(nameof(RumbleDuration));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
