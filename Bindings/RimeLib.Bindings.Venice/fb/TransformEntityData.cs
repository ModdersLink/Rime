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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 96)]
	public class TransformEntityData : 
		EntityData
	{
		protected LinearTransform m_DefaultTransform = new LinearTransform();
		[ContainerField(Name: "DefaultTransform", Offset: 16, NameHash: 1812491362, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform DefaultTransform { get { return m_DefaultTransform; } set { if (OnPropertyChanging("TransformEntityData." + nameof(DefaultTransform), this, m_DefaultTransform, value)) m_DefaultTransform = value; } } // 0x10 (16)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 80, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("TransformEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x50 (80)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1812491362:
					DefaultTransform = (LinearTransform) p_Value;
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
				case 1812491362:
					return DefaultTransform;

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
				case 1812491362:
					return typeof(TransformEntityData).GetProperty(nameof(DefaultTransform));

				case 229961746:
					return typeof(TransformEntityData).GetProperty(nameof(Realm));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
