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
	public class VecSplitterEntityData : 
		EntityData
	{
		protected Vec3 m_Vec3 = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2089241862)]
		public Vec3 Vec3 { get { return m_Vec3; } set { if (OnPropertyChanging("VecSplitterEntityData." + nameof(Vec3), this, m_Vec3, value)) m_Vec3 = value; } } // 0x10 (16)
		
		protected Vec4 m_Vec4 = new Vec4();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2089241857)]
		public Vec4 Vec4 { get { return m_Vec4; } set { if (OnPropertyChanging("VecSplitterEntityData." + nameof(Vec4), this, m_Vec4, value)) m_Vec4 = value; } } // 0x20 (32)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(48), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("VecSplitterEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089241862:
					Vec3 = (Vec3) p_Value;
					break;

				case 2089241857:
					Vec4 = (Vec4) p_Value;
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
				case 2089241862:
					return Vec3;

				case 2089241857:
					return Vec4;

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
				case 2089241862:
					return typeof(VecSplitterEntityData).GetProperty(nameof(Vec3));

				case 2089241857:
					return typeof(VecSplitterEntityData).GetProperty(nameof(Vec4));

				case 229961746:
					return typeof(VecSplitterEntityData).GetProperty(nameof(Realm));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
