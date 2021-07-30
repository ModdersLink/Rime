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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class ViewFxData : 
		DataContainer
	{
		protected PoissonRadialBlurData m_PoissonRadialBlur = new PoissonRadialBlurData();
		[ContainerField(Name: "PoissonRadialBlur", Offset: 8, NameHash: 838527112, Flags: 41)]
		public PoissonRadialBlurData PoissonRadialBlur { get { return m_PoissonRadialBlur; } set { if (OnPropertyChanging("ViewFxData." + nameof(PoissonRadialBlur), this, m_PoissonRadialBlur, value)) m_PoissonRadialBlur = value; } } // 0x8 (8)
		
		protected ColorTintData m_ColorTint = new ColorTintData();
		[ContainerField(Name: "ColorTint", Offset: 32, NameHash: 518108063, Flags: 41)]
		public ColorTintData ColorTint { get { return m_ColorTint; } set { if (OnPropertyChanging("ViewFxData." + nameof(ColorTint), this, m_ColorTint, value)) m_ColorTint = value; } } // 0x20 (32)
		
		protected float m_BlurAdd = new float();
		[ContainerField(Name: "BlurAdd", Offset: 96, NameHash: 2736421901, Flags: 49469), LayoutImmutable, Blittable]
		public float BlurAdd { get { return m_BlurAdd; } set { if (OnPropertyChanging("ViewFxData." + nameof(BlurAdd), this, m_BlurAdd, value)) m_BlurAdd = value; } } // 0x60 (96)
		
		protected bool m_ColorTintEnable = new bool();
		[ContainerField(Name: "ColorTintEnable", Offset: 100, NameHash: 596952702, Flags: 49325), LayoutImmutable, Blittable]
		public bool ColorTintEnable { get { return m_ColorTintEnable; } set { if (OnPropertyChanging("ViewFxData." + nameof(ColorTintEnable), this, m_ColorTintEnable, value)) m_ColorTintEnable = value; } } // 0x64 (100)
		
		protected bool m_PoissonRadialBlurEnable = new bool();
		[ContainerField(Name: "PoissonRadialBlurEnable", Offset: 101, NameHash: 2327396521, Flags: 49325), LayoutImmutable, Blittable]
		public bool PoissonRadialBlurEnable { get { return m_PoissonRadialBlurEnable; } set { if (OnPropertyChanging("ViewFxData." + nameof(PoissonRadialBlurEnable), this, m_PoissonRadialBlurEnable, value)) m_PoissonRadialBlurEnable = value; } } // 0x65 (101)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 838527112:
					PoissonRadialBlur = (PoissonRadialBlurData) p_Value;
					break;

				case 518108063:
					ColorTint = (ColorTintData) p_Value;
					break;

				case 2736421901:
					BlurAdd = (float) p_Value;
					break;

				case 596952702:
					ColorTintEnable = (bool) p_Value;
					break;

				case 2327396521:
					PoissonRadialBlurEnable = (bool) p_Value;
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
				case 838527112:
					return PoissonRadialBlur;

				case 518108063:
					return ColorTint;

				case 2736421901:
					return BlurAdd;

				case 596952702:
					return ColorTintEnable;

				case 2327396521:
					return PoissonRadialBlurEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 838527112:
					return typeof(ViewFxData).GetProperty(nameof(PoissonRadialBlur));

				case 518108063:
					return typeof(ViewFxData).GetProperty(nameof(ColorTint));

				case 2736421901:
					return typeof(ViewFxData).GetProperty(nameof(BlurAdd));

				case 596952702:
					return typeof(ViewFxData).GetProperty(nameof(ColorTintEnable));

				case 2327396521:
					return typeof(ViewFxData).GetProperty(nameof(PoissonRadialBlurEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
