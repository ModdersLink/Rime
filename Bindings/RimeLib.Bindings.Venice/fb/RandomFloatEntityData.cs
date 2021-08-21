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
	public class RandomFloatEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("RandomFloatEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected float m_Min = new float();
		[ContainerField(Name: "Min", Offset: 16, NameHash: 193446607, Flags: 49469), LayoutImmutable, Blittable]
		public float Min { get { return m_Min; } set { if (OnPropertyChanging("RandomFloatEntityData." + nameof(Min), this, m_Min, value)) m_Min = value; } } // 0x10 (16)
		
		protected float m_Max = new float();
		[ContainerField(Name: "Max", Offset: 20, NameHash: 193446865, Flags: 49469), LayoutImmutable, Blittable]
		public float Max { get { return m_Max; } set { if (OnPropertyChanging("RandomFloatEntityData." + nameof(Max), this, m_Max, value)) m_Max = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 193446607:
					Min = (float) p_Value;
					break;

				case 193446865:
					Max = (float) p_Value;
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

				case 193446607:
					return Min;

				case 193446865:
					return Max;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(RandomFloatEntityData).GetProperty(nameof(Realm));

				case 193446607:
					return typeof(RandomFloatEntityData).GetProperty(nameof(Min));

				case 193446865:
					return typeof(RandomFloatEntityData).GetProperty(nameof(Max));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
