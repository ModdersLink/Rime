///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class LightProbeVolumeData : 
		SpatialEntityData
	{
		[ContainerField(80), LayoutImmutable, Blittable]
		public uint Xres { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public uint Yres { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public uint Zres { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float BlendDistance { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public int Priority { get; set; } // 0x60 (96)
		
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
