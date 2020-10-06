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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(16), ContainerClass]
	public class MovingBodyData : 
		DataContainer
	{
		protected float m_Mass = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2088779625)]
		public float Mass { get { return m_Mass; } set { if (OnPropertyChanging("MovingBodyData." + nameof(Mass), this, m_Mass, value)) m_Mass = value; } } // 0x8 (8)
		
		protected float m_Inertia = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1681436809)]
		public float Inertia { get { return m_Inertia; } set { if (OnPropertyChanging("MovingBodyData." + nameof(Inertia), this, m_Inertia, value)) m_Inertia = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088779625:
					Mass = (float) p_Value;
					break;

				case 1681436809:
					Inertia = (float) p_Value;
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
				case 2088779625:
					return Mass;

				case 1681436809:
					return Inertia;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088779625:
					return typeof(MovingBodyData).GetProperty(nameof(Mass));

				case 1681436809:
					return typeof(MovingBodyData).GetProperty(nameof(Inertia));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
