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
	public class MeleeEntityData : 
		EntityData
	{
		protected CtrRef<MeleeEntityCommonData> m_CommonData = new CtrRef<MeleeEntityCommonData>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(760803064), ContainerCtrRef]
		public CtrRef<MeleeEntityCommonData> CommonData { get { return m_CommonData; } set { if (OnPropertyChanging("MeleeEntityData." + nameof(CommonData), this, m_CommonData, value)) m_CommonData = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 760803064:
					CommonData = (CtrRef<MeleeEntityCommonData>) p_Value;
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
				case 760803064:
					return CommonData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 760803064:
					return typeof(MeleeEntityData).GetProperty(nameof(CommonData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
