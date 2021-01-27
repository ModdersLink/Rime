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
	public class AABBData : 
		BaseShapeData
	{
		protected Vec3 m_Position = new Vec3();
		[ContainerField(Name: "Position", Offset: 16, NameHash: 3402582524, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get { return m_Position; } set { if (OnPropertyChanging("AABBData." + nameof(Position), this, m_Position, value)) m_Position = value; } } // 0x10 (16)
		
		protected Vec3 m_HalfExtents = new Vec3();
		[ContainerField(Name: "HalfExtents", Offset: 32, NameHash: 905253763, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 HalfExtents { get { return m_HalfExtents; } set { if (OnPropertyChanging("AABBData." + nameof(HalfExtents), this, m_HalfExtents, value)) m_HalfExtents = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3402582524:
					Position = (Vec3) p_Value;
					break;

				case 905253763:
					HalfExtents = (Vec3) p_Value;
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
				case 3402582524:
					return Position;

				case 905253763:
					return HalfExtents;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3402582524:
					return typeof(AABBData).GetProperty(nameof(Position));

				case 905253763:
					return typeof(AABBData).GetProperty(nameof(HalfExtents));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
