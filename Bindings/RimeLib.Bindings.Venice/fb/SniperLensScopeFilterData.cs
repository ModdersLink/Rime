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
	public class SniperLensScopeFilterData : 
		ScopeFilterData
	{
		protected Vec2 m_ChromaticAberrationStrengths = new Vec2();
		[ContainerField(Name: "ChromaticAberrationStrengths", Offset: 12, NameHash: 1096301260, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationStrengths { get { return m_ChromaticAberrationStrengths; } set { if (OnPropertyChanging("SniperLensScopeFilterData." + nameof(ChromaticAberrationStrengths), this, m_ChromaticAberrationStrengths, value)) m_ChromaticAberrationStrengths = value; } } // 0xC (12)
		
		protected Vec2 m_BlurCenter = new Vec2();
		[ContainerField(Name: "BlurCenter", Offset: 20, NameHash: 1149921575, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 BlurCenter { get { return m_BlurCenter; } set { if (OnPropertyChanging("SniperLensScopeFilterData." + nameof(BlurCenter), this, m_BlurCenter, value)) m_BlurCenter = value; } } // 0x14 (20)
		
		protected Vec3 m_ChromaticAberrationColor1 = new Vec3();
		[ContainerField(Name: "ChromaticAberrationColor1", Offset: 32, NameHash: 4192735318, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ChromaticAberrationColor1 { get { return m_ChromaticAberrationColor1; } set { if (OnPropertyChanging("SniperLensScopeFilterData." + nameof(ChromaticAberrationColor1), this, m_ChromaticAberrationColor1, value)) m_ChromaticAberrationColor1 = value; } } // 0x20 (32)
		
		protected Vec3 m_ChromaticAberrationColor2 = new Vec3();
		[ContainerField(Name: "ChromaticAberrationColor2", Offset: 48, NameHash: 4192735317, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ChromaticAberrationColor2 { get { return m_ChromaticAberrationColor2; } set { if (OnPropertyChanging("SniperLensScopeFilterData." + nameof(ChromaticAberrationColor2), this, m_ChromaticAberrationColor2, value)) m_ChromaticAberrationColor2 = value; } } // 0x30 (48)
		
		protected Vec2 m_RadialBlendDistanceCoefficients = new Vec2();
		[ContainerField(Name: "RadialBlendDistanceCoefficients", Offset: 64, NameHash: 3576198450, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 RadialBlendDistanceCoefficients { get { return m_RadialBlendDistanceCoefficients; } set { if (OnPropertyChanging("SniperLensScopeFilterData." + nameof(RadialBlendDistanceCoefficients), this, m_RadialBlendDistanceCoefficients, value)) m_RadialBlendDistanceCoefficients = value; } } // 0x40 (64)
		
		protected Vec2 m_ChromaticAberrationDisplacement1 = new Vec2();
		[ContainerField(Name: "ChromaticAberrationDisplacement1", Offset: 72, NameHash: 2269770716, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationDisplacement1 { get { return m_ChromaticAberrationDisplacement1; } set { if (OnPropertyChanging("SniperLensScopeFilterData." + nameof(ChromaticAberrationDisplacement1), this, m_ChromaticAberrationDisplacement1, value)) m_ChromaticAberrationDisplacement1 = value; } } // 0x48 (72)
		
		protected Vec2 m_ChromaticAberrationDisplacement2 = new Vec2();
		[ContainerField(Name: "ChromaticAberrationDisplacement2", Offset: 80, NameHash: 2269770719, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationDisplacement2 { get { return m_ChromaticAberrationDisplacement2; } set { if (OnPropertyChanging("SniperLensScopeFilterData." + nameof(ChromaticAberrationDisplacement2), this, m_ChromaticAberrationDisplacement2, value)) m_ChromaticAberrationDisplacement2 = value; } } // 0x50 (80)
		
		protected float m_BlurScale = new float();
		[ContainerField(Name: "BlurScale", Offset: 88, NameHash: 3568105332, Flags: 49469), LayoutImmutable, Blittable]
		public float BlurScale { get { return m_BlurScale; } set { if (OnPropertyChanging("SniperLensScopeFilterData." + nameof(BlurScale), this, m_BlurScale, value)) m_BlurScale = value; } } // 0x58 (88)
		
		protected ColorTintData m_ColorTintData = new ColorTintData();
		[ContainerField(Name: "ColorTintData", Offset: 96, NameHash: 1503443055, Flags: 41)]
		public ColorTintData ColorTintData { get { return m_ColorTintData; } set { if (OnPropertyChanging("SniperLensScopeFilterData." + nameof(ColorTintData), this, m_ColorTintData, value)) m_ColorTintData = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1096301260:
					ChromaticAberrationStrengths = (Vec2) p_Value;
					break;

				case 1149921575:
					BlurCenter = (Vec2) p_Value;
					break;

				case 4192735318:
					ChromaticAberrationColor1 = (Vec3) p_Value;
					break;

				case 4192735317:
					ChromaticAberrationColor2 = (Vec3) p_Value;
					break;

				case 3576198450:
					RadialBlendDistanceCoefficients = (Vec2) p_Value;
					break;

				case 2269770716:
					ChromaticAberrationDisplacement1 = (Vec2) p_Value;
					break;

				case 2269770719:
					ChromaticAberrationDisplacement2 = (Vec2) p_Value;
					break;

				case 3568105332:
					BlurScale = (float) p_Value;
					break;

				case 1503443055:
					ColorTintData = (ColorTintData) p_Value;
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
				case 1096301260:
					return ChromaticAberrationStrengths;

				case 1149921575:
					return BlurCenter;

				case 4192735318:
					return ChromaticAberrationColor1;

				case 4192735317:
					return ChromaticAberrationColor2;

				case 3576198450:
					return RadialBlendDistanceCoefficients;

				case 2269770716:
					return ChromaticAberrationDisplacement1;

				case 2269770719:
					return ChromaticAberrationDisplacement2;

				case 3568105332:
					return BlurScale;

				case 1503443055:
					return ColorTintData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1096301260:
					return typeof(SniperLensScopeFilterData).GetProperty(nameof(ChromaticAberrationStrengths));

				case 1149921575:
					return typeof(SniperLensScopeFilterData).GetProperty(nameof(BlurCenter));

				case 4192735318:
					return typeof(SniperLensScopeFilterData).GetProperty(nameof(ChromaticAberrationColor1));

				case 4192735317:
					return typeof(SniperLensScopeFilterData).GetProperty(nameof(ChromaticAberrationColor2));

				case 3576198450:
					return typeof(SniperLensScopeFilterData).GetProperty(nameof(RadialBlendDistanceCoefficients));

				case 2269770716:
					return typeof(SniperLensScopeFilterData).GetProperty(nameof(ChromaticAberrationDisplacement1));

				case 2269770719:
					return typeof(SniperLensScopeFilterData).GetProperty(nameof(ChromaticAberrationDisplacement2));

				case 3568105332:
					return typeof(SniperLensScopeFilterData).GetProperty(nameof(BlurScale));

				case 1503443055:
					return typeof(SniperLensScopeFilterData).GetProperty(nameof(ColorTintData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
