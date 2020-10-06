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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(192), ContainerClass]
	public class LensScopeComponentData : 
		ComponentData
	{
		protected Vec3 m_ChromaticAberrationColor1 = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(4192735318)]
		public Vec3 ChromaticAberrationColor1 { get { return m_ChromaticAberrationColor1; } set { if (OnPropertyChanging("LensScopeComponentData." + nameof(ChromaticAberrationColor1), this, m_ChromaticAberrationColor1, value)) m_ChromaticAberrationColor1 = value; } } // 0x60 (96)
		
		protected Vec2 m_RadialBlendDistanceCoefficients = new Vec2();
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3576198450)]
		public Vec2 RadialBlendDistanceCoefficients { get { return m_RadialBlendDistanceCoefficients; } set { if (OnPropertyChanging("LensScopeComponentData." + nameof(RadialBlendDistanceCoefficients), this, m_RadialBlendDistanceCoefficients, value)) m_RadialBlendDistanceCoefficients = value; } } // 0x70 (112)
		
		protected Vec3 m_ChromaticAberrationColor2 = new Vec3();
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(4192735317)]
		public Vec3 ChromaticAberrationColor2 { get { return m_ChromaticAberrationColor2; } set { if (OnPropertyChanging("LensScopeComponentData." + nameof(ChromaticAberrationColor2), this, m_ChromaticAberrationColor2, value)) m_ChromaticAberrationColor2 = value; } } // 0x80 (128)
		
		protected Vec2 m_BlurCenter = new Vec2();
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1149921575)]
		public Vec2 BlurCenter { get { return m_BlurCenter; } set { if (OnPropertyChanging("LensScopeComponentData." + nameof(BlurCenter), this, m_BlurCenter, value)) m_BlurCenter = value; } } // 0x90 (144)
		
		protected Vec2 m_ChromaticAberrationDisplacement2 = new Vec2();
		[ContainerField(152), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2269770719)]
		public Vec2 ChromaticAberrationDisplacement2 { get { return m_ChromaticAberrationDisplacement2; } set { if (OnPropertyChanging("LensScopeComponentData." + nameof(ChromaticAberrationDisplacement2), this, m_ChromaticAberrationDisplacement2, value)) m_ChromaticAberrationDisplacement2 = value; } } // 0x98 (152)
		
		protected Vec2 m_ChromaticAberrationDisplacement1 = new Vec2();
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2269770716)]
		public Vec2 ChromaticAberrationDisplacement1 { get { return m_ChromaticAberrationDisplacement1; } set { if (OnPropertyChanging("LensScopeComponentData." + nameof(ChromaticAberrationDisplacement1), this, m_ChromaticAberrationDisplacement1, value)) m_ChromaticAberrationDisplacement1 = value; } } // 0xA0 (160)
		
		protected Vec2 m_ChromaticAberrationStrengths = new Vec2();
		[ContainerField(168), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1096301260)]
		public Vec2 ChromaticAberrationStrengths { get { return m_ChromaticAberrationStrengths; } set { if (OnPropertyChanging("LensScopeComponentData." + nameof(ChromaticAberrationStrengths), this, m_ChromaticAberrationStrengths, value)) m_ChromaticAberrationStrengths = value; } } // 0xA8 (168)
		
		protected float m_BlurScale = new float();
		[ContainerField(176), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3568105332)]
		public float BlurScale { get { return m_BlurScale; } set { if (OnPropertyChanging("LensScopeComponentData." + nameof(BlurScale), this, m_BlurScale, value)) m_BlurScale = value; } } // 0xB0 (176)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(180), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("LensScopeComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xB4 (180)
		
		protected bool m_Enable = new bool();
		[ContainerField(184), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("LensScopeComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0xB8 (184)
		
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
