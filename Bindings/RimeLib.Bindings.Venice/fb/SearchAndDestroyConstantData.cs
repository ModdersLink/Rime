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
	public class SearchAndDestroyConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float TimeToWaitMin { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float TimeToWaitMax { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float DefaultSearchAndDestroyRadius { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3374725610:
					TimeToWaitMin = (float) p_Value;
					break;

				case 3374725876:
					TimeToWaitMax = (float) p_Value;
					break;

				case 222001681:
					DefaultSearchAndDestroyRadius = (float) p_Value;
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
				case 3374725610:
					return TimeToWaitMin;

				case 3374725876:
					return TimeToWaitMax;

				case 222001681:
					return DefaultSearchAndDestroyRadius;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3374725610:
					return typeof(SearchAndDestroyConstantData).GetProperty(nameof(TimeToWaitMin));

				case 3374725876:
					return typeof(SearchAndDestroyConstantData).GetProperty(nameof(TimeToWaitMax));

				case 222001681:
					return typeof(SearchAndDestroyConstantData).GetProperty(nameof(DefaultSearchAndDestroyRadius));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
