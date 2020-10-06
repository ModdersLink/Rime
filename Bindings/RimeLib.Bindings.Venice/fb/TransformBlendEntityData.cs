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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(160), ContainerClass]
	public class TransformBlendEntityData : 
		EntityData
	{
		protected LinearTransform m_In2 = new LinearTransform();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(193450864)]
		public LinearTransform In2 { get { return m_In2; } set { if (OnPropertyChanging("TransformBlendEntityData." + nameof(In2), this, m_In2, value)) m_In2 = value; } } // 0x10 (16)
		
		protected LinearTransform m_In1 = new LinearTransform();
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(193450867)]
		public LinearTransform In1 { get { return m_In1; } set { if (OnPropertyChanging("TransformBlendEntityData." + nameof(In1), this, m_In1, value)) m_In1 = value; } } // 0x50 (80)
		
		protected float m_BlendValue = new float();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(236872047)]
		public float BlendValue { get { return m_BlendValue; } set { if (OnPropertyChanging("TransformBlendEntityData." + nameof(BlendValue), this, m_BlendValue, value)) m_BlendValue = value; } } // 0x90 (144)
		
		protected float m_BlendValue2 = new float();
		[ContainerField(148), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3521810301)]
		public float BlendValue2 { get { return m_BlendValue2; } set { if (OnPropertyChanging("TransformBlendEntityData." + nameof(BlendValue2), this, m_BlendValue2, value)) m_BlendValue2 = value; } } // 0x94 (148)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(152), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("TransformBlendEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x98 (152)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193450864:
					In2 = (LinearTransform) p_Value;
					break;

				case 193450867:
					In1 = (LinearTransform) p_Value;
					break;

				case 236872047:
					BlendValue = (float) p_Value;
					break;

				case 3521810301:
					BlendValue2 = (float) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
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
				case 193450864:
					return In2;

				case 193450867:
					return In1;

				case 236872047:
					return BlendValue;

				case 3521810301:
					return BlendValue2;

				case 229961746:
					return Realm;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193450864:
					return typeof(TransformBlendEntityData).GetProperty(nameof(In2));

				case 193450867:
					return typeof(TransformBlendEntityData).GetProperty(nameof(In1));

				case 236872047:
					return typeof(TransformBlendEntityData).GetProperty(nameof(BlendValue));

				case 3521810301:
					return typeof(TransformBlendEntityData).GetProperty(nameof(BlendValue2));

				case 229961746:
					return typeof(TransformBlendEntityData).GetProperty(nameof(Realm));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
