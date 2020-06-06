///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class UIRenderCompData : 
		UIComponentData
	{
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 BackgroundRect1 { get; set; } = new Vec4(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 BackgroundRect0 { get; set; } = new Vec4(); // 0x30 (48)
		
		[ContainerField(64)]
		public CtrRef<TextureAsset> BgTexture2 { get; set; } = new CtrRef<TextureAsset>(); // 0x40 (64)
		
		[ContainerField(68)]
		public CtrRef<TextureAsset> BgTexture1 { get; set; } = new CtrRef<TextureAsset>(); // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float AlphaMin { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float AlphaAnimationSpeed { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float AlphaOffset { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float AlphaMax { get; set; } // 0x54 (84)
		
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
