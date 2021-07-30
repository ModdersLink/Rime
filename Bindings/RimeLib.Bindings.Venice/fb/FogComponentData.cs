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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 208)]
	public class FogComponentData : 
		ComponentData
	{
		protected Vec4 m_Curve = new Vec4();
		[ContainerField(Name: "Curve", Offset: 96, NameHash: 212866962, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Curve { get { return m_Curve; } set { if (OnPropertyChanging("FogComponentData." + nameof(Curve), this, m_Curve, value)) m_Curve = value; } } // 0x60 (96)
		
		protected Vec4 m_FogColorCurve = new Vec4();
		[ContainerField(Name: "FogColorCurve", Offset: 112, NameHash: 1743450305, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 FogColorCurve { get { return m_FogColorCurve; } set { if (OnPropertyChanging("FogComponentData." + nameof(FogColorCurve), this, m_FogColorCurve, value)) m_FogColorCurve = value; } } // 0x70 (112)
		
		protected Vec3 m_FogColor = new Vec3();
		[ContainerField(Name: "FogColor", Offset: 128, NameHash: 361914486, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 FogColor { get { return m_FogColor; } set { if (OnPropertyChanging("FogComponentData." + nameof(FogColor), this, m_FogColor, value)) m_FogColor = value; } } // 0x80 (128)
		
		protected float m_FogColorStart = new float();
		[ContainerField(Name: "FogColorStart", Offset: 144, NameHash: 1725847734, Flags: 49469), LayoutImmutable, Blittable]
		public float FogColorStart { get { return m_FogColorStart; } set { if (OnPropertyChanging("FogComponentData." + nameof(FogColorStart), this, m_FogColorStart, value)) m_FogColorStart = value; } } // 0x90 (144)
		
		protected float m_FogDistanceMultiplier = new float();
		[ContainerField(Name: "FogDistanceMultiplier", Offset: 148, NameHash: 2043637059, Flags: 49469), LayoutImmutable, Blittable]
		public float FogDistanceMultiplier { get { return m_FogDistanceMultiplier; } set { if (OnPropertyChanging("FogComponentData." + nameof(FogDistanceMultiplier), this, m_FogDistanceMultiplier, value)) m_FogDistanceMultiplier = value; } } // 0x94 (148)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 152, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("FogComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x98 (152)
		
		protected float m_End = new float();
		[ContainerField(Name: "End", Offset: 156, NameHash: 193438506, Flags: 49469), LayoutImmutable, Blittable]
		public float End { get { return m_End; } set { if (OnPropertyChanging("FogComponentData." + nameof(End), this, m_End, value)) m_End = value; } } // 0x9C (156)
		
		protected float m_TransparencyFadeStart = new float();
		[ContainerField(Name: "TransparencyFadeStart", Offset: 160, NameHash: 986565259, Flags: 49469), LayoutImmutable, Blittable]
		public float TransparencyFadeStart { get { return m_TransparencyFadeStart; } set { if (OnPropertyChanging("FogComponentData." + nameof(TransparencyFadeStart), this, m_TransparencyFadeStart, value)) m_TransparencyFadeStart = value; } } // 0xA0 (160)
		
		protected float m_Start = new float();
		[ContainerField(Name: "Start", Offset: 164, NameHash: 230748069, Flags: 49469), LayoutImmutable, Blittable]
		public float Start { get { return m_Start; } set { if (OnPropertyChanging("FogComponentData." + nameof(Start), this, m_Start, value)) m_Start = value; } } // 0xA4 (164)
		
		protected float m_TransparencyFadeEnd = new float();
		[ContainerField(Name: "TransparencyFadeEnd", Offset: 168, NameHash: 994775812, Flags: 49469), LayoutImmutable, Blittable]
		public float TransparencyFadeEnd { get { return m_TransparencyFadeEnd; } set { if (OnPropertyChanging("FogComponentData." + nameof(TransparencyFadeEnd), this, m_TransparencyFadeEnd, value)) m_TransparencyFadeEnd = value; } } // 0xA8 (168)
		
		protected float m_FogColorEnd = new float();
		[ContainerField(Name: "FogColorEnd", Offset: 172, NameHash: 959976761, Flags: 49469), LayoutImmutable, Blittable]
		public float FogColorEnd { get { return m_FogColorEnd; } set { if (OnPropertyChanging("FogComponentData." + nameof(FogColorEnd), this, m_FogColorEnd, value)) m_FogColorEnd = value; } } // 0xAC (172)
		
		protected float m_TransparencyFadeClamp = new float();
		[ContainerField(Name: "TransparencyFadeClamp", Offset: 176, NameHash: 967877752, Flags: 49469), LayoutImmutable, Blittable]
		public float TransparencyFadeClamp { get { return m_TransparencyFadeClamp; } set { if (OnPropertyChanging("FogComponentData." + nameof(TransparencyFadeClamp), this, m_TransparencyFadeClamp, value)) m_TransparencyFadeClamp = value; } } // 0xB0 (176)
		
		protected float m_HeightFogVisibilityRange = new float();
		[ContainerField(Name: "HeightFogVisibilityRange", Offset: 180, NameHash: 2134547565, Flags: 49469), LayoutImmutable, Blittable]
		public float HeightFogVisibilityRange { get { return m_HeightFogVisibilityRange; } set { if (OnPropertyChanging("FogComponentData." + nameof(HeightFogVisibilityRange), this, m_HeightFogVisibilityRange, value)) m_HeightFogVisibilityRange = value; } } // 0xB4 (180)
		
		protected float m_HeightFogAltitude = new float();
		[ContainerField(Name: "HeightFogAltitude", Offset: 184, NameHash: 2293972388, Flags: 49469), LayoutImmutable, Blittable]
		public float HeightFogAltitude { get { return m_HeightFogAltitude; } set { if (OnPropertyChanging("FogComponentData." + nameof(HeightFogAltitude), this, m_HeightFogAltitude, value)) m_HeightFogAltitude = value; } } // 0xB8 (184)
		
		protected float m_HeightFogDepth = new float();
		[ContainerField(Name: "HeightFogDepth", Offset: 188, NameHash: 2648051353, Flags: 49469), LayoutImmutable, Blittable]
		public float HeightFogDepth { get { return m_HeightFogDepth; } set { if (OnPropertyChanging("FogComponentData." + nameof(HeightFogDepth), this, m_HeightFogDepth, value)) m_HeightFogDepth = value; } } // 0xBC (188)
		
		protected float m_HeightFogFollowCamera = new float();
		[ContainerField(Name: "HeightFogFollowCamera", Offset: 192, NameHash: 2492969564, Flags: 49469), LayoutImmutable, Blittable]
		public float HeightFogFollowCamera { get { return m_HeightFogFollowCamera; } set { if (OnPropertyChanging("FogComponentData." + nameof(HeightFogFollowCamera), this, m_HeightFogFollowCamera, value)) m_HeightFogFollowCamera = value; } } // 0xC0 (192)
		
		protected bool m_FogGradientEnable = new bool();
		[ContainerField(Name: "FogGradientEnable", Offset: 196, NameHash: 669336364, Flags: 49325), LayoutImmutable, Blittable]
		public bool FogGradientEnable { get { return m_FogGradientEnable; } set { if (OnPropertyChanging("FogComponentData." + nameof(FogGradientEnable), this, m_FogGradientEnable, value)) m_FogGradientEnable = value; } } // 0xC4 (196)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 197, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("FogComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0xC5 (197)
		
		protected bool m_HeightFogEnable = new bool();
		[ContainerField(Name: "HeightFogEnable", Offset: 198, NameHash: 1467683669, Flags: 49325), LayoutImmutable, Blittable]
		public bool HeightFogEnable { get { return m_HeightFogEnable; } set { if (OnPropertyChanging("FogComponentData." + nameof(HeightFogEnable), this, m_HeightFogEnable, value)) m_HeightFogEnable = value; } } // 0xC6 (198)
		
		protected bool m_FogColorEnable = new bool();
		[ContainerField(Name: "FogColorEnable", Offset: 199, NameHash: 1507686231, Flags: 49325), LayoutImmutable, Blittable]
		public bool FogColorEnable { get { return m_FogColorEnable; } set { if (OnPropertyChanging("FogComponentData." + nameof(FogColorEnable), this, m_FogColorEnable, value)) m_FogColorEnable = value; } } // 0xC7 (199)
		
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
