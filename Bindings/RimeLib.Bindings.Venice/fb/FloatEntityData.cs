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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class FloatEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("FloatEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected float m_DefaultValue = new float();
		[ContainerField(Name: "DefaultValue", Offset: 16, NameHash: 2066049125, Flags: 49469), LayoutImmutable, Blittable]
		public float DefaultValue { get { return m_DefaultValue; } set { if (OnPropertyChanging("FloatEntityData." + nameof(DefaultValue), this, m_DefaultValue, value)) m_DefaultValue = value; } } // 0x10 (16)
		
		protected float m_IncDecValue = new float();
		[ContainerField(Name: "IncDecValue", Offset: 20, NameHash: 3097399752, Flags: 49469), LayoutImmutable, Blittable]
		public float IncDecValue { get { return m_IncDecValue; } set { if (OnPropertyChanging("FloatEntityData." + nameof(IncDecValue), this, m_IncDecValue, value)) m_IncDecValue = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2066049125:
					DefaultValue = (float) p_Value;
					break;

				case 3097399752:
					IncDecValue = (float) p_Value;
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
				case 229961746:
					return Realm;

				case 2066049125:
					return DefaultValue;

				case 3097399752:
					return IncDecValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(FloatEntityData).GetProperty(nameof(Realm));

				case 2066049125:
					return typeof(FloatEntityData).GetProperty(nameof(DefaultValue));

				case 3097399752:
					return typeof(FloatEntityData).GetProperty(nameof(IncDecValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
