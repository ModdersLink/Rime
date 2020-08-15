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
	public class TransformMultiplierEntityData : 
		EntityData
	{
		protected LinearTransform m_In1 = new LinearTransform();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(193450867)]
		public LinearTransform In1 { get { return m_In1; } set { if (OnPropertyChanging("TransformMultiplierEntityData." + nameof(In1), this, m_In1, value)) m_In1 = value; } } // 0x10 (16)
		
		protected LinearTransform m_In2 = new LinearTransform();
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(193450864)]
		public LinearTransform In2 { get { return m_In2; } set { if (OnPropertyChanging("TransformMultiplierEntityData." + nameof(In2), this, m_In2, value)) m_In2 = value; } } // 0x50 (80)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(144), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("TransformMultiplierEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x90 (144)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193450867:
					In1 = (LinearTransform) p_Value;
					break;

				case 193450864:
					In2 = (LinearTransform) p_Value;
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
				case 193450867:
					return In1;

				case 193450864:
					return In2;

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
				case 193450867:
					return typeof(TransformMultiplierEntityData).GetProperty(nameof(In1));

				case 193450864:
					return typeof(TransformMultiplierEntityData).GetProperty(nameof(In2));

				case 229961746:
					return typeof(TransformMultiplierEntityData).GetProperty(nameof(Realm));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
