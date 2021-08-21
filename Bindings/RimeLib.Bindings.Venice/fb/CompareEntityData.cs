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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class CompareEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("CompareEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected CompareOp m_Operator = new CompareOp();
		[ContainerField(Name: "Operator", Offset: 16, NameHash: 2153507813, Flags: 137)]
		public CompareOp Operator { get { return m_Operator; } set { if (OnPropertyChanging("CompareEntityData." + nameof(Operator), this, m_Operator, value)) m_Operator = value; } } // 0x10 (16)
		
		protected float m_FloatIn0 = new float();
		[ContainerField(Name: "FloatIn0", Offset: 20, NameHash: 1718513826, Flags: 49469), LayoutImmutable, Blittable]
		public float FloatIn0 { get { return m_FloatIn0; } set { if (OnPropertyChanging("CompareEntityData." + nameof(FloatIn0), this, m_FloatIn0, value)) m_FloatIn0 = value; } } // 0x14 (20)
		
		protected float m_FloatIn1 = new float();
		[ContainerField(Name: "FloatIn1", Offset: 24, NameHash: 1718513827, Flags: 49469), LayoutImmutable, Blittable]
		public float FloatIn1 { get { return m_FloatIn1; } set { if (OnPropertyChanging("CompareEntityData." + nameof(FloatIn1), this, m_FloatIn1, value)) m_FloatIn1 = value; } } // 0x18 (24)
		
		protected int m_IntIn0 = new int();
		[ContainerField(Name: "IntIn0", Offset: 28, NameHash: 2784473121, Flags: 49405), LayoutImmutable, Blittable]
		public int IntIn0 { get { return m_IntIn0; } set { if (OnPropertyChanging("CompareEntityData." + nameof(IntIn0), this, m_IntIn0, value)) m_IntIn0 = value; } } // 0x1C (28)
		
		protected int m_IntIn1 = new int();
		[ContainerField(Name: "IntIn1", Offset: 32, NameHash: 2784473120, Flags: 49405), LayoutImmutable, Blittable]
		public int IntIn1 { get { return m_IntIn1; } set { if (OnPropertyChanging("CompareEntityData." + nameof(IntIn1), this, m_IntIn1, value)) m_IntIn1 = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2153507813:
					Operator = (CompareOp) Enum.ToObject(typeof(CompareOp), p_Value);
					break;

				case 1718513826:
					FloatIn0 = (float) p_Value;
					break;

				case 1718513827:
					FloatIn1 = (float) p_Value;
					break;

				case 2784473121:
					IntIn0 = (int) p_Value;
					break;

				case 2784473120:
					IntIn1 = (int) p_Value;
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

				case 2153507813:
					return Operator;

				case 1718513826:
					return FloatIn0;

				case 1718513827:
					return FloatIn1;

				case 2784473121:
					return IntIn0;

				case 2784473120:
					return IntIn1;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(CompareEntityData).GetProperty(nameof(Realm));

				case 2153507813:
					return typeof(CompareEntityData).GetProperty(nameof(Operator));

				case 1718513826:
					return typeof(CompareEntityData).GetProperty(nameof(FloatIn0));

				case 1718513827:
					return typeof(CompareEntityData).GetProperty(nameof(FloatIn1));

				case 2784473121:
					return typeof(CompareEntityData).GetProperty(nameof(IntIn0));

				case 2784473120:
					return typeof(CompareEntityData).GetProperty(nameof(IntIn1));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
