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
	public class ProfileOptionDataFloat : 
		ProfileOptionData
	{
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Min { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Max { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float Value { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float Step { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193446607:
					Min = (float) p_Value;
					break;

				case 193446865:
					Max = (float) p_Value;
					break;

				case 225375086:
					Value = (float) p_Value;
					break;

				case 2089400887:
					Step = (float) p_Value;
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
				case 193446607:
					return Min;

				case 193446865:
					return Max;

				case 225375086:
					return Value;

				case 2089400887:
					return Step;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193446607:
					return typeof(ProfileOptionDataFloat).GetProperty(nameof(Min));

				case 193446865:
					return typeof(ProfileOptionDataFloat).GetProperty(nameof(Max));

				case 225375086:
					return typeof(ProfileOptionDataFloat).GetProperty(nameof(Value));

				case 2089400887:
					return typeof(ProfileOptionDataFloat).GetProperty(nameof(Step));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
