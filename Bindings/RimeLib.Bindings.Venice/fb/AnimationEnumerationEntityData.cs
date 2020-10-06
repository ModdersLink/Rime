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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class AnimationEnumerationEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("AnimationEnumerationEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected CtrRef<AntEnumeration> m_AntEnum = new CtrRef<AntEnumeration>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(577236237), ContainerCtrRef]
		public CtrRef<AntEnumeration> AntEnum { get { return m_AntEnum; } set { if (OnPropertyChanging("AnimationEnumerationEntityData." + nameof(AntEnum), this, m_AntEnum, value)) m_AntEnum = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 577236237:
					AntEnum = (CtrRef<AntEnumeration>) p_Value;
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
				case 229961746:
					return Realm;

				case 577236237:
					return AntEnum;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(AnimationEnumerationEntityData).GetProperty(nameof(Realm));

				case 577236237:
					return typeof(AnimationEnumerationEntityData).GetProperty(nameof(AntEnum));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
