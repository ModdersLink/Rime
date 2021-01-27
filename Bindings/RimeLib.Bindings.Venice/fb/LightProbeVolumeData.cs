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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class LightProbeVolumeData : 
		SpatialEntityData
	{
		protected uint m_Xres = new uint();
		[ContainerField(Name: "Xres", Offset: 80, NameHash: 2089724057, Flags: 49421), LayoutImmutable, Blittable]
		public uint Xres { get { return m_Xres; } set { if (OnPropertyChanging("LightProbeVolumeData." + nameof(Xres), this, m_Xres, value)) m_Xres = value; } } // 0x50 (80)
		
		protected uint m_Yres = new uint();
		[ContainerField(Name: "Yres", Offset: 84, NameHash: 2089479288, Flags: 49421), LayoutImmutable, Blittable]
		public uint Yres { get { return m_Yres; } set { if (OnPropertyChanging("LightProbeVolumeData." + nameof(Yres), this, m_Yres, value)) m_Yres = value; } } // 0x54 (84)
		
		protected uint m_Zres = new uint();
		[ContainerField(Name: "Zres", Offset: 88, NameHash: 2089652315, Flags: 49421), LayoutImmutable, Blittable]
		public uint Zres { get { return m_Zres; } set { if (OnPropertyChanging("LightProbeVolumeData." + nameof(Zres), this, m_Zres, value)) m_Zres = value; } } // 0x58 (88)
		
		protected float m_BlendDistance = new float();
		[ContainerField(Name: "BlendDistance", Offset: 92, NameHash: 1435233063, Flags: 49469), LayoutImmutable, Blittable]
		public float BlendDistance { get { return m_BlendDistance; } set { if (OnPropertyChanging("LightProbeVolumeData." + nameof(BlendDistance), this, m_BlendDistance, value)) m_BlendDistance = value; } } // 0x5C (92)
		
		protected int m_Priority = new int();
		[ContainerField(Name: "Priority", Offset: 96, NameHash: 3062102871, Flags: 49405), LayoutImmutable, Blittable]
		public int Priority { get { return m_Priority; } set { if (OnPropertyChanging("LightProbeVolumeData." + nameof(Priority), this, m_Priority, value)) m_Priority = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089724057:
					Xres = (uint) p_Value;
					break;

				case 2089479288:
					Yres = (uint) p_Value;
					break;

				case 2089652315:
					Zres = (uint) p_Value;
					break;

				case 1435233063:
					BlendDistance = (float) p_Value;
					break;

				case 3062102871:
					Priority = (int) p_Value;
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
				case 2089724057:
					return Xres;

				case 2089479288:
					return Yres;

				case 2089652315:
					return Zres;

				case 1435233063:
					return BlendDistance;

				case 3062102871:
					return Priority;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089724057:
					return typeof(LightProbeVolumeData).GetProperty(nameof(Xres));

				case 2089479288:
					return typeof(LightProbeVolumeData).GetProperty(nameof(Yres));

				case 2089652315:
					return typeof(LightProbeVolumeData).GetProperty(nameof(Zres));

				case 1435233063:
					return typeof(LightProbeVolumeData).GetProperty(nameof(BlendDistance));

				case 3062102871:
					return typeof(LightProbeVolumeData).GetProperty(nameof(Priority));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
