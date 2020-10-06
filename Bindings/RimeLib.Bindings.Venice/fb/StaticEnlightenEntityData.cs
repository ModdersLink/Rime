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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class StaticEnlightenEntityData : 
		EnlightenEntityData
	{
		protected CtrRef<StaticEnlightenData> m_EnlightenData = new CtrRef<StaticEnlightenData>();
		[ContainerField(24), MemberInfoFlag(53), ContainerFieldNameHash(1802220171), ContainerCtrRef]
		public CtrRef<StaticEnlightenData> EnlightenData { get { return m_EnlightenData; } set { if (OnPropertyChanging("StaticEnlightenEntityData." + nameof(EnlightenData), this, m_EnlightenData, value)) m_EnlightenData = value; } } // 0x18 (24)
		
		protected CtrRef<EnlightenDataAsset> m_DynamicEnlightenData = new CtrRef<EnlightenDataAsset>();
		[ContainerField(28), MemberInfoFlag(53), ContainerFieldNameHash(79303358), ContainerCtrRef]
		public CtrRef<EnlightenDataAsset> DynamicEnlightenData { get { return m_DynamicEnlightenData; } set { if (OnPropertyChanging("StaticEnlightenEntityData." + nameof(DynamicEnlightenData), this, m_DynamicEnlightenData, value)) m_DynamicEnlightenData = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1802220171:
					EnlightenData = (CtrRef<StaticEnlightenData>) p_Value;
					break;

				case 79303358:
					DynamicEnlightenData = (CtrRef<EnlightenDataAsset>) p_Value;
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

				case 79303358:
					return DynamicEnlightenData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1802220171:
					return typeof(StaticEnlightenEntityData).GetProperty(nameof(EnlightenData));

				case 79303358:
					return typeof(StaticEnlightenEntityData).GetProperty(nameof(DynamicEnlightenData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
