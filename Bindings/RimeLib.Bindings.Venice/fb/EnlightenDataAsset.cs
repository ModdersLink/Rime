///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class EnlightenDataAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<TextureAsset> DebugBackFaceTexture { get; set; } = new CtrRef<TextureAsset>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int MaxResolutionY { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<TextureAsset> DebugChartTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<TextureAsset> SkyVisibilityTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float VisibilityThreshold { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public int MaxResolutionX { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool LoadDebugData { get; set; } // 0x24 (36)
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool DynamicEnable { get; set; } // 0x25 (37)
		
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
