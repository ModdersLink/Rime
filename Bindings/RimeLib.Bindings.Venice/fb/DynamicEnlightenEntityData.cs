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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(28), ContainerClass]
	public class DynamicEnlightenEntityData : 
		EnlightenEntityData
	{
		protected CtrRef<EnlightenDataAsset> m_EnlightenData = new CtrRef<EnlightenDataAsset>();
		[ContainerField(24), MemberInfoFlag(53), ContainerFieldNameHash(1802220171), ContainerCtrRef]
		public CtrRef<EnlightenDataAsset> EnlightenData { get { return m_EnlightenData; } set { if (OnPropertyChanging("DynamicEnlightenEntityData." + nameof(EnlightenData), this, m_EnlightenData, value)) m_EnlightenData = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1802220171:
					EnlightenData = (CtrRef<EnlightenDataAsset>) p_Value;
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
				case 1802220171:
					return EnlightenData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1802220171:
					return typeof(DynamicEnlightenEntityData).GetProperty(nameof(EnlightenData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
