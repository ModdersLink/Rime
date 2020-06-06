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
	public class SniperLensScopeFilterData : 
		ScopeFilterData
	{
		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationStrengths { get; set; } = new Vec2(); // 0xC (12)
		
		[ContainerField(20), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 BlurCenter { get; set; } = new Vec2(); // 0x14 (20)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ChromaticAberrationColor1 { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ChromaticAberrationColor2 { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 RadialBlendDistanceCoefficients { get; set; } = new Vec2(); // 0x40 (64)
		
		[ContainerField(72), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationDisplacement1 { get; set; } = new Vec2(); // 0x48 (72)
		
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationDisplacement2 { get; set; } = new Vec2(); // 0x50 (80)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float BlurScale { get; set; } // 0x58 (88)
		
		[ContainerField(96)]
		public ColorTintData ColorTintData { get; set; } = new ColorTintData(); // 0x60 (96)
		
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
