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
	public class ProfileOptionDataInt : 
		ProfileOptionData
	{
		[ContainerField(20), LayoutImmutable, Blittable]
		public int Min { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int Max { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public int Value { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public int Step { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193446607:
					Min = (int) p_Value;
					break;

				case 193446865:
					Max = (int) p_Value;
					break;

				case 225375086:
					Value = (int) p_Value;
					break;

				case 2089400887:
					Step = (int) p_Value;
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
					return typeof(ProfileOptionDataInt).GetProperty(nameof(Min));

				case 193446865:
					return typeof(ProfileOptionDataInt).GetProperty(nameof(Max));

				case 225375086:
					return typeof(ProfileOptionDataInt).GetProperty(nameof(Value));

				case 2089400887:
					return typeof(ProfileOptionDataInt).GetProperty(nameof(Step));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
