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
	public class CharacterLightingComponentData : 
		ComponentData
	{
		protected Vec3 m_BottomLight = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(609828532)]
		public Vec3 BottomLight { get { return m_BottomLight; } set { if (OnPropertyChanging("CharacterLightingComponentData." + nameof(BottomLight), this, m_BottomLight, value)) m_BottomLight = value; } } // 0x60 (96)
		
		protected Vec3 m_TopLight = new Vec3();
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2399334960)]
		public Vec3 TopLight { get { return m_TopLight; } set { if (OnPropertyChanging("CharacterLightingComponentData." + nameof(TopLight), this, m_TopLight, value)) m_TopLight = value; } } // 0x70 (112)
		
		protected CharacterLightingMode m_CharacterLightingMode = new CharacterLightingMode();
		[ContainerField(128), ContainerFieldNameHash(3372338465)]
		public CharacterLightingMode CharacterLightingMode { get { return m_CharacterLightingMode; } set { if (OnPropertyChanging("CharacterLightingComponentData." + nameof(CharacterLightingMode), this, m_CharacterLightingMode, value)) m_CharacterLightingMode = value; } } // 0x80 (128)
		
		protected float m_CameraUpRotation = new float();
		[ContainerField(132), LayoutImmutable, Blittable, ContainerFieldNameHash(3569471469)]
		public float CameraUpRotation { get { return m_CameraUpRotation; } set { if (OnPropertyChanging("CharacterLightingComponentData." + nameof(CameraUpRotation), this, m_CameraUpRotation, value)) m_CameraUpRotation = value; } } // 0x84 (132)
		
		protected float m_TopLightDirY = new float();
		[ContainerField(136), LayoutImmutable, Blittable, ContainerFieldNameHash(1588880502)]
		public float TopLightDirY { get { return m_TopLightDirY; } set { if (OnPropertyChanging("CharacterLightingComponentData." + nameof(TopLightDirY), this, m_TopLightDirY, value)) m_TopLightDirY = value; } } // 0x88 (136)
		
		protected float m_BlendFactor = new float();
		[ContainerField(140), LayoutImmutable, Blittable, ContainerFieldNameHash(2895077833)]
		public float BlendFactor { get { return m_BlendFactor; } set { if (OnPropertyChanging("CharacterLightingComponentData." + nameof(BlendFactor), this, m_BlendFactor, value)) m_BlendFactor = value; } } // 0x8C (140)
		
		protected float m_TopLightDirX = new float();
		[ContainerField(144), LayoutImmutable, Blittable, ContainerFieldNameHash(1588880503)]
		public float TopLightDirX { get { return m_TopLightDirX; } set { if (OnPropertyChanging("CharacterLightingComponentData." + nameof(TopLightDirX), this, m_TopLightDirX, value)) m_TopLightDirX = value; } } // 0x90 (144)
		
		protected bool m_LockToCameraDirection = new bool();
		[ContainerField(148), LayoutImmutable, Blittable, ContainerFieldNameHash(689897193)]
		public bool LockToCameraDirection { get { return m_LockToCameraDirection; } set { if (OnPropertyChanging("CharacterLightingComponentData." + nameof(LockToCameraDirection), this, m_LockToCameraDirection, value)) m_LockToCameraDirection = value; } } // 0x94 (148)
		
		protected bool m_FirstPersonEnable = new bool();
		[ContainerField(149), LayoutImmutable, Blittable, ContainerFieldNameHash(2753363403)]
		public bool FirstPersonEnable { get { return m_FirstPersonEnable; } set { if (OnPropertyChanging("CharacterLightingComponentData." + nameof(FirstPersonEnable), this, m_FirstPersonEnable, value)) m_FirstPersonEnable = value; } } // 0x95 (149)
		
		protected bool m_CharacterLightEnable = new bool();
		[ContainerField(150), LayoutImmutable, Blittable, ContainerFieldNameHash(3028030371)]
		public bool CharacterLightEnable { get { return m_CharacterLightEnable; } set { if (OnPropertyChanging("CharacterLightingComponentData." + nameof(CharacterLightEnable), this, m_CharacterLightEnable, value)) m_CharacterLightEnable = value; } } // 0x96 (150)
		
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
