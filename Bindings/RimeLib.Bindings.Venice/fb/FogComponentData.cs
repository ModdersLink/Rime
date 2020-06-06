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
	public class FogComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Curve { get; set; } = new Vec4(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 FogColorCurve { get; set; } = new Vec4(); // 0x70 (112)
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 FogColor { get; set; } = new Vec3(); // 0x80 (128)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float FogColorStart { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float FogDistanceMultiplier { get; set; } // 0x94 (148)
		
		[ContainerField(152)]
		public Realm Realm { get; set; } = new Realm(); // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float End { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float TransparencyFadeStart { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float Start { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float TransparencyFadeEnd { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public float FogColorEnd { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float TransparencyFadeClamp { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float HeightFogVisibilityRange { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float HeightFogAltitude { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public float HeightFogDepth { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public float HeightFogFollowCamera { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public bool FogGradientEnable { get; set; } // 0xC4 (196)
		
		[ContainerField(197), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0xC5 (197)
		
		[ContainerField(198), LayoutImmutable, Blittable]
		public bool HeightFogEnable { get; set; } // 0xC6 (198)
		
		[ContainerField(199), LayoutImmutable, Blittable]
		public bool FogColorEnable { get; set; } // 0xC7 (199)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 212866962:
					Curve = (Vec4) p_Value;
					break;

				case 1743450305:
					FogColorCurve = (Vec4) p_Value;
					break;

				case 361914486:
					FogColor = (Vec3) p_Value;
					break;

				case 1725847734:
					FogColorStart = (float) p_Value;
					break;

				case 2043637059:
					FogDistanceMultiplier = (float) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 193438506:
					End = (float) p_Value;
					break;

				case 986565259:
					TransparencyFadeStart = (float) p_Value;
					break;

				case 230748069:
					Start = (float) p_Value;
					break;

				case 994775812:
					TransparencyFadeEnd = (float) p_Value;
					break;

				case 959976761:
					FogColorEnd = (float) p_Value;
					break;

				case 967877752:
					TransparencyFadeClamp = (float) p_Value;
					break;

				case 2134547565:
					HeightFogVisibilityRange = (float) p_Value;
					break;

				case 2293972388:
					HeightFogAltitude = (float) p_Value;
					break;

				case 2648051353:
					HeightFogDepth = (float) p_Value;
					break;

				case 2492969564:
					HeightFogFollowCamera = (float) p_Value;
					break;

				case 669336364:
					FogGradientEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 1467683669:
					HeightFogEnable = (bool) p_Value;
					break;

				case 1507686231:
					FogColorEnable = (bool) p_Value;
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
				case 212866962:
					return Curve;

				case 1743450305:
					return FogColorCurve;

				case 361914486:
					return FogColor;

				case 1725847734:
					return FogColorStart;

				case 2043637059:
					return FogDistanceMultiplier;

				case 229961746:
					return Realm;

				case 193438506:
					return End;

				case 986565259:
					return TransparencyFadeStart;

				case 230748069:
					return Start;

				case 994775812:
					return TransparencyFadeEnd;

				case 959976761:
					return FogColorEnd;

				case 967877752:
					return TransparencyFadeClamp;

				case 2134547565:
					return HeightFogVisibilityRange;

				case 2293972388:
					return HeightFogAltitude;

				case 2648051353:
					return HeightFogDepth;

				case 2492969564:
					return HeightFogFollowCamera;

				case 669336364:
					return FogGradientEnable;

				case 2342790116:
					return Enable;

				case 1467683669:
					return HeightFogEnable;

				case 1507686231:
					return FogColorEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 212866962:
					return typeof(FogComponentData).GetProperty(nameof(Curve));

				case 1743450305:
					return typeof(FogComponentData).GetProperty(nameof(FogColorCurve));

				case 361914486:
					return typeof(FogComponentData).GetProperty(nameof(FogColor));

				case 1725847734:
					return typeof(FogComponentData).GetProperty(nameof(FogColorStart));

				case 2043637059:
					return typeof(FogComponentData).GetProperty(nameof(FogDistanceMultiplier));

				case 229961746:
					return typeof(FogComponentData).GetProperty(nameof(Realm));

				case 193438506:
					return typeof(FogComponentData).GetProperty(nameof(End));

				case 986565259:
					return typeof(FogComponentData).GetProperty(nameof(TransparencyFadeStart));

				case 230748069:
					return typeof(FogComponentData).GetProperty(nameof(Start));

				case 994775812:
					return typeof(FogComponentData).GetProperty(nameof(TransparencyFadeEnd));

				case 959976761:
					return typeof(FogComponentData).GetProperty(nameof(FogColorEnd));

				case 967877752:
					return typeof(FogComponentData).GetProperty(nameof(TransparencyFadeClamp));

				case 2134547565:
					return typeof(FogComponentData).GetProperty(nameof(HeightFogVisibilityRange));

				case 2293972388:
					return typeof(FogComponentData).GetProperty(nameof(HeightFogAltitude));

				case 2648051353:
					return typeof(FogComponentData).GetProperty(nameof(HeightFogDepth));

				case 2492969564:
					return typeof(FogComponentData).GetProperty(nameof(HeightFogFollowCamera));

				case 669336364:
					return typeof(FogComponentData).GetProperty(nameof(FogGradientEnable));

				case 2342790116:
					return typeof(FogComponentData).GetProperty(nameof(Enable));

				case 1467683669:
					return typeof(FogComponentData).GetProperty(nameof(HeightFogEnable));

				case 1507686231:
					return typeof(FogComponentData).GetProperty(nameof(FogColorEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
