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
	public class ProfileOptionData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string UniqueId { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public ProfileOptionsType Category { get; set; } = new ProfileOptionsType(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3045776603:
					UniqueId = (string) p_Value;
					break;

				case 3455858997:
					Category = (ProfileOptionsType) Enum.ToObject(typeof(ProfileOptionsType), p_Value);
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
				case 3045776603:
					return UniqueId;

				case 3455858997:
					return Category;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3045776603:
					return typeof(ProfileOptionData).GetProperty(nameof(UniqueId));

				case 3455858997:
					return typeof(ProfileOptionData).GetProperty(nameof(Category));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
