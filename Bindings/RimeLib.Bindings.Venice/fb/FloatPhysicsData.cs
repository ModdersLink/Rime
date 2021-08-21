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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class FloatPhysicsData : 
		DataContainer
	{
		protected float m_Density = new float();
		[ContainerField(Name: "Density", Offset: 8, NameHash: 4008572221, Flags: 49469), LayoutImmutable, Blittable]
		public float Density { get { return m_Density; } set { if (OnPropertyChanging("FloatPhysicsData." + nameof(Density), this, m_Density, value)) m_Density = value; } } // 0x8 (8)
		
		protected float m_FilledDensity = new float();
		[ContainerField(Name: "FilledDensity", Offset: 12, NameHash: 1851378675, Flags: 49469), LayoutImmutable, Blittable]
		public float FilledDensity { get { return m_FilledDensity; } set { if (OnPropertyChanging("FloatPhysicsData." + nameof(FilledDensity), this, m_FilledDensity, value)) m_FilledDensity = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4008572221:
					Density = (float) p_Value;
					break;

				case 1851378675:
					FilledDensity = (float) p_Value;
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
				case 4008572221:
					return Density;

				case 1851378675:
					return FilledDensity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4008572221:
					return typeof(FloatPhysicsData).GetProperty(nameof(Density));

				case 1851378675:
					return typeof(FloatPhysicsData).GetProperty(nameof(FilledDensity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
