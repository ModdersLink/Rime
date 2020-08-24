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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class ProfileOptionData : 
		Asset
	{
		protected string m_UniqueId = string.Empty;
		[ContainerField(12), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3045776603)]
		public string UniqueId { get { return m_UniqueId; } set { if (OnPropertyChanging("ProfileOptionData." + nameof(UniqueId), this, m_UniqueId, value)) m_UniqueId = value; } } // 0xC (12)
		
		protected ProfileOptionsType m_Category = new ProfileOptionsType();
		[ContainerField(16), MemberInfoFlag(137), ContainerFieldNameHash(3455858997)]
		public ProfileOptionsType Category { get { return m_Category; } set { if (OnPropertyChanging("ProfileOptionData." + nameof(Category), this, m_Category, value)) m_Category = value; } } // 0x10 (16)
		
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
