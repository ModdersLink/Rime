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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 48)]
	public class Vec3EntityData : 
		EntityData
	{
		protected Vec3 m_DefaultValue = new Vec3();
		[ContainerField(Name: "DefaultValue", Offset: 16, NameHash: 2066049125, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DefaultValue { get { return m_DefaultValue; } set { if (OnPropertyChanging("Vec3EntityData." + nameof(DefaultValue), this, m_DefaultValue, value)) m_DefaultValue = value; } } // 0x10 (16)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 32, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("Vec3EntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2066049125:
					DefaultValue = (Vec3) p_Value;
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
				case 2066049125:
					return DefaultValue;

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
				case 2066049125:
					return typeof(Vec3EntityData).GetProperty(nameof(DefaultValue));

				case 229961746:
					return typeof(Vec3EntityData).GetProperty(nameof(Realm));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
