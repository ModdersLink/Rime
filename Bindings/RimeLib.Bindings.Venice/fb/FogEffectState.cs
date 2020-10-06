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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class FogEffectState : 
		DataContainer
	{
		protected Vec4 m_FogColorCurve = new Vec4();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1743450305)]
		public Vec4 FogColorCurve { get { return m_FogColorCurve; } set { if (OnPropertyChanging("FogEffectState." + nameof(FogColorCurve), this, m_FogColorCurve, value)) m_FogColorCurve = value; } } // 0x10 (16)
		
		protected Vec4 m_Curve = new Vec4();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(212866962)]
		public Vec4 Curve { get { return m_Curve; } set { if (OnPropertyChanging("FogEffectState." + nameof(Curve), this, m_Curve, value)) m_Curve = value; } } // 0x20 (32)
		
		protected Vec3 m_FogColor = new Vec3();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(361914486)]
		public Vec3 FogColor { get { return m_FogColor; } set { if (OnPropertyChanging("FogEffectState." + nameof(FogColor), this, m_FogColor, value)) m_FogColor = value; } } // 0x30 (48)
		
		protected float m_Start = new float();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(230748069)]
		public float Start { get { return m_Start; } set { if (OnPropertyChanging("FogEffectState." + nameof(Start), this, m_Start, value)) m_Start = value; } } // 0x40 (64)
		
		protected float m_End = new float();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(193438506)]
		public float End { get { return m_End; } set { if (OnPropertyChanging("FogEffectState." + nameof(End), this, m_End, value)) m_End = value; } } // 0x44 (68)
		
		protected float m_FogColorStart = new float();
		[ContainerField(72), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1725847734)]
		public float FogColorStart { get { return m_FogColorStart; } set { if (OnPropertyChanging("FogEffectState." + nameof(FogColorStart), this, m_FogColorStart, value)) m_FogColorStart = value; } } // 0x48 (72)
		
		protected float m_FogColorEnd = new float();
		[ContainerField(76), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(959976761)]
		public float FogColorEnd { get { return m_FogColorEnd; } set { if (OnPropertyChanging("FogEffectState." + nameof(FogColorEnd), this, m_FogColorEnd, value)) m_FogColorEnd = value; } } // 0x4C (76)
		
		protected float m_HeightFogVisibilityRange = new float();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2134547565)]
		public float HeightFogVisibilityRange { get { return m_HeightFogVisibilityRange; } set { if (OnPropertyChanging("FogEffectState." + nameof(HeightFogVisibilityRange), this, m_HeightFogVisibilityRange, value)) m_HeightFogVisibilityRange = value; } } // 0x50 (80)
		
		protected float m_TransparencyFadeStart = new float();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(986565259)]
		public float TransparencyFadeStart { get { return m_TransparencyFadeStart; } set { if (OnPropertyChanging("FogEffectState." + nameof(TransparencyFadeStart), this, m_TransparencyFadeStart, value)) m_TransparencyFadeStart = value; } } // 0x54 (84)
		
		protected float m_TransparencyFadeEnd = new float();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(994775812)]
		public float TransparencyFadeEnd { get { return m_TransparencyFadeEnd; } set { if (OnPropertyChanging("FogEffectState." + nameof(TransparencyFadeEnd), this, m_TransparencyFadeEnd, value)) m_TransparencyFadeEnd = value; } } // 0x58 (88)
		
		protected float m_TransparencyFadeClamp = new float();
		[ContainerField(92), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(967877752)]
		public float TransparencyFadeClamp { get { return m_TransparencyFadeClamp; } set { if (OnPropertyChanging("FogEffectState." + nameof(TransparencyFadeClamp), this, m_TransparencyFadeClamp, value)) m_TransparencyFadeClamp = value; } } // 0x5C (92)
		
		protected float m_HeightFogDepth = new float();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2648051353)]
		public float HeightFogDepth { get { return m_HeightFogDepth; } set { if (OnPropertyChanging("FogEffectState." + nameof(HeightFogDepth), this, m_HeightFogDepth, value)) m_HeightFogDepth = value; } } // 0x60 (96)
		
		protected float m_HeightFogFollowCamera = new float();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2492969564)]
		public float HeightFogFollowCamera { get { return m_HeightFogFollowCamera; } set { if (OnPropertyChanging("FogEffectState." + nameof(HeightFogFollowCamera), this, m_HeightFogFollowCamera, value)) m_HeightFogFollowCamera = value; } } // 0x64 (100)
		
		protected float m_HeightFogAltitude = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2293972388)]
		public float HeightFogAltitude { get { return m_HeightFogAltitude; } set { if (OnPropertyChanging("FogEffectState." + nameof(HeightFogAltitude), this, m_HeightFogAltitude, value)) m_HeightFogAltitude = value; } } // 0x68 (104)
		
		protected bool m_HeightFogEnable = new bool();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1467683669)]
		public bool HeightFogEnable { get { return m_HeightFogEnable; } set { if (OnPropertyChanging("FogEffectState." + nameof(HeightFogEnable), this, m_HeightFogEnable, value)) m_HeightFogEnable = value; } } // 0x6C (108)
		
		protected bool m_Enable = new bool();
		[ContainerField(109), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("FogEffectState." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x6D (109)
		
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
