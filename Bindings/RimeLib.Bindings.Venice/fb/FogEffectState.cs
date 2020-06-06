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
	public class FogEffectState : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 FogColorCurve { get; set; } = new Vec4(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Curve { get; set; } = new Vec4(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 FogColor { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float Start { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float End { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float FogColorStart { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float FogColorEnd { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float HeightFogVisibilityRange { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float TransparencyFadeStart { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float TransparencyFadeEnd { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float TransparencyFadeClamp { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float HeightFogDepth { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float HeightFogFollowCamera { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float HeightFogAltitude { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool HeightFogEnable { get; set; } // 0x6C (108)
		
		[ContainerField(109), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x6D (109)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1743450305:
					FogColorCurve = (Vec4) p_Value;
					break;

				case 212866962:
					Curve = (Vec4) p_Value;
					break;

				case 361914486:
					FogColor = (Vec3) p_Value;
					break;

				case 230748069:
					Start = (float) p_Value;
					break;

				case 193438506:
					End = (float) p_Value;
					break;

				case 1725847734:
					FogColorStart = (float) p_Value;
					break;

				case 959976761:
					FogColorEnd = (float) p_Value;
					break;

				case 2134547565:
					HeightFogVisibilityRange = (float) p_Value;
					break;

				case 986565259:
					TransparencyFadeStart = (float) p_Value;
					break;

				case 994775812:
					TransparencyFadeEnd = (float) p_Value;
					break;

				case 967877752:
					TransparencyFadeClamp = (float) p_Value;
					break;

				case 2648051353:
					HeightFogDepth = (float) p_Value;
					break;

				case 2492969564:
					HeightFogFollowCamera = (float) p_Value;
					break;

				case 2293972388:
					HeightFogAltitude = (float) p_Value;
					break;

				case 1467683669:
					HeightFogEnable = (bool) p_Value;
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
				case 1743450305:
					return FogColorCurve;

				case 212866962:
					return Curve;

				case 361914486:
					return FogColor;

				case 230748069:
					return Start;

				case 193438506:
					return End;

				case 1725847734:
					return FogColorStart;

				case 959976761:
					return FogColorEnd;

				case 2134547565:
					return HeightFogVisibilityRange;

				case 986565259:
					return TransparencyFadeStart;

				case 994775812:
					return TransparencyFadeEnd;

				case 967877752:
					return TransparencyFadeClamp;

				case 2648051353:
					return HeightFogDepth;

				case 2492969564:
					return HeightFogFollowCamera;

				case 2293972388:
					return HeightFogAltitude;

				case 1467683669:
					return HeightFogEnable;

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
				case 1743450305:
					return typeof(FogEffectState).GetProperty(nameof(FogColorCurve));

				case 212866962:
					return typeof(FogEffectState).GetProperty(nameof(Curve));

				case 361914486:
					return typeof(FogEffectState).GetProperty(nameof(FogColor));

				case 230748069:
					return typeof(FogEffectState).GetProperty(nameof(Start));

				case 193438506:
					return typeof(FogEffectState).GetProperty(nameof(End));

				case 1725847734:
					return typeof(FogEffectState).GetProperty(nameof(FogColorStart));

				case 959976761:
					return typeof(FogEffectState).GetProperty(nameof(FogColorEnd));

				case 2134547565:
					return typeof(FogEffectState).GetProperty(nameof(HeightFogVisibilityRange));

				case 986565259:
					return typeof(FogEffectState).GetProperty(nameof(TransparencyFadeStart));

				case 994775812:
					return typeof(FogEffectState).GetProperty(nameof(TransparencyFadeEnd));

				case 967877752:
					return typeof(FogEffectState).GetProperty(nameof(TransparencyFadeClamp));

				case 2648051353:
					return typeof(FogEffectState).GetProperty(nameof(HeightFogDepth));

				case 2492969564:
					return typeof(FogEffectState).GetProperty(nameof(HeightFogFollowCamera));

				case 2293972388:
					return typeof(FogEffectState).GetProperty(nameof(HeightFogAltitude));

				case 1467683669:
					return typeof(FogEffectState).GetProperty(nameof(HeightFogEnable));

				case 2342790116:
					return typeof(FogEffectState).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
