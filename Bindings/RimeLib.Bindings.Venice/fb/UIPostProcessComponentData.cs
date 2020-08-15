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
	[ContainerType(4)]
	public class UIPostProcessComponentData : 
		UIComponentData
	{
		protected float m_HighlightThreshold = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(95158690)]
		public float HighlightThreshold { get { return m_HighlightThreshold; } set { if (OnPropertyChanging("UIPostProcessComponentData." + nameof(HighlightThreshold), this, m_HighlightThreshold, value)) m_HighlightThreshold = value; } } // 0x1C (28)
		
		protected float m_XPower = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(3629034434)]
		public float XPower { get { return m_XPower; } set { if (OnPropertyChanging("UIPostProcessComponentData." + nameof(XPower), this, m_XPower, value)) m_XPower = value; } } // 0x20 (32)
		
		protected float m_YPower = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(3442840483)]
		public float YPower { get { return m_YPower; } set { if (OnPropertyChanging("UIPostProcessComponentData." + nameof(YPower), this, m_YPower, value)) m_YPower = value; } } // 0x24 (36)
		
		protected float m_Distort = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(4177187398)]
		public float Distort { get { return m_Distort; } set { if (OnPropertyChanging("UIPostProcessComponentData." + nameof(Distort), this, m_Distort, value)) m_Distort = value; } } // 0x28 (40)
		
		protected float m_TimeScale = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(169511528)]
		public float TimeScale { get { return m_TimeScale; } set { if (OnPropertyChanging("UIPostProcessComponentData." + nameof(TimeScale), this, m_TimeScale, value)) m_TimeScale = value; } } // 0x2C (44)
		
		protected CtrRef<TextureAsset> m_NoiseTexture = new CtrRef<TextureAsset>();
		[ContainerField(48), ContainerFieldNameHash(3113175460)]
		public CtrRef<TextureAsset> NoiseTexture { get { return m_NoiseTexture; } set { if (OnPropertyChanging("UIPostProcessComponentData." + nameof(NoiseTexture), this, m_NoiseTexture, value)) m_NoiseTexture = value; } } // 0x30 (48)
		
		protected float m_Highlight = new float();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(2206773)]
		public float Highlight { get { return m_Highlight; } set { if (OnPropertyChanging("UIPostProcessComponentData." + nameof(Highlight), this, m_Highlight, value)) m_Highlight = value; } } // 0x34 (52)
		
		protected float m_RShift = new float();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(3246353367)]
		public float RShift { get { return m_RShift; } set { if (OnPropertyChanging("UIPostProcessComponentData." + nameof(RShift), this, m_RShift, value)) m_RShift = value; } } // 0x38 (56)
		
		protected float m_GShift = new float();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(2616832162)]
		public float GShift { get { return m_GShift; } set { if (OnPropertyChanging("UIPostProcessComponentData." + nameof(GShift), this, m_GShift, value)) m_GShift = value; } } // 0x3C (60)
		
		protected float m_BShift = new float();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(2658136519)]
		public float BShift { get { return m_BShift; } set { if (OnPropertyChanging("UIPostProcessComponentData." + nameof(BShift), this, m_BShift, value)) m_BShift = value; } } // 0x40 (64)
		
		protected bool m_TweakMode = new bool();
		[ContainerField(68), LayoutImmutable, Blittable, ContainerFieldNameHash(16411562)]
		public bool TweakMode { get { return m_TweakMode; } set { if (OnPropertyChanging("UIPostProcessComponentData." + nameof(TweakMode), this, m_TweakMode, value)) m_TweakMode = value; } } // 0x44 (68)
		
		protected bool m_Enabled = new bool();
		[ContainerField(69), LayoutImmutable, Blittable, ContainerFieldNameHash(2662400)]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("UIPostProcessComponentData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x45 (69)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 95158690:
					HighlightThreshold = (float) p_Value;
					break;

				case 3629034434:
					XPower = (float) p_Value;
					break;

				case 3442840483:
					YPower = (float) p_Value;
					break;

				case 4177187398:
					Distort = (float) p_Value;
					break;

				case 169511528:
					TimeScale = (float) p_Value;
					break;

				case 3113175460:
					NoiseTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2206773:
					Highlight = (float) p_Value;
					break;

				case 3246353367:
					RShift = (float) p_Value;
					break;

				case 2616832162:
					GShift = (float) p_Value;
					break;

				case 2658136519:
					BShift = (float) p_Value;
					break;

				case 16411562:
					TweakMode = (bool) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 95158690:
					return HighlightThreshold;

				case 3629034434:
					return XPower;

				case 3442840483:
					return YPower;

				case 4177187398:
					return Distort;

				case 169511528:
					return TimeScale;

				case 3113175460:
					return NoiseTexture;

				case 2206773:
					return Highlight;

				case 3246353367:
					return RShift;

				case 2616832162:
					return GShift;

				case 2658136519:
					return BShift;

				case 16411562:
					return TweakMode;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 95158690:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(HighlightThreshold));

				case 3629034434:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(XPower));

				case 3442840483:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(YPower));

				case 4177187398:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(Distort));

				case 169511528:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(TimeScale));

				case 3113175460:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(NoiseTexture));

				case 2206773:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(Highlight));

				case 3246353367:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(RShift));

				case 2616832162:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(GShift));

				case 2658136519:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(BShift));

				case 16411562:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(TweakMode));

				case 2662400:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
