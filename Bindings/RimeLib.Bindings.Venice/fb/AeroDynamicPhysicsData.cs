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
	public class AeroDynamicPhysicsData : 
		DataContainer
	{
		protected Vec3 m_BodyDrag = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(1687378661)]
		public Vec3 BodyDrag { get { return m_BodyDrag; } set { if (OnPropertyChanging("AeroDynamicPhysicsData." + nameof(BodyDrag), this, m_BodyDrag, value)) m_BodyDrag = value; } } // 0x10 (16)
		
		protected Vec3 m_BodyDragOffsetYZ = new Vec3();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2051746155)]
		public Vec3 BodyDragOffsetYZ { get { return m_BodyDragOffsetYZ; } set { if (OnPropertyChanging("AeroDynamicPhysicsData." + nameof(BodyDragOffsetYZ), this, m_BodyDragOffsetYZ, value)) m_BodyDragOffsetYZ = value; } } // 0x20 (32)
		
		protected Vec3 m_BodyDragOffsetXZ = new Vec3();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2051746122)]
		public Vec3 BodyDragOffsetXZ { get { return m_BodyDragOffsetXZ; } set { if (OnPropertyChanging("AeroDynamicPhysicsData." + nameof(BodyDragOffsetXZ), this, m_BodyDragOffsetXZ, value)) m_BodyDragOffsetXZ = value; } } // 0x30 (48)
		
		protected Vec3 m_BodyDragOffsetXY = new Vec3();
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2051746121)]
		public Vec3 BodyDragOffsetXY { get { return m_BodyDragOffsetXY; } set { if (OnPropertyChanging("AeroDynamicPhysicsData." + nameof(BodyDragOffsetXY), this, m_BodyDragOffsetXY, value)) m_BodyDragOffsetXY = value; } } // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1687378661:
					BodyDrag = (Vec3) p_Value;
					break;

				case 2051746155:
					BodyDragOffsetYZ = (Vec3) p_Value;
					break;

				case 2051746122:
					BodyDragOffsetXZ = (Vec3) p_Value;
					break;

				case 2051746121:
					BodyDragOffsetXY = (Vec3) p_Value;
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
				case 1687378661:
					return BodyDrag;

				case 2051746155:
					return BodyDragOffsetYZ;

				case 2051746122:
					return BodyDragOffsetXZ;

				case 2051746121:
					return BodyDragOffsetXY;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1687378661:
					return typeof(AeroDynamicPhysicsData).GetProperty(nameof(BodyDrag));

				case 2051746155:
					return typeof(AeroDynamicPhysicsData).GetProperty(nameof(BodyDragOffsetYZ));

				case 2051746122:
					return typeof(AeroDynamicPhysicsData).GetProperty(nameof(BodyDragOffsetXZ));

				case 2051746121:
					return typeof(AeroDynamicPhysicsData).GetProperty(nameof(BodyDragOffsetXY));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
