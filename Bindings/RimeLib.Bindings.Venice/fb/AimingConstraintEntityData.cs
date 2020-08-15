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
	[ContainerType(4)]
	public class AimingConstraintEntityData : 
		EntityData
	{
		protected CtrRef<AimingConstraintEntityCommonData> m_CommonData = new CtrRef<AimingConstraintEntityCommonData>();
		[ContainerField(12), ContainerFieldNameHash(760803064)]
		public CtrRef<AimingConstraintEntityCommonData> CommonData { get { return m_CommonData; } set { if (OnPropertyChanging("AimingConstraintEntityData." + nameof(CommonData), this, m_CommonData, value)) m_CommonData = value; } } // 0xC (12)
		
		protected bool m_EnabledInProne = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(1941848993)]
		public bool EnabledInProne { get { return m_EnabledInProne; } set { if (OnPropertyChanging("AimingConstraintEntityData." + nameof(EnabledInProne), this, m_EnabledInProne, value)) m_EnabledInProne = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 760803064:
					CommonData = (CtrRef<AimingConstraintEntityCommonData>) p_Value;
					break;

				case 1941848993:
					EnabledInProne = (bool) p_Value;
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

				case 1941848993:
					return EnabledInProne;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 760803064:
					return typeof(AimingConstraintEntityData).GetProperty(nameof(CommonData));

				case 1941848993:
					return typeof(AimingConstraintEntityData).GetProperty(nameof(EnabledInProne));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
