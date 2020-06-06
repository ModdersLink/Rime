///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class AdvertisementLevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		[ContainerField(8), LayoutImmutable]
		public string Identifier { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public List<AdvertisementZoneMember> Members { get; set; } = new List<AdvertisementZoneMember>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3512790342:
					Identifier = (string) p_Value;
					break;

				case 1446896454:
					Members = (List<AdvertisementZoneMember>) p_Value;
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

				case 1446896454:
					return Members;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3512790342:
					return typeof(AdvertisementLevelDescriptionComponent).GetProperty(nameof(Identifier));

				case 1446896454:
					return typeof(AdvertisementLevelDescriptionComponent).GetProperty(nameof(Members));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
