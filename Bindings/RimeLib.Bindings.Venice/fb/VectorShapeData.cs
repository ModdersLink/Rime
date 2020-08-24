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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class VectorShapeData : 
		BaseShapeData
	{
		protected List<Vec3> m_Points = new List<Vec3>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(3383606106), ContainerArray]
		public List<Vec3> Points { get { return m_Points; } set { if (OnPropertyChanging("VectorShapeData." + nameof(Points), this, m_Points, value)) m_Points = value; } } // 0xC (12)
		
		protected List<Vec3> m_Normals = new List<Vec3>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(3102907301), ContainerArray]
		public List<Vec3> Normals { get { return m_Normals; } set { if (OnPropertyChanging("VectorShapeData." + nameof(Normals), this, m_Normals, value)) m_Normals = value; } } // 0x10 (16)
		
		protected float m_Tension = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3196074177)]
		public float Tension { get { return m_Tension; } set { if (OnPropertyChanging("VectorShapeData." + nameof(Tension), this, m_Tension, value)) m_Tension = value; } } // 0x14 (20)
		
		protected bool m_IsClosed = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1070153421)]
		public bool IsClosed { get { return m_IsClosed; } set { if (OnPropertyChanging("VectorShapeData." + nameof(IsClosed), this, m_IsClosed, value)) m_IsClosed = value; } } // 0x18 (24)
		
		protected bool m_AllowRoll = new bool();
		[ContainerField(25), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2314066145)]
		public bool AllowRoll { get { return m_AllowRoll; } set { if (OnPropertyChanging("VectorShapeData." + nameof(AllowRoll), this, m_AllowRoll, value)) m_AllowRoll = value; } } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3383606106:
					Points = (List<Vec3>) p_Value;
					break;

				case 3102907301:
					Normals = (List<Vec3>) p_Value;
					break;

				case 3196074177:
					Tension = (float) p_Value;
					break;

				case 1070153421:
					IsClosed = (bool) p_Value;
					break;

				case 2314066145:
					AllowRoll = (bool) p_Value;
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
				case 3383606106:
					return Points;

				case 3102907301:
					return Normals;

				case 3196074177:
					return Tension;

				case 1070153421:
					return IsClosed;

				case 2314066145:
					return AllowRoll;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3383606106:
					return typeof(VectorShapeData).GetProperty(nameof(Points));

				case 3102907301:
					return typeof(VectorShapeData).GetProperty(nameof(Normals));

				case 3196074177:
					return typeof(VectorShapeData).GetProperty(nameof(Tension));

				case 1070153421:
					return typeof(VectorShapeData).GetProperty(nameof(IsClosed));

				case 2314066145:
					return typeof(VectorShapeData).GetProperty(nameof(AllowRoll));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
