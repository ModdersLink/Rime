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
	public class CharacterLightingComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BottomLight { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TopLight { get; set; } = new Vec3(); // 0x70 (112)
		
		[ContainerField(128)]
		public CharacterLightingMode CharacterLightingMode { get; set; } = new CharacterLightingMode(); // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float CameraUpRotation { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float TopLightDirY { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float BlendFactor { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float TopLightDirX { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public bool LockToCameraDirection { get; set; } // 0x94 (148)
		
		[ContainerField(149), LayoutImmutable, Blittable]
		public bool FirstPersonEnable { get; set; } // 0x95 (149)
		
		[ContainerField(150), LayoutImmutable, Blittable]
		public bool CharacterLightEnable { get; set; } // 0x96 (150)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 609828532:
					BottomLight = (Vec3) p_Value;
					break;

				case 2399334960:
					TopLight = (Vec3) p_Value;
					break;

				case 3372338465:
					CharacterLightingMode = (CharacterLightingMode) Enum.ToObject(typeof(CharacterLightingMode), p_Value);
					break;

				case 3569471469:
					CameraUpRotation = (float) p_Value;
					break;

				case 1588880502:
					TopLightDirY = (float) p_Value;
					break;

				case 2895077833:
					BlendFactor = (float) p_Value;
					break;

				case 1588880503:
					TopLightDirX = (float) p_Value;
					break;

				case 689897193:
					LockToCameraDirection = (bool) p_Value;
					break;

				case 2753363403:
					FirstPersonEnable = (bool) p_Value;
					break;

				case 3028030371:
					CharacterLightEnable = (bool) p_Value;
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
				case 609828532:
					return BottomLight;

				case 2399334960:
					return TopLight;

				case 3372338465:
					return CharacterLightingMode;

				case 3569471469:
					return CameraUpRotation;

				case 1588880502:
					return TopLightDirY;

				case 2895077833:
					return BlendFactor;

				case 1588880503:
					return TopLightDirX;

				case 689897193:
					return LockToCameraDirection;

				case 2753363403:
					return FirstPersonEnable;

				case 3028030371:
					return CharacterLightEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 609828532:
					return typeof(CharacterLightingComponentData).GetProperty(nameof(BottomLight));

				case 2399334960:
					return typeof(CharacterLightingComponentData).GetProperty(nameof(TopLight));

				case 3372338465:
					return typeof(CharacterLightingComponentData).GetProperty(nameof(CharacterLightingMode));

				case 3569471469:
					return typeof(CharacterLightingComponentData).GetProperty(nameof(CameraUpRotation));

				case 1588880502:
					return typeof(CharacterLightingComponentData).GetProperty(nameof(TopLightDirY));

				case 2895077833:
					return typeof(CharacterLightingComponentData).GetProperty(nameof(BlendFactor));

				case 1588880503:
					return typeof(CharacterLightingComponentData).GetProperty(nameof(TopLightDirX));

				case 689897193:
					return typeof(CharacterLightingComponentData).GetProperty(nameof(LockToCameraDirection));

				case 2753363403:
					return typeof(CharacterLightingComponentData).GetProperty(nameof(FirstPersonEnable));

				case 3028030371:
					return typeof(CharacterLightingComponentData).GetProperty(nameof(CharacterLightEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
