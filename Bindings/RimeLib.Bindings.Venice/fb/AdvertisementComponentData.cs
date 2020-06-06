///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class AdvertisementComponentData : 
		PartComponentData
	{
		[ContainerField(112), LayoutImmutable]
		public string Identifier { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable]
		public string AdTexture { get; set; } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3512790342:
					Identifier = (string) p_Value;
					break;

				case 1084313599:
					AdTexture = (string) p_Value;
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

				case 1084313599:
					return AdTexture;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3512790342:
					return typeof(AdvertisementComponentData).GetProperty(nameof(Identifier));

				case 1084313599:
					return typeof(AdvertisementComponentData).GetProperty(nameof(AdTexture));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
