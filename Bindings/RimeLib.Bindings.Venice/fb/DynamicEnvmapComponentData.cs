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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 160)]
	public class DynamicEnvmapComponentData : 
		ComponentData
	{
		protected Vec3 m_KeyColorEnvmap = new Vec3();
		[ContainerField(Name: "KeyColorEnvmap", Offset: 96, NameHash: 1689648046, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 KeyColorEnvmap { get { return m_KeyColorEnvmap; } set { if (OnPropertyChanging("DynamicEnvmapComponentData." + nameof(KeyColorEnvmap), this, m_KeyColorEnvmap, value)) m_KeyColorEnvmap = value; } } // 0x60 (96)
		
		protected Vec3 m_GroundColorEnvmap = new Vec3();
		[ContainerField(Name: "GroundColorEnvmap", Offset: 112, NameHash: 3864914716, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 GroundColorEnvmap { get { return m_GroundColorEnvmap; } set { if (OnPropertyChanging("DynamicEnvmapComponentData." + nameof(GroundColorEnvmap), this, m_GroundColorEnvmap, value)) m_GroundColorEnvmap = value; } } // 0x70 (112)
		
		protected Vec3 m_SkyColorEnvmap = new Vec3();
		[ContainerField(Name: "SkyColorEnvmap", Offset: 128, NameHash: 297337912, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyColorEnvmap { get { return m_SkyColorEnvmap; } set { if (OnPropertyChanging("DynamicEnvmapComponentData." + nameof(SkyColorEnvmap), this, m_SkyColorEnvmap, value)) m_SkyColorEnvmap = value; } } // 0x80 (128)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 144, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("DynamicEnvmapComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x90 (144)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1689648046:
					KeyColorEnvmap = (Vec3) p_Value;
					break;

				case 3864914716:
					GroundColorEnvmap = (Vec3) p_Value;
					break;

				case 297337912:
					SkyColorEnvmap = (Vec3) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
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
				case 1689648046:
					return KeyColorEnvmap;

				case 3864914716:
					return GroundColorEnvmap;

				case 297337912:
					return SkyColorEnvmap;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1689648046:
					return typeof(DynamicEnvmapComponentData).GetProperty(nameof(KeyColorEnvmap));

				case 3864914716:
					return typeof(DynamicEnvmapComponentData).GetProperty(nameof(GroundColorEnvmap));

				case 297337912:
					return typeof(DynamicEnvmapComponentData).GetProperty(nameof(SkyColorEnvmap));

				case 2342790116:
					return typeof(DynamicEnvmapComponentData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
