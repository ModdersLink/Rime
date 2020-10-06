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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(544), ContainerClass]
	public class TransformHubEntityData : 
		EntityData
	{
		protected LinearTransform m_In4 = new LinearTransform();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(193450870)]
		public LinearTransform In4 { get { return m_In4; } set { if (OnPropertyChanging("TransformHubEntityData." + nameof(In4), this, m_In4, value)) m_In4 = value; } } // 0x10 (16)
		
		protected LinearTransform m_In1 = new LinearTransform();
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(193450867)]
		public LinearTransform In1 { get { return m_In1; } set { if (OnPropertyChanging("TransformHubEntityData." + nameof(In1), this, m_In1, value)) m_In1 = value; } } // 0x50 (80)
		
		protected LinearTransform m_In2 = new LinearTransform();
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(193450864)]
		public LinearTransform In2 { get { return m_In2; } set { if (OnPropertyChanging("TransformHubEntityData." + nameof(In2), this, m_In2, value)) m_In2 = value; } } // 0x90 (144)
		
		protected LinearTransform m_In3 = new LinearTransform();
		[ContainerField(208), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(193450865)]
		public LinearTransform In3 { get { return m_In3; } set { if (OnPropertyChanging("TransformHubEntityData." + nameof(In3), this, m_In3, value)) m_In3 = value; } } // 0xD0 (208)
		
		protected LinearTransform m_In8 = new LinearTransform();
		[ContainerField(272), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(193450874)]
		public LinearTransform In8 { get { return m_In8; } set { if (OnPropertyChanging("TransformHubEntityData." + nameof(In8), this, m_In8, value)) m_In8 = value; } } // 0x110 (272)
		
		protected LinearTransform m_In5 = new LinearTransform();
		[ContainerField(336), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(193450871)]
		public LinearTransform In5 { get { return m_In5; } set { if (OnPropertyChanging("TransformHubEntityData." + nameof(In5), this, m_In5, value)) m_In5 = value; } } // 0x150 (336)
		
		protected LinearTransform m_In6 = new LinearTransform();
		[ContainerField(400), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(193450868)]
		public LinearTransform In6 { get { return m_In6; } set { if (OnPropertyChanging("TransformHubEntityData." + nameof(In6), this, m_In6, value)) m_In6 = value; } } // 0x190 (400)
		
		protected LinearTransform m_In7 = new LinearTransform();
		[ContainerField(464), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(193450869)]
		public LinearTransform In7 { get { return m_In7; } set { if (OnPropertyChanging("TransformHubEntityData." + nameof(In7), this, m_In7, value)) m_In7 = value; } } // 0x1D0 (464)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(528), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("TransformHubEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x210 (528)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193450870:
					In4 = (LinearTransform) p_Value;
					break;

				case 193450867:
					In1 = (LinearTransform) p_Value;
					break;

				case 193450864:
					In2 = (LinearTransform) p_Value;
					break;

				case 193450865:
					In3 = (LinearTransform) p_Value;
					break;

				case 193450874:
					In8 = (LinearTransform) p_Value;
					break;

				case 193450871:
					In5 = (LinearTransform) p_Value;
					break;

				case 193450868:
					In6 = (LinearTransform) p_Value;
					break;

				case 193450869:
					In7 = (LinearTransform) p_Value;
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
				case 193450870:
					return In4;

				case 193450867:
					return In1;

				case 193450864:
					return In2;

				case 193450865:
					return In3;

				case 193450874:
					return In8;

				case 193450871:
					return In5;

				case 193450868:
					return In6;

				case 193450869:
					return In7;

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
				case 193450870:
					return typeof(TransformHubEntityData).GetProperty(nameof(In4));

				case 193450867:
					return typeof(TransformHubEntityData).GetProperty(nameof(In1));

				case 193450864:
					return typeof(TransformHubEntityData).GetProperty(nameof(In2));

				case 193450865:
					return typeof(TransformHubEntityData).GetProperty(nameof(In3));

				case 193450874:
					return typeof(TransformHubEntityData).GetProperty(nameof(In8));

				case 193450871:
					return typeof(TransformHubEntityData).GetProperty(nameof(In5));

				case 193450868:
					return typeof(TransformHubEntityData).GetProperty(nameof(In6));

				case 193450869:
					return typeof(TransformHubEntityData).GetProperty(nameof(In7));

				case 229961746:
					return typeof(TransformHubEntityData).GetProperty(nameof(Realm));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
