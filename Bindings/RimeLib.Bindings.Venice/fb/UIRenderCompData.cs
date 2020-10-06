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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(96), ContainerClass]
	public class UIRenderCompData : 
		UIComponentData
	{
		protected Vec4 m_BackgroundRect1 = new Vec4();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2991039386)]
		public Vec4 BackgroundRect1 { get { return m_BackgroundRect1; } set { if (OnPropertyChanging("UIRenderCompData." + nameof(BackgroundRect1), this, m_BackgroundRect1, value)) m_BackgroundRect1 = value; } } // 0x20 (32)
		
		protected Vec4 m_BackgroundRect0 = new Vec4();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2991039387)]
		public Vec4 BackgroundRect0 { get { return m_BackgroundRect0; } set { if (OnPropertyChanging("UIRenderCompData." + nameof(BackgroundRect0), this, m_BackgroundRect0, value)) m_BackgroundRect0 = value; } } // 0x30 (48)
		
		protected CtrRef<TextureAsset> m_BgTexture2 = new CtrRef<TextureAsset>();
		[ContainerField(64), MemberInfoFlag(53), ContainerFieldNameHash(1961408333), ContainerCtrRef]
		public CtrRef<TextureAsset> BgTexture2 { get { return m_BgTexture2; } set { if (OnPropertyChanging("UIRenderCompData." + nameof(BgTexture2), this, m_BgTexture2, value)) m_BgTexture2 = value; } } // 0x40 (64)
		
		protected CtrRef<TextureAsset> m_BgTexture1 = new CtrRef<TextureAsset>();
		[ContainerField(68), MemberInfoFlag(53), ContainerFieldNameHash(1961408334), ContainerCtrRef]
		public CtrRef<TextureAsset> BgTexture1 { get { return m_BgTexture1; } set { if (OnPropertyChanging("UIRenderCompData." + nameof(BgTexture1), this, m_BgTexture1, value)) m_BgTexture1 = value; } } // 0x44 (68)
		
		protected float m_AlphaMin = new float();
		[ContainerField(72), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4095153339)]
		public float AlphaMin { get { return m_AlphaMin; } set { if (OnPropertyChanging("UIRenderCompData." + nameof(AlphaMin), this, m_AlphaMin, value)) m_AlphaMin = value; } } // 0x48 (72)
		
		protected float m_AlphaAnimationSpeed = new float();
		[ContainerField(76), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1710921088)]
		public float AlphaAnimationSpeed { get { return m_AlphaAnimationSpeed; } set { if (OnPropertyChanging("UIRenderCompData." + nameof(AlphaAnimationSpeed), this, m_AlphaAnimationSpeed, value)) m_AlphaAnimationSpeed = value; } } // 0x4C (76)
		
		protected float m_AlphaOffset = new float();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(700046300)]
		public float AlphaOffset { get { return m_AlphaOffset; } set { if (OnPropertyChanging("UIRenderCompData." + nameof(AlphaOffset), this, m_AlphaOffset, value)) m_AlphaOffset = value; } } // 0x50 (80)
		
		protected float m_AlphaMax = new float();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4095153573)]
		public float AlphaMax { get { return m_AlphaMax; } set { if (OnPropertyChanging("UIRenderCompData." + nameof(AlphaMax), this, m_AlphaMax, value)) m_AlphaMax = value; } } // 0x54 (84)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2991039386:
					BackgroundRect1 = (Vec4) p_Value;
					break;

				case 2991039387:
					BackgroundRect0 = (Vec4) p_Value;
					break;

				case 1961408333:
					BgTexture2 = (CtrRef<TextureAsset>) p_Value;
					break;

				case 1961408334:
					BgTexture1 = (CtrRef<TextureAsset>) p_Value;
					break;

				case 4095153339:
					AlphaMin = (float) p_Value;
					break;

				case 1710921088:
					AlphaAnimationSpeed = (float) p_Value;
					break;

				case 700046300:
					AlphaOffset = (float) p_Value;
					break;

				case 4095153573:
					AlphaMax = (float) p_Value;
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
				case 2991039386:
					return BackgroundRect1;

				case 2991039387:
					return BackgroundRect0;

				case 1961408333:
					return BgTexture2;

				case 1961408334:
					return BgTexture1;

				case 4095153339:
					return AlphaMin;

				case 1710921088:
					return AlphaAnimationSpeed;

				case 700046300:
					return AlphaOffset;

				case 4095153573:
					return AlphaMax;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2991039386:
					return typeof(UIRenderCompData).GetProperty(nameof(BackgroundRect1));

				case 2991039387:
					return typeof(UIRenderCompData).GetProperty(nameof(BackgroundRect0));

				case 1961408333:
					return typeof(UIRenderCompData).GetProperty(nameof(BgTexture2));

				case 1961408334:
					return typeof(UIRenderCompData).GetProperty(nameof(BgTexture1));

				case 4095153339:
					return typeof(UIRenderCompData).GetProperty(nameof(AlphaMin));

				case 1710921088:
					return typeof(UIRenderCompData).GetProperty(nameof(AlphaAnimationSpeed));

				case 700046300:
					return typeof(UIRenderCompData).GetProperty(nameof(AlphaOffset));

				case 4095153573:
					return typeof(UIRenderCompData).GetProperty(nameof(AlphaMax));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
