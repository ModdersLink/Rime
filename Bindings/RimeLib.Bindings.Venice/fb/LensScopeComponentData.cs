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
	public class LensScopeComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ChromaticAberrationColor1 { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 RadialBlendDistanceCoefficients { get; set; } = new Vec2(); // 0x70 (112)
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ChromaticAberrationColor2 { get; set; } = new Vec3(); // 0x80 (128)
		
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 BlurCenter { get; set; } = new Vec2(); // 0x90 (144)
		
		[ContainerField(152), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationDisplacement2 { get; set; } = new Vec2(); // 0x98 (152)
		
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationDisplacement1 { get; set; } = new Vec2(); // 0xA0 (160)
		
		[ContainerField(168), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationStrengths { get; set; } = new Vec2(); // 0xA8 (168)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float BlurScale { get; set; } // 0xB0 (176)
		
		[ContainerField(180)]
		public Realm Realm { get; set; } = new Realm(); // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0xB8 (184)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4192735318:
					ChromaticAberrationColor1 = (Vec3) p_Value;
					break;

				case 3576198450:
					RadialBlendDistanceCoefficients = (Vec2) p_Value;
					break;

				case 4192735317:
					ChromaticAberrationColor2 = (Vec3) p_Value;
					break;

				case 1149921575:
					BlurCenter = (Vec2) p_Value;
					break;

				case 2269770719:
					ChromaticAberrationDisplacement2 = (Vec2) p_Value;
					break;

				case 2269770716:
					ChromaticAberrationDisplacement1 = (Vec2) p_Value;
					break;

				case 1096301260:
					ChromaticAberrationStrengths = (Vec2) p_Value;
					break;

				case 3568105332:
					BlurScale = (float) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
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
				case 4192735318:
					return ChromaticAberrationColor1;

				case 3576198450:
					return RadialBlendDistanceCoefficients;

				case 4192735317:
					return ChromaticAberrationColor2;

				case 1149921575:
					return BlurCenter;

				case 2269770719:
					return ChromaticAberrationDisplacement2;

				case 2269770716:
					return ChromaticAberrationDisplacement1;

				case 1096301260:
					return ChromaticAberrationStrengths;

				case 3568105332:
					return BlurScale;

				case 229961746:
					return Realm;

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
				case 4192735318:
					return typeof(LensScopeComponentData).GetProperty(nameof(ChromaticAberrationColor1));

				case 3576198450:
					return typeof(LensScopeComponentData).GetProperty(nameof(RadialBlendDistanceCoefficients));

				case 4192735317:
					return typeof(LensScopeComponentData).GetProperty(nameof(ChromaticAberrationColor2));

				case 1149921575:
					return typeof(LensScopeComponentData).GetProperty(nameof(BlurCenter));

				case 2269770719:
					return typeof(LensScopeComponentData).GetProperty(nameof(ChromaticAberrationDisplacement2));

				case 2269770716:
					return typeof(LensScopeComponentData).GetProperty(nameof(ChromaticAberrationDisplacement1));

				case 1096301260:
					return typeof(LensScopeComponentData).GetProperty(nameof(ChromaticAberrationStrengths));

				case 3568105332:
					return typeof(LensScopeComponentData).GetProperty(nameof(BlurScale));

				case 229961746:
					return typeof(LensScopeComponentData).GetProperty(nameof(Realm));

				case 2342790116:
					return typeof(LensScopeComponentData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
