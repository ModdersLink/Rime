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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class EnlightenDataAsset : 
		Asset
	{
		protected CtrRef<TextureAsset> m_DebugBackFaceTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "DebugBackFaceTexture", Offset: 12, NameHash: 848656257, Flags: 53)]
		public CtrRef<TextureAsset> DebugBackFaceTexture { get { return m_DebugBackFaceTexture; } set { if (OnPropertyChanging("EnlightenDataAsset." + nameof(DebugBackFaceTexture), this, m_DebugBackFaceTexture, value)) m_DebugBackFaceTexture = value; } } // 0xC (12)
		
		protected int m_MaxResolutionY = new int();
		[ContainerField(Name: "MaxResolutionY", Offset: 16, NameHash: 809334598, Flags: 49405), LayoutImmutable, Blittable]
		public int MaxResolutionY { get { return m_MaxResolutionY; } set { if (OnPropertyChanging("EnlightenDataAsset." + nameof(MaxResolutionY), this, m_MaxResolutionY, value)) m_MaxResolutionY = value; } } // 0x10 (16)
		
		protected CtrRef<TextureAsset> m_DebugChartTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "DebugChartTexture", Offset: 20, NameHash: 2176182983, Flags: 53)]
		public CtrRef<TextureAsset> DebugChartTexture { get { return m_DebugChartTexture; } set { if (OnPropertyChanging("EnlightenDataAsset." + nameof(DebugChartTexture), this, m_DebugChartTexture, value)) m_DebugChartTexture = value; } } // 0x14 (20)
		
		protected CtrRef<TextureAsset> m_SkyVisibilityTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "SkyVisibilityTexture", Offset: 24, NameHash: 4105463997, Flags: 53)]
		public CtrRef<TextureAsset> SkyVisibilityTexture { get { return m_SkyVisibilityTexture; } set { if (OnPropertyChanging("EnlightenDataAsset." + nameof(SkyVisibilityTexture), this, m_SkyVisibilityTexture, value)) m_SkyVisibilityTexture = value; } } // 0x18 (24)
		
		protected float m_VisibilityThreshold = new float();
		[ContainerField(Name: "VisibilityThreshold", Offset: 28, NameHash: 525146964, Flags: 49469), LayoutImmutable, Blittable]
		public float VisibilityThreshold { get { return m_VisibilityThreshold; } set { if (OnPropertyChanging("EnlightenDataAsset." + nameof(VisibilityThreshold), this, m_VisibilityThreshold, value)) m_VisibilityThreshold = value; } } // 0x1C (28)
		
		protected int m_MaxResolutionX = new int();
		[ContainerField(Name: "MaxResolutionX", Offset: 32, NameHash: 809334599, Flags: 49405), LayoutImmutable, Blittable]
		public int MaxResolutionX { get { return m_MaxResolutionX; } set { if (OnPropertyChanging("EnlightenDataAsset." + nameof(MaxResolutionX), this, m_MaxResolutionX, value)) m_MaxResolutionX = value; } } // 0x20 (32)
		
		protected bool m_LoadDebugData = new bool();
		[ContainerField(Name: "LoadDebugData", Offset: 36, NameHash: 1478578882, Flags: 49325), LayoutImmutable, Blittable]
		public bool LoadDebugData { get { return m_LoadDebugData; } set { if (OnPropertyChanging("EnlightenDataAsset." + nameof(LoadDebugData), this, m_LoadDebugData, value)) m_LoadDebugData = value; } } // 0x24 (36)
		
		protected bool m_DynamicEnable = new bool();
		[ContainerField(Name: "DynamicEnable", Offset: 37, NameHash: 2376411633, Flags: 49325), LayoutImmutable, Blittable]
		public bool DynamicEnable { get { return m_DynamicEnable; } set { if (OnPropertyChanging("EnlightenDataAsset." + nameof(DynamicEnable), this, m_DynamicEnable, value)) m_DynamicEnable = value; } } // 0x25 (37)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 848656257:
					DebugBackFaceTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 809334598:
					MaxResolutionY = (int) p_Value;
					break;

				case 2176182983:
					DebugChartTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 4105463997:
					SkyVisibilityTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 525146964:
					VisibilityThreshold = (float) p_Value;
					break;

				case 809334599:
					MaxResolutionX = (int) p_Value;
					break;

				case 1478578882:
					LoadDebugData = (bool) p_Value;
					break;

				case 2376411633:
					DynamicEnable = (bool) p_Value;
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
				case 848656257:
					return DebugBackFaceTexture;

				case 809334598:
					return MaxResolutionY;

				case 2176182983:
					return DebugChartTexture;

				case 4105463997:
					return SkyVisibilityTexture;

				case 525146964:
					return VisibilityThreshold;

				case 809334599:
					return MaxResolutionX;

				case 1478578882:
					return LoadDebugData;

				case 2376411633:
					return DynamicEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 848656257:
					return typeof(EnlightenDataAsset).GetProperty(nameof(DebugBackFaceTexture));

				case 809334598:
					return typeof(EnlightenDataAsset).GetProperty(nameof(MaxResolutionY));

				case 2176182983:
					return typeof(EnlightenDataAsset).GetProperty(nameof(DebugChartTexture));

				case 4105463997:
					return typeof(EnlightenDataAsset).GetProperty(nameof(SkyVisibilityTexture));

				case 525146964:
					return typeof(EnlightenDataAsset).GetProperty(nameof(VisibilityThreshold));

				case 809334599:
					return typeof(EnlightenDataAsset).GetProperty(nameof(MaxResolutionX));

				case 1478578882:
					return typeof(EnlightenDataAsset).GetProperty(nameof(LoadDebugData));

				case 2376411633:
					return typeof(EnlightenDataAsset).GetProperty(nameof(DynamicEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
