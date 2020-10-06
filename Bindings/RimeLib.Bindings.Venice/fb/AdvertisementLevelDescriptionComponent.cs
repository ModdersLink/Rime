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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(16), ContainerClass]
	public class AdvertisementLevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		protected string m_Identifier = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3512790342)]
		public string Identifier { get { return m_Identifier; } set { if (OnPropertyChanging("AdvertisementLevelDescriptionComponent." + nameof(Identifier), this, m_Identifier, value)) m_Identifier = value; } } // 0x8 (8)
		
		protected List<AdvertisementZoneMember> m_Members = new List<AdvertisementZoneMember>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(1446896454), ContainerArray]
		public List<AdvertisementZoneMember> Members { get { return m_Members; } set { if (OnPropertyChanging("AdvertisementLevelDescriptionComponent." + nameof(Members), this, m_Members, value)) m_Members = value; } } // 0xC (12)
		
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
