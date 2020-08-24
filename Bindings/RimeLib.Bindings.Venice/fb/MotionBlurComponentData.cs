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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class MotionBlurComponentData : 
		ComponentData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(96), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("MotionBlurComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x60 (96)
		
		protected float m_CutoffGradientScale = new float();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(686258422)]
		public float CutoffGradientScale { get { return m_CutoffGradientScale; } set { if (OnPropertyChanging("MotionBlurComponentData." + nameof(CutoffGradientScale), this, m_CutoffGradientScale, value)) m_CutoffGradientScale = value; } } // 0x64 (100)
		
		protected float m_MotionBlurCutoffRadius = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1171302503)]
		public float MotionBlurCutoffRadius { get { return m_MotionBlurCutoffRadius; } set { if (OnPropertyChanging("MotionBlurComponentData." + nameof(MotionBlurCutoffRadius), this, m_MotionBlurCutoffRadius, value)) m_MotionBlurCutoffRadius = value; } } // 0x68 (104)
		
		protected bool m_MotionBlurEnable = new bool();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1384583315)]
		public bool MotionBlurEnable { get { return m_MotionBlurEnable; } set { if (OnPropertyChanging("MotionBlurComponentData." + nameof(MotionBlurEnable), this, m_MotionBlurEnable, value)) m_MotionBlurEnable = value; } } // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 686258422:
					CutoffGradientScale = (float) p_Value;
					break;

				case 1171302503:
					MotionBlurCutoffRadius = (float) p_Value;
					break;

				case 1384583315:
					MotionBlurEnable = (bool) p_Value;
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
				case 229961746:
					return Realm;

				case 686258422:
					return CutoffGradientScale;

				case 1171302503:
					return MotionBlurCutoffRadius;

				case 1384583315:
					return MotionBlurEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(MotionBlurComponentData).GetProperty(nameof(Realm));

				case 686258422:
					return typeof(MotionBlurComponentData).GetProperty(nameof(CutoffGradientScale));

				case 1171302503:
					return typeof(MotionBlurComponentData).GetProperty(nameof(MotionBlurCutoffRadius));

				case 1384583315:
					return typeof(MotionBlurComponentData).GetProperty(nameof(MotionBlurEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
