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
	public class PS3StoreImageHD1080 : 
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable]
		public string Identifier { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string ImagePath { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3512790342:
					Identifier = (string) p_Value;
					break;

				case 2679336655:
					ImagePath = (string) p_Value;
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
				case 3512790342:
					return Identifier;

				case 2679336655:
					return ImagePath;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3512790342:
					return typeof(PS3StoreImageHD1080).GetProperty(nameof(Identifier));

				case 2679336655:
					return typeof(PS3StoreImageHD1080).GetProperty(nameof(ImagePath));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
