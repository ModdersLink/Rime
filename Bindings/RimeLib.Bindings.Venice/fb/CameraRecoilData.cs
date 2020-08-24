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
	public class CameraRecoilData : 
		DataContainer
	{
		protected float m_SpringConstant = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3561415946)]
		public float SpringConstant { get { return m_SpringConstant; } set { if (OnPropertyChanging("CameraRecoilData." + nameof(SpringConstant), this, m_SpringConstant, value)) m_SpringConstant = value; } } // 0x8 (8)
		
		protected float m_SpringDamping = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1976598700)]
		public float SpringDamping { get { return m_SpringDamping; } set { if (OnPropertyChanging("CameraRecoilData." + nameof(SpringDamping), this, m_SpringDamping, value)) m_SpringDamping = value; } } // 0xC (12)
		
		protected float m_SpringMinThresholdAngle = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(130500136)]
		public float SpringMinThresholdAngle { get { return m_SpringMinThresholdAngle; } set { if (OnPropertyChanging("CameraRecoilData." + nameof(SpringMinThresholdAngle), this, m_SpringMinThresholdAngle, value)) m_SpringMinThresholdAngle = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3561415946:
					SpringConstant = (float) p_Value;
					break;

				case 1976598700:
					SpringDamping = (float) p_Value;
					break;

				case 130500136:
					SpringMinThresholdAngle = (float) p_Value;
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
				case 3561415946:
					return SpringConstant;

				case 1976598700:
					return SpringDamping;

				case 130500136:
					return SpringMinThresholdAngle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3561415946:
					return typeof(CameraRecoilData).GetProperty(nameof(SpringConstant));

				case 1976598700:
					return typeof(CameraRecoilData).GetProperty(nameof(SpringDamping));

				case 130500136:
					return typeof(CameraRecoilData).GetProperty(nameof(SpringMinThresholdAngle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
