///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class DofComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new Realm(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float NearDistanceScale { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float FocusDistance { get; set; } // 0x68 (104)
		
		[ContainerField(108)]
		public BlurFilter BlurFilter { get; set; } = new BlurFilter(); // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float BlurFilterDeviation { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float FarDistanceScale { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float BlurAdd { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float Scale { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float DiffusionDofFocalLength { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float DiffusionDofAperture { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public bool DiffusionDofEnable { get; set; } // 0x88 (136)
		
		[ContainerField(137), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x89 (137)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 4096748582:
					NearDistanceScale = (float) p_Value;
					break;

				case 1402926186:
					FocusDistance = (float) p_Value;
					break;

				case 1032953036:
					BlurFilter = (BlurFilter) Enum.ToObject(typeof(BlurFilter), p_Value);
					break;

				case 2875622063:
					BlurFilterDeviation = (float) p_Value;
					break;

				case 4048208907:
					FarDistanceScale = (float) p_Value;
					break;

				case 2736421901:
					BlurAdd = (float) p_Value;
					break;

				case 231223453:
					Scale = (float) p_Value;
					break;

				case 2682742320:
					DiffusionDofFocalLength = (float) p_Value;
					break;

				case 530293403:
					DiffusionDofAperture = (float) p_Value;
					break;

				case 830589130:
					DiffusionDofEnable = (bool) p_Value;
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
				case 229961746:
					return Realm;

				case 4096748582:
					return NearDistanceScale;

				case 1402926186:
					return FocusDistance;

				case 1032953036:
					return BlurFilter;

				case 2875622063:
					return BlurFilterDeviation;

				case 4048208907:
					return FarDistanceScale;

				case 2736421901:
					return BlurAdd;

				case 231223453:
					return Scale;

				case 2682742320:
					return DiffusionDofFocalLength;

				case 530293403:
					return DiffusionDofAperture;

				case 830589130:
					return DiffusionDofEnable;

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
				case 229961746:
					return typeof(DofComponentData).GetProperty(nameof(Realm));

				case 4096748582:
					return typeof(DofComponentData).GetProperty(nameof(NearDistanceScale));

				case 1402926186:
					return typeof(DofComponentData).GetProperty(nameof(FocusDistance));

				case 1032953036:
					return typeof(DofComponentData).GetProperty(nameof(BlurFilter));

				case 2875622063:
					return typeof(DofComponentData).GetProperty(nameof(BlurFilterDeviation));

				case 4048208907:
					return typeof(DofComponentData).GetProperty(nameof(FarDistanceScale));

				case 2736421901:
					return typeof(DofComponentData).GetProperty(nameof(BlurAdd));

				case 231223453:
					return typeof(DofComponentData).GetProperty(nameof(Scale));

				case 2682742320:
					return typeof(DofComponentData).GetProperty(nameof(DiffusionDofFocalLength));

				case 530293403:
					return typeof(DofComponentData).GetProperty(nameof(DiffusionDofAperture));

				case 830589130:
					return typeof(DofComponentData).GetProperty(nameof(DiffusionDofEnable));

				case 2342790116:
					return typeof(DofComponentData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
