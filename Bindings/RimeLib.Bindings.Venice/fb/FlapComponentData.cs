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
	[ContainerType(16)]
	public class FlapComponentData : 
		PartComponentData
	{
		protected RotationAxisEnum m_RotationAxis = new RotationAxisEnum();
		[ContainerField(112), ContainerFieldNameHash(3148542130)]
		public RotationAxisEnum RotationAxis { get { return m_RotationAxis; } set { if (OnPropertyChanging("FlapComponentData." + nameof(RotationAxis), this, m_RotationAxis, value)) m_RotationAxis = value; } } // 0x70 (112)
		
		protected float m_RotationScale = new float();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(801800009)]
		public float RotationScale { get { return m_RotationScale; } set { if (OnPropertyChanging("FlapComponentData." + nameof(RotationScale), this, m_RotationScale, value)) m_RotationScale = value; } } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3148542130:
					RotationAxis = (RotationAxisEnum) Enum.ToObject(typeof(RotationAxisEnum), p_Value);
					break;

				case 801800009:
					RotationScale = (float) p_Value;
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
				case 3148542130:
					return RotationAxis;

				case 801800009:
					return RotationScale;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3148542130:
					return typeof(FlapComponentData).GetProperty(nameof(RotationAxis));

				case 801800009:
					return typeof(FlapComponentData).GetProperty(nameof(RotationScale));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
