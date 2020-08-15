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
	[ContainerType(16)]
	public class EnlightenState : 
		DataContainer
	{
		protected Vec3 m_SkyBoxGroundColor = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2438224137)]
		public Vec3 SkyBoxGroundColor { get { return m_SkyBoxGroundColor; } set { if (OnPropertyChanging("EnlightenState." + nameof(SkyBoxGroundColor), this, m_SkyBoxGroundColor, value)) m_SkyBoxGroundColor = value; } } // 0x10 (16)
		
		protected Vec3 m_SkyBoxSunLightColor = new Vec3();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2622963034)]
		public Vec3 SkyBoxSunLightColor { get { return m_SkyBoxSunLightColor; } set { if (OnPropertyChanging("EnlightenState." + nameof(SkyBoxSunLightColor), this, m_SkyBoxSunLightColor, value)) m_SkyBoxSunLightColor = value; } } // 0x20 (32)
		
		protected Vec3 m_SkyBoxBackLightColor = new Vec3();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(554253337)]
		public Vec3 SkyBoxBackLightColor { get { return m_SkyBoxBackLightColor; } set { if (OnPropertyChanging("EnlightenState." + nameof(SkyBoxBackLightColor), this, m_SkyBoxBackLightColor, value)) m_SkyBoxBackLightColor = value; } } // 0x30 (48)
		
		protected Vec3 m_SkyBoxSkyColor = new Vec3();
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(573165997)]
		public Vec3 SkyBoxSkyColor { get { return m_SkyBoxSkyColor; } set { if (OnPropertyChanging("EnlightenState." + nameof(SkyBoxSkyColor), this, m_SkyBoxSkyColor, value)) m_SkyBoxSkyColor = value; } } // 0x40 (64)
		
		protected float m_SunScale = new float();
		[ContainerField(80), LayoutImmutable, Blittable, ContainerFieldNameHash(2209231701)]
		public float SunScale { get { return m_SunScale; } set { if (OnPropertyChanging("EnlightenState." + nameof(SunScale), this, m_SunScale, value)) m_SunScale = value; } } // 0x50 (80)
		
		protected float m_OutputScale = new float();
		[ContainerField(84), LayoutImmutable, Blittable, ContainerFieldNameHash(734776130)]
		public float OutputScale { get { return m_OutputScale; } set { if (OnPropertyChanging("EnlightenState." + nameof(OutputScale), this, m_OutputScale, value)) m_OutputScale = value; } } // 0x54 (84)
		
		protected float m_BounceScale = new float();
		[ContainerField(88), LayoutImmutable, Blittable, ContainerFieldNameHash(1158285805)]
		public float BounceScale { get { return m_BounceScale; } set { if (OnPropertyChanging("EnlightenState." + nameof(BounceScale), this, m_BounceScale, value)) m_BounceScale = value; } } // 0x58 (88)
		
		protected float m_SkyBoxSunLightColorSize = new float();
		[ContainerField(92), LayoutImmutable, Blittable, ContainerFieldNameHash(1176662367)]
		public float SkyBoxSunLightColorSize { get { return m_SkyBoxSunLightColorSize; } set { if (OnPropertyChanging("EnlightenState." + nameof(SkyBoxSunLightColorSize), this, m_SkyBoxSunLightColorSize, value)) m_SkyBoxSunLightColorSize = value; } } // 0x5C (92)
		
		protected float m_SkyBoxBackLightRotationY = new float();
		[ContainerField(96), LayoutImmutable, Blittable, ContainerFieldNameHash(533859401)]
		public float SkyBoxBackLightRotationY { get { return m_SkyBoxBackLightRotationY; } set { if (OnPropertyChanging("EnlightenState." + nameof(SkyBoxBackLightRotationY), this, m_SkyBoxBackLightRotationY, value)) m_SkyBoxBackLightRotationY = value; } } // 0x60 (96)
		
		protected float m_SkyBoxBackLightColorSize = new float();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(3173445660)]
		public float SkyBoxBackLightColorSize { get { return m_SkyBoxBackLightColorSize; } set { if (OnPropertyChanging("EnlightenState." + nameof(SkyBoxBackLightColorSize), this, m_SkyBoxBackLightColorSize, value)) m_SkyBoxBackLightColorSize = value; } } // 0x64 (100)
		
		protected float m_SkyBoxBackLightRotationX = new float();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(533859400)]
		public float SkyBoxBackLightRotationX { get { return m_SkyBoxBackLightRotationX; } set { if (OnPropertyChanging("EnlightenState." + nameof(SkyBoxBackLightRotationX), this, m_SkyBoxBackLightRotationX, value)) m_SkyBoxBackLightRotationX = value; } } // 0x68 (104)
		
		protected bool m_SkyBoxEnable = new bool();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(2201282448)]
		public bool SkyBoxEnable { get { return m_SkyBoxEnable; } set { if (OnPropertyChanging("EnlightenState." + nameof(SkyBoxEnable), this, m_SkyBoxEnable, value)) m_SkyBoxEnable = value; } } // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2438224137:
					SkyBoxGroundColor = (Vec3) p_Value;
					break;

				case 2622963034:
					SkyBoxSunLightColor = (Vec3) p_Value;
					break;

				case 554253337:
					SkyBoxBackLightColor = (Vec3) p_Value;
					break;

				case 573165997:
					SkyBoxSkyColor = (Vec3) p_Value;
					break;

				case 2209231701:
					SunScale = (float) p_Value;
					break;

				case 734776130:
					OutputScale = (float) p_Value;
					break;

				case 1158285805:
					BounceScale = (float) p_Value;
					break;

				case 1176662367:
					SkyBoxSunLightColorSize = (float) p_Value;
					break;

				case 533859401:
					SkyBoxBackLightRotationY = (float) p_Value;
					break;

				case 3173445660:
					SkyBoxBackLightColorSize = (float) p_Value;
					break;

				case 533859400:
					SkyBoxBackLightRotationX = (float) p_Value;
					break;

				case 2201282448:
					SkyBoxEnable = (bool) p_Value;
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
				case 2438224137:
					return SkyBoxGroundColor;

				case 2622963034:
					return SkyBoxSunLightColor;

				case 554253337:
					return SkyBoxBackLightColor;

				case 573165997:
					return SkyBoxSkyColor;

				case 2209231701:
					return SunScale;

				case 734776130:
					return OutputScale;

				case 1158285805:
					return BounceScale;

				case 1176662367:
					return SkyBoxSunLightColorSize;

				case 533859401:
					return SkyBoxBackLightRotationY;

				case 3173445660:
					return SkyBoxBackLightColorSize;

				case 533859400:
					return SkyBoxBackLightRotationX;

				case 2201282448:
					return SkyBoxEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2438224137:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxGroundColor));

				case 2622963034:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxSunLightColor));

				case 554253337:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxBackLightColor));

				case 573165997:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxSkyColor));

				case 2209231701:
					return typeof(EnlightenState).GetProperty(nameof(SunScale));

				case 734776130:
					return typeof(EnlightenState).GetProperty(nameof(OutputScale));

				case 1158285805:
					return typeof(EnlightenState).GetProperty(nameof(BounceScale));

				case 1176662367:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxSunLightColorSize));

				case 533859401:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxBackLightRotationY));

				case 3173445660:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxBackLightColorSize));

				case 533859400:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxBackLightRotationX));

				case 2201282448:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
